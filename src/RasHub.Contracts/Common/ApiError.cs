using System.Text.Json.Serialization;

namespace RasHub.Contracts.Common;

public sealed record ApiError(
    string Code,
    string Message,
    [property: JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    string? Target = null);