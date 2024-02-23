using Turbo.az.Models;

namespace Turbo.az.Repositories.Base;

public interface IVehicleRepository
{
    IEnumerable<Vehicle> GetAllVehicles();
    Task<Vehicle?> GetVehicleByIdAsync(int id);
    IEnumerable<Vehicle?> GetUserVehicles(string userLogin);
    Task InsertVehicleAsync(Vehicle vehicle);
    Task DeleteVehicleAsync(int id);
    Task UpdateVehicleAsync(int oldVehicleId, Vehicle newVehicle);
}