using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace lab1.Controllers
{
    [Route("api/produtos")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private ProdutoRepositorio repository = new ProdutoRepositorio();

        // GET /api/produtos/
        [HttpGet]
        public ActionResult<List<Produto>> Get()
        {
            var produtos = repository.GetAll();
            if (!produtos.Any())
            {
                return BadRequest("Produtos não encontrados!");
            }
            return Ok();
        }

        // GET /api/produtos/{id}
        [HttpGet("{id}")]
        public ActionResult<Produto> Get(Guid id)
        {
            try
            {
                return Ok(repository.Get(id));

            }
            catch (NonExistsObjectException e)
            {
                return BadRequest(e.Message);
            }
        }

        // POST /api/produtos
        [HttpPost]
        public ActionResult Post([FromBody] Produto produto)
        {
            repository.Add(produto);
            return Ok("Novo Produto Inserido com Sucesso");
        }

        // PUT /api/produtos/{id}
        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] Produto produto)
        {
            try
            {

                repository.Update(id, produto);
            }
            catch (NonExistsObjectException e)
            {
                return BadRequest(e.Message);

            }
            return Ok("Produto atualizado com sucesso!");
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            try
            {
                repository.Remove(id);
            }
            catch (NonExistsObjectException e)
            {
                return BadRequest(e.Message);
            }
            return NoContent();
        }
    }
}
