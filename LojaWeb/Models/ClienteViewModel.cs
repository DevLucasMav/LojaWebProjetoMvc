using System.ComponentModel.DataAnnotations;

namespace LojaWeb.Models
{
    public class ClienteViewModel
    {

        [Required]
        [Display(Name ="Nome e sobrenome")]
        public string Nome { get; set; }

        public string Telefone { get; set; }
        [Required]
        [Display(Name = "Endereço do cliente ")]
        public string Endereço { get; set; }
        public string NumeroCartaoCredito { get; internal set; }
        public string CPF { get; internal set; }
        public int Id { get; internal set; }
    }
}
