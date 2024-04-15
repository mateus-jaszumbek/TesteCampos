using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace TesteCampos.Models
{
    public class ClienteModel
    {
        public int idCliente { get; set; }

        [Required(ErrorMessage = "Digite o seu nome por favor!")]
        public string? nmCliente { get; set; }
        [Required(ErrorMessage = "Digite Uma cidade por favor!")]
        public string? Cidade { get; set; }
    }
}
