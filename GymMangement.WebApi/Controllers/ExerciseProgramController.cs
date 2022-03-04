using GymManagement.Application.Interfaces.ServiceInterfaces;
using GymManagement.Application.ViewModels.ExerciseProgramViewModel;
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
    public class ExerciseProgramController : ControllerBase
    {
        private readonly IExerciseProgramService _exerciseProgramService;

        public ExerciseProgramController(IExerciseProgramService exerciseProgramService)
        {
            _exerciseProgramService = exerciseProgramService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _exerciseProgramService.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _exerciseProgramService.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] ExerciseCommandViewModel model)
        {
            var result = _exerciseProgramService.Create(model);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromBody] ExerciseCommandViewModel model, int id)
        {
            var result = _exerciseProgramService.Update(model, id);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _exerciseProgramService.Delete(id);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
