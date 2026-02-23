// Â© Copyright (c) V5iD, Inc. All rights reserved.
// Licensed under the MIT.

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using V5iD.PublicSdk.Clients;
using V5iD.PublicSdk.Models;
using V5iD.PublicSdk.Options;

namespace PublicSdk.Tests.Clients
{
    public class V5iDClientTests
    {
        [Fact]
        public async Task CreateWebVerificationWithNotificationAsync_ShouldUseDedicatedRoute_AndSendJsonPayload()
        {
            string? createRequestPath = null;
            string? createRequestBody = null;
            string? authorizationToken = null;
            var requestedPaths = new List<string>();

            var customerHandler = new StubHttpMessageHandler(async (request, cancellationToken) =>
            {
                var path = request.RequestUri?.PathAndQuery ?? string.Empty;
                requestedPaths.Add(path);

                if (path == "/verify/token")
                {
                    return CreateJsonResponse(HttpStatusCode.OK,
                        """
                        {
                          "access_token": "test-access-token",
                          "expires_in": 3600,
                          "token_type": "Bearer"
                        }
                        """);
                }

                if (path == "/verify/web/notification")
                {
                    createRequestPath = path;
                    authorizationToken = request.Headers.Authorization?.Parameter;
                    createRequestBody = request.Content is null
                        ? null
                        : await request.Content.ReadAsStringAsync(cancellationToken);

                    return CreateJsonResponse(HttpStatusCode.OK,
                        """
                        {
                          "verificationUuid": "verification-123",
                          "isWaitForStartVerification": false,
                          "redirectUrl": "https://example.test/redirect"
                        }
                        """);
                }

                return new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent($"Unexpected path: {path}")
                };
            });

            using var customerHttpClient = new HttpClient(customerHandler)
            {
                BaseAddress = new Uri("https://customer.test/")
            };

            using var uploaderHttpClient = new HttpClient(new StubHttpMessageHandler((_, _) =>
                Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK))))
            {
                BaseAddress = new Uri("https://uploader.test/")
            };

            var options = Options.Create(new VerificationSdkOptions
            {
                IntegrationUuid = "integration-id",
                IntegrationSecret = "integration-secret",
                CustomerApiBaseUrl = "https://customer.test/",
                UploaderApiBaseUrl = "https://uploader.test/",
                ThrowOnErrorStatusCode = false
            });

            using var client = new V5iDClient(options, customerHttpClient, uploaderHttpClient);

            var requestModel = new CreateWebVerificationWithNotificationRequest
            {
                ReferenceId = "ref-001",
                FirstName = "John",
                LastName = "Doe",
                Phone = "+15551234567",
                NotifyByEmailWhenVerificationIsComplete = true
            };

            var result = await client.CreateWebVerificationWithNotificationAsync(requestModel);

            Assert.True(result.IsSuccess);
            Assert.NotNull(result.Value);
            Assert.Equal("verification-123", result.Value!.VerificationUuid);
            Assert.Equal("https://example.test/redirect", result.Value.RedirectUrl);

            Assert.Equal("/verify/web/notification", createRequestPath);
            Assert.Equal("test-access-token", authorizationToken);
            Assert.Equal(new[] { "/verify/token", "/verify/web/notification" }, requestedPaths);

            Assert.NotNull(createRequestBody);
            using var bodyJson = JsonDocument.Parse(createRequestBody!);
            var root = bodyJson.RootElement;

            Assert.Equal("ref-001", root.GetProperty("referenceId").GetString());
            Assert.Equal("John", root.GetProperty("firstName").GetString());
            Assert.Equal("Doe", root.GetProperty("lastName").GetString());
            Assert.Equal("+15551234567", root.GetProperty("phone").GetString());
            Assert.True(root.GetProperty("notifyByEmailWhenVerificationIsComplete").GetBoolean());
        }

        private static HttpResponseMessage CreateJsonResponse(HttpStatusCode statusCode, string json)
        {
            return new HttpResponseMessage(statusCode)
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
        }

        private sealed class StubHttpMessageHandler : HttpMessageHandler
        {
            private readonly Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> _handler;

            public StubHttpMessageHandler(Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> handler)
            {
                _handler = handler;
            }

            protected override Task<HttpResponseMessage> SendAsync(
                HttpRequestMessage request,
                CancellationToken cancellationToken)
            {
                return _handler(request, cancellationToken);
            }
        }
    }
}
