using GymManagement.Application.Interfaces.ServiceInterfaces;
using GymManagement.Application.ViewModels.CampaignViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymMangement.WebApi.Controllers
{
    [Route("api/[controller]s")]
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

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _campignService.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody]CampaignCommandViewModel model)
        {
            var result = _campignService.Create(model);
            if(result)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromBody] CampaignCommandViewModel model, int id)
        {
            var result = _campignService.Update(model, id);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _campignService.Delete(id);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
