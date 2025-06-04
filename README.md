[![](https://img.shields.io/nuget/v/soenneker.resend.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.resend.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.resend.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.resend.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.resend.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.resend.openapiclient/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Resend.OpenApiClient

A modern, type-safe .NET client for the Resend API, automatically generated from their OpenAPI schema and updated daily. This client provides a seamless way to interact with Resend's email delivery platform in your .NET applications.

## Features

- 🚀 **Fully Generated**: Automatically generated from Resend's OpenAPI schema
- 🔄 **Daily Updates**: Always up-to-date with the latest Resend API features
- 🎯 **Type-Safe**: Full IntelliSense support and compile-time type checking
- 📝 **Well-Documented**: XML documentation included for all types and methods

## Installation

```bash
dotnet add package Soenneker.Resend.OpenApiClient
```

## Quick Start

```csharp
using Soenneker.Resend.OpenApiClient;
using Soenneker.Resend.OpenApiClient.Models;

// Initialize the client with your API key
var client = new ResendOpenApiClient(new HttpClientRequestAdapter(new ApiKeyAuthenticationProvider("re_123...")));

// Create an email request
var emailRequest = new SendEmailRequest
{
    From = "onboarding@resend.dev",
    To = new List<string> { "user@example.com" },
    Subject = "Hello World",
    Html = "<p>Congrats on sending your first email!</p>"
};

// Send the email
var response = await client.Emails.PostAsync(emailRequest);
```

## API Capabilities

The client supports all Resend API endpoints, including:

- 📧 Email sending and management
- 📬 Email templates
- 🔑 API key management
- 🌐 Domain management
- 📊 Email analytics
- 📝 Broadcast management
- 👥 Audience management