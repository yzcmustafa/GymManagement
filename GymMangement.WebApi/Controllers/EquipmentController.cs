using GymManagement.Application.Interfaces.ServiceInterfaces;
using GymManagement.Application.ViewModels.EquipmentViewModel;
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
    public class EquipmentController : ControllerBase
    {
        private readonly IEquipmentService _equipmentService;
        public EquipmentController(IEquipmentService equipmentService)
        {
            _equipmentService = equipmentService;
        }

        [HttpGet]
        public IActionResult GetEquipmentsWithTrainer()
        {
            return Ok(_equipmentService.GetEquipmentsWithTrainer());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _equipmentService.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody]EquipmentCommandViewModel model)
        {
            return Ok(_equipmentService.Create(model));
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromBody] EquipmentCommandViewModel model, int id)
        {
            var result = _equipmentService.Update(model, id);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _equipmentService.Delete(id);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
