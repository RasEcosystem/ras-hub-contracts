namespace RasHub.Contracts.RasHub.Responses;

public sealed record RasHubStatusResponse
{
    public string Version { get; init; } = string.Empty;
}