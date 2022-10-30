using CnotSoSharpTho.DAO;
using CnotSoSharpTho.DAO.Interfaces;
using CnotSoSharpTho.Interfaces;
using CnotSoSharpTho.ViewModels;
using Newtonsoft.Json;


namespace CnotSoSharpTho.Service;

public class ProdutosServices : IProdutosServices
{

    private IProdutoDao _daoProduto;
    public ProdutosServices()
    {
        _daoProduto = new ProdutosDAO();
    }
    public List<ProdutoViewModel> GetProdutos()
    {

        return _daoProduto.GetProdutosHttp() ?? new List<ProdutoViewModel>();
    }
}