namespace Vinder.Federation.Sdk.Contracts.Clients;

public interface IOpenIDConnectClient
{
    public Task<Result<ClientAuthenticationResult>> AuthenticateAsync(
        ClientAuthenticationCredentials credentials,
        CancellationToken cancellation = default
    );
}