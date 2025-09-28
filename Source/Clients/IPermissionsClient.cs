namespace Vinder.IdentityProvider.Sdk.Contracts.Clients;

public interface IPermissionsClient
{
    public Task<Result<Pagination<PermissionDetails>>> GetPermissionsAsync(
        PermissionsFetchParameters parameters,
        CancellationToken cancellation = default
    );

    public Task<Result<PermissionDetails>> CreatePermissionAsync(
        PermissionForCreation permission,
        CancellationToken cancellation = default
    );
    public Task<Result<PermissionDetails>> UpdatePermissionAsync(
        PermissionForUpdate permission,
        CancellationToken cancellation = default
    );

    public Task<Result> DeletePermissionAsync(
        string permissionId,
        CancellationToken cancellation = default
    );
}