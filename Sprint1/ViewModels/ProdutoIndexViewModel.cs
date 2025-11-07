using Sprint1.Models;

namespace Sprint1.ViewModels
{
    public class ProdutoIndexViewModel
    {
        public List<Produto> Produtos { get; set; }

        public int PaginaAtual { get; set; }
        public int TotalPaginas { get; set; }

        public string SortOrderAtual { get; set; }
        public string FiltroAtual { get; set; }

        public ProdutoIndexViewModel()
        {
            Produtos = new List<Produto>();
        }
    }
}