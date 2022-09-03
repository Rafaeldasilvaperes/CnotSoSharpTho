using CnotSoSharpTho.Interfaces;
using CnotSoSharpTho.ViewModels;

namespace CnotSoSharpTho.Service;

public class ProdutosServices : IProdutosServices
{
    public List<ProdutoViewModel> GetProdutos()
    {
     List<ProdutoViewModel> listaProduto = new List<ProdutoViewModel>();
     ProdutoViewModel produto = new ProdutoViewModel();
     produto.image = "IMAGEM";
     produto.price = "5064.69";
     produto.id = 10;
     produto.description = "Lorem ipsum dolor sit amet consectetur adipisicing elit";
     produto.type = "ilustracoes";
     produto.alt = "Desenho de olho com caneta preta em folha branca";
     produto.name = "Arte com caneta preta by Anna Muravska";

    listaProduto.Add(produto);
    return listaProduto;
    }
}