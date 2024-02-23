using Turbo.az.Models;

namespace Turbo.az.Dtos;

public class VehicleDto
{
    public double? Price { get; set; }
    public string? BrandName { get; set; }
    public string? ModelName { get; set; }
    public int? EngineVolume { get; set; }
    public string? ImageUrl { get; set; }
    public int? HorsePowers { get; set; }
    public int? SeatsCount { get; set; }
    public string? Color { get; set; }
    public TransmissionType? TransmissionType { get; set; }
    public Drivetrain? Drivetrain { get; set; }
}