using CnotSoSharpTho.ViewModels;

namespace CnotSoSharpTho.DAO.Interfaces;

public interface IProdutoDao
{
 public List<ProdutoViewModel> GetProdutosHttp();
}