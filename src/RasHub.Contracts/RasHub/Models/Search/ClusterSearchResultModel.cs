namespace RasHub.Contracts.RasHub.Models.Search;

public sealed record ClusterSearchResultModel
{
    public required Guid RasGateId { get; init; }

    public required string RasGateName { get; init; }

    public required ClusterModel Cluster { get; init; }
}
