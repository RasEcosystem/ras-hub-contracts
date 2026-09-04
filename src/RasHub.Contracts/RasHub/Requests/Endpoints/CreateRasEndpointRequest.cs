using System.ComponentModel.DataAnnotations;

namespace RasHub.Contracts.RasHub.Requests;

public sealed record CreateRasEndpointRequest(
    [Required]
    [StringLength(200, MinimumLength = 1)]
    string Name,
    [Required]
    [StringLength(255, MinimumLength = 1)]
    string Host,
    [Range(1, 65_535)] int Port,
    bool IsActive = true);
