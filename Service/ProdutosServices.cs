using CnotSoSharpTho.DAO;
using CnotSoSharpTho.Interfaces;
using CnotSoSharpTho.ViewModels;
using Newtonsoft.Json;


namespace CnotSoSharpTho.Service;

public class ProdutosServices : IProdutosServices
{
    public List<ProdutoViewModel> GetProdutos()
    {
        List<ProdutoViewModel> listaProduto = new List<ProdutoViewModel>();
        ProdutoViewModel produto = new ProdutoViewModel();
        ProdutosDAO produtosJSON = new ProdutosDAO();
        
        var produtosJsonOriginal = produtosJSON.GetProdutosHttp();
        var produtosParaString = JsonConvert.DeserializeObject(produtosJsonOriginal).ToString();
        
        var ProdutosConvertidos = JsonConvert.DeserializeObject<List<ProdutoViewModel>>(produtosParaString);

       
        foreach( ProdutoViewModel modelo in ProdutosConvertidos)
        {
            
            
                produto.image = modelo.image;
                produto.price = modelo.price;
                produto.id = modelo.id;
                produto.description = modelo.description;
                produto.type = modelo.type;
                produto.alt = modelo.alt;
                produto.name = modelo.name;

                listaProduto.Add(produto);
            
        }

        return listaProduto;
    }
}