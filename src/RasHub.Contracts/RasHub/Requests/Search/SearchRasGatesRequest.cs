using System.ComponentModel.DataAnnotations;

namespace RasHub.Contracts.RasHub.Requests.Search;

public sealed record SearchRasGatesRequest : IValidatableObject
{
    [Required]
    [StringLength(SearchRequestValidation.QueryMaxLength, MinimumLength = 1)]
    public required string Query { get; init; }

    public RasGateSearchField[]? Fields { get; init; }

    public IEnumerable<ValidationResult> Validate(
        ValidationContext validationContext)
    {
        foreach (var result in SearchRequestValidation.Validate(
                     Query,
                     Fields,
                     nameof(Query),
                     nameof(Fields)))
            yield return result;
    }
}
