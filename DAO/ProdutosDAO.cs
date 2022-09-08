using Newtonsoft.Json;

namespace CnotSoSharpTho.DAO;

public class ProdutosDAO
{
  public string GetProdutosHttp()
  {
    var requestFakeBD = new HttpClient();
    var AluraMusicProduto45 = "https://fake-server-app-alura-music.herokuapp.com/products";
    var endPoint = new Uri(AluraMusicProduto45);
    // var endPoint = new Uri("https://jsonplaceholder.typicode.com/todos/1");
    
    var result = requestFakeBD.GetAsync(endPoint).Result;
    var resultJSON = result.Content.ReadAsStringAsync().Result;
    var JSONADO = JsonConvert.SerializeObject(resultJSON);
    

    return JSONADO;
        
  }
}