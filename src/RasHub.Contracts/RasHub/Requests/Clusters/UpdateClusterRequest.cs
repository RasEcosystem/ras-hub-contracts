using System.ComponentModel.DataAnnotations;
using RasHub.Contracts.RasHub.Models;

namespace RasHub.Contracts.RasHub.Requests;

public sealed record UpdateClusterRequest(
    [StringLength(512, MinimumLength = 1)] string? Name = null,
    [Range(typeof(long), "0", "9223372036854775807")]
    long? ExpirationTimeoutSeconds = null,
    [Range(typeof(long), "0", "9223372036854775807")]
    long? LifetimeLimitSeconds = null,
    [Range(typeof(long), "0", "9223372036854775807")]
    long? MaxMemorySizeKb = null,
    [Range(typeof(long), "0", "9223372036854775807")]
    long? MaxMemoryTimeLimitSeconds = null,
    [Range(0, int.MaxValue)] int? SecurityLevel = null,
    [Range(0, int.MaxValue)] int? SessionFaultToleranceLevel = null,
    ClusterLoadBalancingMode? LoadBalancingMode = null,
    [Range(0, 100)] int? ErrorsCountThresholdPercent = null,
    bool? KillProblemProcesses = null,
    [StringLength(512, MinimumLength = 1)] string? AgentUser = null,
    [StringLength(512, MinimumLength = 1)] string? AgentPassword = null)
    : IValidatableObject
{
    public IEnumerable<ValidationResult> Validate(
        ValidationContext validationContext)
    {
        if (AgentPassword is not null && AgentUser is null)
            yield return new ValidationResult(
                "An agent user is required when an agent password is provided.",
                [nameof(AgentUser)]);

        if (Name is null &&
            ExpirationTimeoutSeconds is null &&
            LifetimeLimitSeconds is null &&
            MaxMemorySizeKb is null &&
            MaxMemoryTimeLimitSeconds is null &&
            SecurityLevel is null &&
            SessionFaultToleranceLevel is null &&
            LoadBalancingMode is null &&
            ErrorsCountThresholdPercent is null &&
            KillProblemProcesses is null)
            yield return new ValidationResult(
                "At least one cluster setting must be provided.");
    }

    public override string ToString()
    {
        return nameof(UpdateClusterRequest);
    }
}