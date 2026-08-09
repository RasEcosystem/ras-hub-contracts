namespace RasHub.Contracts.RasHub.Responses;

public sealed record RasGateStatusResponse
{
    public string? InstanceName { get; init; }

    public string? Version { get; init; }

    public DateTime? ObservedAt { get; init; }
}