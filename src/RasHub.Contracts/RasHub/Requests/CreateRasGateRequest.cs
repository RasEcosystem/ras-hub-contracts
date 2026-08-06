using System.ComponentModel.DataAnnotations;

namespace RasHub.Contracts.RasHub.Requests;

public sealed record CreateRasGateRequest(
    [Required]
    [StringLength(200, MinimumLength = 1)]
    string Name,
    [Required]
    [StringLength(2_048, MinimumLength = 1)]
    string Url,
    [Range(1, 65_535)] int Port,
    [Required]
    [StringLength(512, MinimumLength = 1)]
    string ApiKey);