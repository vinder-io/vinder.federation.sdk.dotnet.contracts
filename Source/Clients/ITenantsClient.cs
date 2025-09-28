namespace Vinder.IdentityProvider.Sdk.Contracts.Clients;

public interface ITenantsClient
{
    public Task<Result<Pagination<TenantDetails>>> GetTenantsAsync(
        TenantFetchParameters parameters,
        CancellationToken cancellation = default
    );

    public Task<Result<TenantDetails>> CreateTenantAsync(
        TenantForCreation tenant,
        CancellationToken cancellation = default
    );

    public Task<Result<TenantDetails>> UpdateTenantAsync(
        TenantForUpdate tenant,
        CancellationToken cancellation = default
    );

    public Task<Result> DeleteTenantAsync(
        string tenantId,
        CancellationToken cancellation = default
    );
}
