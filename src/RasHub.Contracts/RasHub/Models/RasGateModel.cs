namespace RasHub.Contracts.RasHub.Models;

public record RasGateModel(
    Guid Id,
    string Name,
    string Url,
    int Port,
    DateTime CreatedAt,
    DateTime UpdatedAt);