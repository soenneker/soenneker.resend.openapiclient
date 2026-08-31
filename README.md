[![](https://img.shields.io/nuget/v/soenneker.resend.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.resend.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.resend.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.resend.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.resend.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.resend.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.resend.openapiclient/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.resend.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Resend.OpenApiClient

Generated request builders and models for Resend email, domains, contacts, audiences, broadcasts, templates, topics, events, logs, webhooks, and API keys.

## Installation

```bash
dotnet add package Soenneker.Resend.OpenApiClient
```

## Usage

```csharp
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Resend.OpenApiClient;

using var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization =
    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiKey);
httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("MyApplication/1.0");

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient)
{
    BaseUrl = "https://api.resend.com"
};

var client = new ResendOpenApiClient(adapter);
var domains = await client.Domains.GetAsync(
    cancellationToken: cancellationToken);
```

Resend API keys use the bearer scheme. Resend also requires a `User-Agent` header for direct HTTP requests. The anonymous Kiota authentication provider is intentional because the supplied `HttpClient` already carries both required headers.

List endpoints support cursor pagination. Use their `limit`, `after`, and `before` query parameters where exposed rather than assuming a response contains every item.
