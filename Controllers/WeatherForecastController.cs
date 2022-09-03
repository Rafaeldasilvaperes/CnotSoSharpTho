using CnotSoSharpTho.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CnotSoSharpTho.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{

    private readonly IProdutosServices _serviceProduto;
    

    public WeatherForecastController(IProdutosServices serviceProduto)
    {
        _serviceProduto = serviceProduto;
    }

    [HttpGet]
    // [Route("Index")]
    public IActionResult Get()
    {
        return Ok(_serviceProduto.GetProdutos());
    }
}
