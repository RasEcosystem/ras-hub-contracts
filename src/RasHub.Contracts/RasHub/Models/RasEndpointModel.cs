namespace RasHub.Contracts.RasHub.Models;

public sealed record RasEndpointModel
{
    public required Guid Id { get; init; }

    public required Guid RasGateId { get; init; }

    public required string Name { get; init; }

    public required string Host { get; init; }

    public required int Port { get; init; }

    public required bool IsActive { get; init; }

    public DateTime? LastSeenAt { get; init; }

    public required long ConfigurationRevision { get; init; }

    public required DateTime CreatedAt { get; init; }

    public required DateTime UpdatedAt { get; init; }
}
