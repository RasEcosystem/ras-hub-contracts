using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RasHub.Contracts.RasHub.Requests;

public sealed record UpdateRasGateRequest(
    [Required]
    [StringLength(200, MinimumLength = 1)]
    string Name,
    [Required]
    [StringLength(2_048, MinimumLength = 1)]
    string Url,
    [Range(1, 65_535)] int Port,
    [property: JsonRequired] bool IsActive,
    [property: JsonRequired]
    [Range(1, long.MaxValue)] long ExpectedConfigurationRevision,
    [StringLength(512, MinimumLength = 1)] string? ApiKey = null)
{
    public override string ToString()
    {
        return nameof(UpdateRasGateRequest);
    }
}
