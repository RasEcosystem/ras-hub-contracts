namespace RasHub.Contracts.RasHub.Responses;

public sealed record CollectionSynchronizationResponse
{
    public required int TotalCount { get; init; }

    public required DateTime ObservedAt { get; init; }
}