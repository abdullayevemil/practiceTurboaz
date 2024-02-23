﻿using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Turbo.az.Models;
using Turbo.az.Repositories.Base;

namespace Turbo.az.Controllers;

public class HomeController : Controller
{
    private readonly IVehicleRepository vehicleRepository;

    public HomeController(IVehicleRepository vehicleRepository) 
    {
        this.vehicleRepository = vehicleRepository;
    }

    [HttpGet]
    [Authorize]
    public IActionResult Index() => base.View();

    [HttpGet]
    [AllowAnonymous]
    public async Task<IActionResult> Main()
    {
        var vehiclesInformation = await vehicleRepository.GetVehiclesMainInformation();

        return base.View(model: vehiclesInformation);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() => base.View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
}
