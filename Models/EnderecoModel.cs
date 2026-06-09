using System.ComponentModel.DataAnnotations;

namespace BuscaEndereco.Models
{
    public class EnderecoModel
    {
        [Required]
        [StringLength(8)]
        public string Cep { get; set; }

        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
    }
}