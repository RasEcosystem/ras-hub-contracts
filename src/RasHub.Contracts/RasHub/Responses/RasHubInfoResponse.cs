namespace RasHub.Contracts.RasHub.Responses;

public sealed record RasHubInfoResponse
{
    public required string Version { get; init; }
}