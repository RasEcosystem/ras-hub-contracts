using System.ComponentModel.DataAnnotations;

namespace RasHub.Contracts.RasHub.Requests.Search;

public sealed record SearchInfobasesRequest : IValidatableObject
{
    [Required]
    [StringLength(SearchRequestValidation.QueryMaxLength, MinimumLength = 1)]
    public required string Query { get; init; }

    public Guid? RasGateId { get; init; }

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

        if (RasGateId == Guid.Empty)
            yield return new ValidationResult(
                "The RasGate filter must not be empty.",
                [nameof(RasGateId)]);

        if (ClusterId == Guid.Empty)
            yield return new ValidationResult(
                "The cluster filter must not be empty.",
                [nameof(ClusterId)]);

        if (ClusterId is not null && RasGateId is null)
            yield return new ValidationResult(
                "A RasGate filter is required when a cluster filter is provided.",
                [nameof(RasGateId)]);
    }
}
