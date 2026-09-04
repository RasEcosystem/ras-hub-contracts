namespace RasHub.Contracts.RasHub.Models.Search;

public sealed record ClusterSearchResultModel
{
    public required Guid RasEndpointId { get; init; }

    public required string RasEndpointName { get; init; }

    public required ClusterModel Cluster { get; init; }
}
