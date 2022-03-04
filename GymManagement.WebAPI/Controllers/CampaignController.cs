using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GymManagement.Application.Interfaces.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymManagement.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignController : ControllerBase
    {
        private readonly ICampignService _campignService;

        public CampaignController(ICampignService campignService)
        {
            _campignService = campignService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _campignService.GetAll();
            return Ok(result);
        }
    }
}
