using System.ComponentModel.DataAnnotations;

namespace RasHub.Contracts.RasHub.Requests.Search;

public sealed record SearchClustersRequest : IValidatableObject
{
    [Required]
    [StringLength(SearchRequestValidation.QueryMaxLength, MinimumLength = 1)]
    public required string Query { get; init; }

    public Guid? RasEndpointId { get; init; }

    public ClusterSearchField[]? Fields { get; init; }

    public IEnumerable<ValidationResult> Validate(
        ValidationContext validationContext)
    {
        foreach (var result in SearchRequestValidation.Validate(
                     Query,
                     Fields,
                     nameof(Query),
                     nameof(Fields)))
            yield return result;

        if (RasEndpointId == Guid.Empty)
            yield return new ValidationResult(
                "The RAS endpoint filter must not be empty.",
                [nameof(RasEndpointId)]);
    }
}
