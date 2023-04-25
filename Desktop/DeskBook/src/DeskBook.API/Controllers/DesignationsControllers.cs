using DeskBook.AppServices.Contracts.Designation;
using Microsoft.AspNetCore.Mvc;

namespace DeskBook.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DesignationsControllers : ControllerBase
{
    private readonly IDesignationAppServices _designationAppServices;
    public DesignationsControllers(IDesignationAppServices designationAppServices)
    {
        _designationAppServices = designationAppServices;
    }

    [HttpGet]
    public async Task<IActionResult> GetDesignations()
    {
            var users = await _designationAppServices.GetDesignations();
            return Ok(users);
    }
}
