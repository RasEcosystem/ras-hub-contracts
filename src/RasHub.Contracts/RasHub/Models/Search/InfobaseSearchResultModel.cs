namespace RasHub.Contracts.RasHub.Models.Search;

public sealed record InfobaseSearchResultModel
{
    public required Guid RasGateId { get; init; }

    public required string RasGateName { get; init; }

    public required Guid ClusterId { get; init; }

    public required string ClusterName { get; init; }

    public required InfobaseModel Infobase { get; init; }
}
