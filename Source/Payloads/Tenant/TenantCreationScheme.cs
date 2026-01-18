namespace Vinder.Federation.Sdk.Contracts.Payloads.Tenant;

public sealed record TenantCreationScheme
{
    public string Name { get; init; } = default!;
    public string? Description { get; init; } = default!;
}
