using System.ComponentModel.DataAnnotations;

namespace RasHub.Contracts.RasHub.Requests.Search;

internal static class SearchRequestValidation
{
    public const int QueryMaxLength = 200;

    public static IEnumerable<ValidationResult> Validate<TField>(
        string query,
        TField[]? fields,
        string queryMemberName,
        string fieldsMemberName)
        where TField : struct, Enum
    {
        if (string.IsNullOrWhiteSpace(query))
            yield return new ValidationResult(
                "A non-whitespace search query is required.",
                [queryMemberName]);

        if (fields?.Any(field => !Enum.IsDefined(field)) is true)
            yield return new ValidationResult(
                "One or more search fields are invalid.",
                [fieldsMemberName]);
    }
}
