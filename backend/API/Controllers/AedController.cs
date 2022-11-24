using BildMlue.Application.DTO.Aed;
using BildMlue.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BildMlue.API.Controllers;

public class AedController : ApiController
{
    private readonly IAedService _aedService;

    public AedController(IAedService aedService) =>
        _aedService = aedService;

    /// <summary>
    /// Get all AEDs
    /// </summary>
    [HttpGet]
    public Task<List<AedOutDto>> GetAll() =>
        _aedService.GetAll();
}