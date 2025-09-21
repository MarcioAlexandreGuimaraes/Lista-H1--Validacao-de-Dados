using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("api/[controller]")]
public class ProdutoController : ControllerBase
{
    private static List<Produto> produtos = new List<Produto>();

    [HttpPost]
    public IActionResult CriarProduto([FromBody] Produto produto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState); 
        }

        produtos.Add(produto);
        return Ok(produto);
    }

    [HttpGet]
    public IActionResult ListarProdutos()
    {
        return Ok(produtos);
    }

    [HttpGet("{codigo}")]
    public IActionResult ObterProduto(string codigo)
    {
        var produto = produtos.Find(p => p.CodigoProduto.ToUpper() == codigo.ToUpper());
        if (produto == null) return NotFound("Produto não encontrado");
        return Ok(produto);
    }
}

