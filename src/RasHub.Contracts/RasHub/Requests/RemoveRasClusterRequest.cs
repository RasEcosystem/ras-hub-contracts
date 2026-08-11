using System.ComponentModel.DataAnnotations;

namespace RasHub.Contracts.RasHub.Requests;

public sealed record RemoveRasClusterRequest(
    [StringLength(512, MinimumLength = 1)] string? ClusterUser = null,
    [StringLength(512, MinimumLength = 1)] string? ClusterPassword = null)
    : IValidatableObject
{
    public IEnumerable<ValidationResult> Validate(
        ValidationContext validationContext)
    {
        if (ClusterPassword is not null && ClusterUser is null)
            yield return new ValidationResult(
                "A cluster user is required when a cluster password is provided.",
                [nameof(ClusterUser)]);
    }
}