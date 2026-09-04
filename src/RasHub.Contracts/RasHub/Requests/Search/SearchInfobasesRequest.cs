using System.ComponentModel.DataAnnotations;

namespace RasHub.Contracts.RasHub.Requests.Search;

public sealed record SearchInfobasesRequest : IValidatableObject
{
    [Required]
    [StringLength(SearchRequestValidation.QueryMaxLength, MinimumLength = 1)]
    public required string Query { get; init; }

    public Guid? RasEndpointId { get; init; }

    public Guid? ClusterId { get; init; }

    public InfobaseSearchField[]? Fields { get; init; }

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

        if (ClusterId == Guid.Empty)
            yield return new ValidationResult(
                "The cluster filter must not be empty.",
                [nameof(ClusterId)]);

        if (ClusterId is not null && RasEndpointId is null)
            yield return new ValidationResult(
                "A RAS endpoint filter is required when a cluster filter is provided.",
                [nameof(RasEndpointId)]);
    }
}
