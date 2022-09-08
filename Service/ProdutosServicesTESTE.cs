// using CnotSoSharpTho.DAO;
// using CnotSoSharpTho.Interfaces;
// using CnotSoSharpTho.ViewModels;
// using Newtonsoft.Json;

// namespace CnotSoSharpTho.Service;

// public class ProdutosServicesTESTE : IProdutosServices
// {
//     public List<ModeloTeste> GetProdutosTESTE()
//     {
//         List<ModeloTeste> listaProduto = new List<ModeloTeste>();
//         ModeloTeste produto = new ModeloTeste();
//         ProdutosDAO produtosJSON = new ProdutosDAO();
        
    
//         var produtosJsonOriginal = produtosJSON.GetProdutosHttp();


//         var produtosParaString = JsonConvert.DeserializeObject(produtosJsonOriginal).ToString();
//         var ProdutosConvertidos = JsonConvert.DeserializeObject<ModeloTeste>(produtosParaString);

        
        
//         // ModeloTeste ProdutosConvertidos = JsonConvert.DeserializeObject<ModeloTeste>(produtosJsonOriginal);

//         // System.Console.WriteLine("VANS VER O QUE: " +ProdutosConvertidos);
        
//             produto.userId = ProdutosConvertidos.userId;
//             produto.id = ProdutosConvertidos.id;
//             produto.title = ProdutosConvertidos.title;
//             produto.completed = ProdutosConvertidos.completed;
        
        
//         // produto.image = "IMAGE";
//         // produto.price = "5064.69";
//         // produto.id = 10;
//         // produto.description = "Lorem ipsum dolor sit amet consectetur adipisicing elit";
//         // produto.type = "ilustracoes";
//         // produto.alt = "Desenho de olho com caneta preta em folha branca";
//         // produto.name = "Arte com caneta preta by Anna Muravska";

//         var JSONADO = JsonConvert.SerializeObject(produto);
//         System.Console.WriteLine("JSONADO"+JSONADO);
//         System.Console.WriteLine("produto"+produto);
//         System.Console.WriteLine("listaProduto"+listaProduto);

//         listaProduto.Add(produto);
//         // System.Console.WriteLine("AQUI>>>>: "+listaProduto);
        
//         return listaProduto;
//     }
// }