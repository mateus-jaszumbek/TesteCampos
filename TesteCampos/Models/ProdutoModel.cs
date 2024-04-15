using System.ComponentModel.DataAnnotations;

namespace TesteCampos.Models
{
    public class ProdutoModel
    {
        public int idProduto { get; set; }
        [Required(ErrorMessage = "Digite a Descrição do seu Produto, por favor!")]
        public string? dscProduto { get; set; }
        [Required(ErrorMessage = "Digite o Valor do seu Produto, por favor!")]
        public float vlrUnitario { get; set; }
    }
}
