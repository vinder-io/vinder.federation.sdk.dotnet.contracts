namespace Vinder.IdentityProvider.Sdk.Contracts.Payloads.User;

public sealed record AssignUserPermissionContext
{
    [JsonIgnore]
    public string UserId { get; init; } = default!;
    public string PermissionName { get; init; } = default!;
}
