using System.Net;

namespace RasHub.Contracts.Common;

public interface IApiResponse
{
    bool Success { get; }

    HttpStatusCode StatusCode { get; }
}
