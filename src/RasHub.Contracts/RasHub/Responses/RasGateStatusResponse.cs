using RasHub.Contracts.RasHub.Models;

namespace RasHub.Contracts.RasHub.Responses;

public sealed record RasGateStatusResponse
{
    public required RasGateHealthState State { get; init; }

    public string? InstanceName { get; init; }

    public string? RasGateVersion { get; init; }

    public DateTime? RasGateObservedAt { get; init; }

    public bool? RacAvailable { get; init; }

    public string? RacVersion { get; init; }

    public DateTime? RacObservedAt { get; init; }
}