using System.ComponentModel.DataAnnotations;

namespace TesteCampos.Models
{
    public class VendaModel
    {
        public int idVenda { get; set; }
        public int idCliente { get; set; }
        public int idProduto { get; set; }

        [Required(ErrorMessage = "Digite a quantidade de venda, por favor!")]
        public int qtdVenda { get; set; }
        [Required(ErrorMessage = "Digite o valor unitário de venda, por favor!")]
        public float vlrUnitarioVenda { get; set; }
        public DateTime dthVenda { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "Digite o valor total de vendas, por favor!")]
        public float vlrTotalVenda { get; set; }
    }
}
