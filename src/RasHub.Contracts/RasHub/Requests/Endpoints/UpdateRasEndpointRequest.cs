using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RasHub.Contracts.RasHub.Requests;

public sealed record UpdateRasEndpointRequest(
    [Required]
    [StringLength(200, MinimumLength = 1)]
    string Name,
    [property: JsonRequired] Guid RasGateId,
    [Required]
    [StringLength(255, MinimumLength = 1)]
    string Host,
    [Range(1, 65_535)] int Port,
    [property: JsonRequired] bool IsActive,
    [property: JsonRequired]
    [Range(1, long.MaxValue)] long ExpectedConfigurationRevision);
