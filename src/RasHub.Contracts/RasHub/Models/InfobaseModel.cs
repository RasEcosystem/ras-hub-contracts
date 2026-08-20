namespace RasHub.Contracts.RasHub.Models;

public sealed record InfobaseModel
{
    public required Guid Id { get; init; }

    public required string Name { get; init; }

    public required string Description { get; init; }

    public required DateTime ObservedAt { get; init; }
}