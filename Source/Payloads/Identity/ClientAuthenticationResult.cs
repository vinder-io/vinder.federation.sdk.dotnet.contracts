namespace Vinder.Federation.Sdk.Contracts.Payloads.Identity;

public sealed record ClientAuthenticationResult
{
    public string AccessToken { get; init; } = default!;
}