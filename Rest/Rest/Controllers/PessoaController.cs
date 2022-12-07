using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rest.Data;
using Rest.Models;

namespace Rest.Controllers
{
    [Route("api")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        [HttpGet]
        [Route("pessoas")]
        public async Task<IActionResult> GetByIdAsync(
            [FromServices] Contexto context)
        {
            var pessoas = await context
                .Pessoas
                .AsNoTracking()
                .ToListAsync();

            return pessoas == null ? NotFound() : Ok(pessoas);
        }

        [HttpGet]
        [Route("pessoa/{id}")]
        public async Task<IActionResult> GetByIdAsync(
            [FromServices] Contexto context,
            [FromRoute] int id)
        {
            var pessoa = await context
                .Pessoas
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.id == id);

            return pessoa == null ? NotFound() : Ok(pessoa);
        }

        [HttpPost]
        [Route("pessoa")]
        public async Task<IActionResult> PostAsync(
            [FromServices] Contexto context,
            [FromBody] Pessoa pessoa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                await context.Pessoas.AddAsync(pessoa);
                await context.SaveChangesAsync();
                return Created($"api/pessoas/{pessoa.id}", pessoa);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        [Route("pessoa/{id}")]
        public async Task<IActionResult> PutAsync(
            [FromServices] Contexto context,
            [FromBody] Pessoa pessoa,
            [FromRoute] int id
            )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Model inválida");
            }
            var p = await context.Pessoas
                .FirstOrDefaultAsync(x => x.id == id);

            if (pessoa == null)
                return NotFound("Pessoa não encontrada!");
            try
            {
                p.nome = pessoa.nome;

                context.Pessoas.Update(p);
                await context.SaveChangesAsync();
                return Ok(p);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        [Route("pessoaDelete/{id}")]
        public async Task<IActionResult> DeleteAsync(
            [FromServices] Contexto context,
            [FromRoute] int id)
        {
            var pessoa = await context
                .Pessoas
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.id == id);

            if (pessoa == null)
                return BadRequest("Pessoa não encontrada!");

            try
            {
                context.Pessoas.Remove(pessoa);
                await context.SaveChangesAsync();

                return Ok();
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
    }
