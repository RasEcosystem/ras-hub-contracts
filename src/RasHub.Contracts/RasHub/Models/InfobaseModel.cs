namespace RasHub.Contracts.RasHub.Models;

public sealed record InfobaseModel(
    Guid Id,
    string Name,
    string Description,
    DateTime ObservedAt);