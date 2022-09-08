using CnotSoSharpTho.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
// using CnotSoSharpTho.DAO;
// using Newtonsoft.Json;

namespace CnotSoSharpTho.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WidgetController : ControllerBase
{
    // GET api/values
    [EnableCors("AnotherPolicy")]
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
        return new string[] { "green widget", "red widget" };
    }

    // GET api/values/5
    [EnableCors("Policy1")]
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
        return id switch
        {
            1 => "green widget",
            2 => "red widget",
            _ => NotFound(),
        };
    }
}

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
