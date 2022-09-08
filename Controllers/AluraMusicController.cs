using CnotSoSharpTho.Interfaces;
using Microsoft.AspNetCore.Mvc;
// using CnotSoSharpTho.DAO;
// using Newtonsoft.Json;

namespace CnotSoSharpTho.Controllers;

[ApiController]
[Route("[controller]")]
public class AluraMusicController : ControllerBase
{

    private readonly IProdutosServices _serviceProduto;
    public AluraMusicController(IProdutosServices serviceProduto)
    {
        _serviceProduto = serviceProduto;
    }

    [HttpGet]
    [Route("Index")]
    public IActionResult Get()
    {   
        // ProdutosDAO pegaProdutos = new ProdutosDAO();
        // return Ok(pegaProdutos.GetJSON());
        return Ok(_serviceProduto.GetProdutos());
    }
}
