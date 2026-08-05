using System.ComponentModel;

namespace RasHub.Contracts.Common.Pagination;

public sealed record PageRequest(
    [property: DefaultValue(1)] int Page = 1,
    [property: DefaultValue(10)] int PageSize = 10);