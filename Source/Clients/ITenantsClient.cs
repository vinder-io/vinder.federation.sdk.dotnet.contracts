namespace Vinder.Federation.Sdk.Contracts.Clients;

public interface ITenantsClient
{
    public Task<Result<Pagination<TenantDetails>>> GetTenantsAsync(
        TenantFetchParameters parameters,
        CancellationToken cancellation = default
    );

    public Task<Result<TenantDetails>> CreateTenantAsync(
        TenantCreationScheme tenant,
        CancellationToken cancellation = default
    );

    public Task<Result<TenantDetails>> UpdateTenantAsync(
        TenantUpdateScheme tenant,
        CancellationToken cancellation = default
    );

    public Task<Result> DeleteTenantAsync(
        string tenantId,
        CancellationToken cancellation = default
    );
}
