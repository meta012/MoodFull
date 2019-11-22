using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoreWebApi.Models;
using CoreWebApi.Models.Repository;

namespace CoreWebApi.Controllers
{
    [Route("api/Evaluations")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IDataRepository<Evaluation> _dataRepository;

        public EmployeeController(IDataRepository<Evaluation> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/Evaluations
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Evaluation> evaluations = _dataRepository.GetAll();
            return Ok(evaluations);
        }

        // GET: api/Evaluations/5
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            Evaluation evaluation = _dataRepository.Get(id);

            if (evaluation == null)
            {
                return NotFound("The Evaluation record couldn't be found.");
            }

            return Ok(evaluation);
        }

        // POST: api/Evaluations
        [HttpPost]
        public IActionResult Post([FromBody] Evaluation evaluation)
        {
            if (evaluation == null)
            {
                return BadRequest("Evaluation is null.");
            }

            _dataRepository.Add(evaluation);
            return CreatedAtRoute(
                  "Get",
                  new { Id = evaluation.EvaluationId },
                  evaluation);
        }

        // PUT: api/Evaluations/5
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Evaluation evaluation)
        {
            if (evaluation == null)
            {
                return BadRequest("Evaluation is null.");
            }

            Evaluation evaluationToUpdate = _dataRepository.Get(id);
            if (evaluationToUpdate == null)
            {
                return NotFound("The Evaluation record couldn't be found.");
            }

            _dataRepository.Update(evaluationToUpdate, evaluation);
            return NoContent();
        }

        // DELETE: api/Evaluations/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Evaluation evaluation = _dataRepository.Get(id);
            if (evaluation == null)
            {
                return NotFound("The Evaluation record couldn't be found.");
            }

            _dataRepository.Delete(evaluation);
            return NoContent();
        }
    }
}
