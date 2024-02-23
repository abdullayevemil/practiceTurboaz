namespace Turbo.az.Models;

public class Log
{
    public int LogId { get; set; }
    public int? UserId { get; set; }
    public string? Url { get; set; }
    public string? MethodType { get; set; }
    public int? StatusCode { get; set; }
    public string? RequestBody { get; set; }
    public string? ResponseBody { get; set; }
}