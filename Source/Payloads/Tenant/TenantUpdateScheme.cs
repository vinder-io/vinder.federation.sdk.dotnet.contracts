namespace Vinder.Federation.Sdk.Contracts.Payloads.Tenant;

public sealed record TenantUpdateScheme
{
    [JsonIgnore]
    public string TenantId { get; init; } = default!;
    public string Name { get; init; } = default!;
    public string? Description { get; init; } = default!;
}