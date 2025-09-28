namespace Vinder.IdentityProvider.Sdk.Contracts.Payloads.Permission;

public sealed record PermissionForUpdate
{
    [JsonIgnore]
    public string PermissionId { get; init; } = default!;
    public string Name { get; init; } = default!;
    public string? Description { get; init; } = default!;
}
