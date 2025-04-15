using CurriculoDigital.Domain.Entities.Base;
using CurriculoDigital.Domain.Services.Base;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CurriculoDigital.Api.Controllers.Base
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControllerGeneric<T> : ControllerBase where T : EntidadeBase
    {
        private readonly ServiceGeneric<T> _serviceGeneric;

        public ControllerGeneric(ServiceGeneric<T> serviceGeneric)
        {
            _serviceGeneric = serviceGeneric;
        }

        [HttpGet]
        public virtual async Task<IActionResult> Get()
        {
            var result = await _serviceGeneric.GetAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> GetById(long id)
        {
            var result = await _serviceGeneric.GetByIdAsync(id);
            return result != null ? Ok(result) : NotFound();
        }

        [HttpPost]
        public virtual async Task<IActionResult> Post([FromBody] T entity)
        {
            var result = await _serviceGeneric.PostAsync(entity);
            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }

        [HttpPut]
        public virtual async Task<IActionResult> Put([FromBody] T entity)
        {
            var result = await _serviceGeneric.PutAsync(entity);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(long id)
        {
            var result = await _serviceGeneric.DeleteAsync(id);
            return result != null ? Ok(result) : NotFound();
        }

        private object GetEntityId(T entity)
        {
            var prop = entity?.GetType().GetProperty("Id");
            return prop?.GetValue(entity);
        }
    }
}