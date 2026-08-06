using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RasHub.Contracts.Common.Pagination;

public sealed record PageRequest(
    [property: DefaultValue(1)]
    [Range(1, int.MaxValue)]
    int Page = 1,
    [property: DefaultValue(10)]
    [Range(1, 100)]
    int PageSize = 10);