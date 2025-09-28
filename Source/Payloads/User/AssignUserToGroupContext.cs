namespace Vinder.IdentityProvider.Sdk.Contracts.Payloads.User;

public sealed record AssignUserToGroupContext
{
    [JsonIgnore]
    public string UserId { get; init; } = default!;
    public string GroupId { get; init; } = default!;
}
