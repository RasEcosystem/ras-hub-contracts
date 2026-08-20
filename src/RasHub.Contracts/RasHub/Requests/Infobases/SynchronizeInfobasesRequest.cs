using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RasHub.Contracts.RasHub.Requests;

public sealed class SynchronizeInfobasesRequest : IValidatableObject
{
    [DefaultValue(1)]
    [Range(1, int.MaxValue)]
    public int Page { get; init; } = 1;

    [DefaultValue(10)] [Range(1, 100)] public int PageSize { get; init; } = 10;

    [StringLength(512, MinimumLength = 1)] public string? ClusterUser { get; init; }

    [StringLength(512, MinimumLength = 1)] public string? ClusterPassword { get; init; }

    public IEnumerable<ValidationResult> Validate(
        ValidationContext validationContext)
    {
        if (ClusterPassword is not null && ClusterUser is null)
            yield return new ValidationResult(
                "A cluster user is required when a cluster password is provided.",
                [nameof(ClusterUser)]);
    }

    public override string ToString()
    {
        return nameof(SynchronizeInfobasesRequest);
    }
}