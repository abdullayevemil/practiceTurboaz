using Microsoft.EntityFrameworkCore;
using Turbo.az.Data;
using Turbo.az.Models;
using Turbo.az.Repositories.Base;

namespace Turbo.az.Repositories;

public class VehicleSqlRepository : IVehicleRepository
{
    private readonly MyDbContext dbContext;

    public VehicleSqlRepository(MyDbContext dbContext) => this.dbContext = dbContext;

    public IEnumerable<Vehicle> GetAllVehicles() => this.dbContext.Vehicles.AsEnumerable();

    public async Task<Vehicle?> GetVehicleByIdAsync(int id)
    {
        var vehicle = await this.dbContext.Vehicles.FirstOrDefaultAsync(vehicle => vehicle.Id == id);

        return vehicle;
    }

    public IEnumerable<Vehicle?> GetUserVehicles(string userLogin)
    {
        var userVehicles = dbContext.Vehicles.Where(vehicle => vehicle.UserLogin == userLogin).AsEnumerable();

        return userVehicles;
    }

    public async Task InsertVehicleAsync(Vehicle vehicle)
    {
        await this.dbContext.Vehicles.AddAsync(vehicle);

        await this.dbContext.SaveChangesAsync();
    }

    public async Task DeleteVehicleAsync(int id)
    {
        var vehicle = await this.dbContext.Vehicles.FirstOrDefaultAsync(vehicle => vehicle.Id == id);
        
        this.dbContext.Remove<Vehicle>(vehicle!);

        await this.dbContext.SaveChangesAsync();
    }

    public async Task UpdateVehicleAsync(int oldVehicleId, Vehicle newVehicle)
    {
        var vehicle = await this.dbContext.Vehicles.FirstOrDefaultAsync(vehicle => vehicle.Id == oldVehicleId);

        vehicle = newVehicle;

        await this.dbContext.SaveChangesAsync();
    }
}