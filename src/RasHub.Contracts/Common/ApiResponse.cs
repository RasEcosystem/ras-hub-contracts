using System.Net;
using System.Text.Json.Serialization;

namespace RasHub.Contracts.Common;

public sealed class ApiResponse<T> : IApiResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyOrder(1)]
    public T? Data { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyOrder(2)]
    public ApiError? Error { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyOrder(3)]
    public IReadOnlyCollection<ApiError>? Errors { get; init; }

    [JsonPropertyOrder(0)] public bool Success { get; init; }

    [JsonIgnore] public HttpStatusCode StatusCode { get; private init; } = HttpStatusCode.OK;

    public static ApiResponse<T> Ok(T? data = default)
    {
        return new ApiResponse<T> { Success = true, Data = data, StatusCode = HttpStatusCode.OK };
    }

    public static ApiResponse<T> Created(T data)
    {
        return new ApiResponse<T> { Success = true, Data = data, StatusCode = HttpStatusCode.Created };
    }

    public static ApiResponse<T> Fail(HttpStatusCode statusCode)
    {
        return Fail(statusCode, GetDefaultError(statusCode));
    }

    public static ApiResponse<T> Fail(
        HttpStatusCode statusCode,
        string code,
        string message)
    {
        return Fail(statusCode, new ApiError(code, message));
    }

    public static ApiResponse<T> Fail(
        HttpStatusCode statusCode,
        ApiError error)
    {
        return new ApiResponse<T> { Success = false, Error = error, StatusCode = statusCode };
    }

    public static ApiResponse<T> Fail(
        HttpStatusCode statusCode,
        IEnumerable<ApiError> errors)
    {
        return Fail(statusCode, GetDefaultError(statusCode), errors);
    }

    public static ApiResponse<T> Fail(
        HttpStatusCode statusCode,
        ApiError error,
        IEnumerable<ApiError> errors)
    {
        return new ApiResponse<T> { Success = false, Error = error, Errors = errors.ToList(), StatusCode = statusCode };
    }

    private static ApiError GetDefaultError(HttpStatusCode status)
    {
        return status switch
        {
            HttpStatusCode.BadRequest =>
                new ApiError("bad_request", "Bad request"),
            HttpStatusCode.Unauthorized =>
                new ApiError("unauthorized", "Unauthorized"),
            HttpStatusCode.Forbidden =>
                new ApiError("forbidden", "Access denied"),
            HttpStatusCode.NotFound =>
                new ApiError("not_found", "Resource not found"),
            HttpStatusCode.MethodNotAllowed =>
                new ApiError("method_not_allowed", "Method not allowed"),
            HttpStatusCode.NotAcceptable =>
                new ApiError("not_acceptable", "Not acceptable"),
            HttpStatusCode.RequestTimeout =>
                new ApiError("request_timeout", "Request timed out"),
            HttpStatusCode.Conflict =>
                new ApiError("conflict", "Conflict"),
            HttpStatusCode.RequestEntityTooLarge =>
                new ApiError("request_too_large", "Request is too large"),
            HttpStatusCode.UnsupportedMediaType =>
                new ApiError("unsupported_media_type", "Unsupported media type"),
            HttpStatusCode.UnprocessableEntity =>
                new ApiError("unprocessable_entity", "Request could not be processed"),
            HttpStatusCode.TooManyRequests =>
                new ApiError("too_many_requests", "Too many requests"),
            HttpStatusCode.InternalServerError =>
                new ApiError("internal_error", "Unexpected server error"),
            HttpStatusCode.ServiceUnavailable =>
                new ApiError("service_unavailable", "Service unavailable"),
            HttpStatusCode.GatewayTimeout =>
                new ApiError("gateway_timeout", "Gateway timed out"),
            _ => new ApiError("request_failed", "Unexpected server error")
        };
    }
}
