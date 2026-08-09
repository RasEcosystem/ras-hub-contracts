namespace RasHub.Contracts.RasHub.Models;

public sealed record RasClusterModel(
    Guid Id,
    string Name,
    string Host,
    int Port,
    long ExpirationTimeoutSeconds,
    long LifetimeLimitSeconds,
    long MaxMemorySizeKb,
    long MaxMemoryTimeLimitSeconds,
    int SecurityLevel,
    int SessionFaultToleranceLevel,
    RasClusterLoadBalancingMode LoadBalancingMode,
    int ErrorsCountThresholdPercent,
    bool KillProblemProcesses,
    bool KillByMemoryWithDump,
    bool AllowAccessRightAuditEventsRecording,
    long PingPeriod,
    long PingTimeout,
    string RestartSchedule,
    DateTime ObservedAt);