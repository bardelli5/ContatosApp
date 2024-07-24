using System.ComponentModel.DataAnnotations;

namespace ListaDeContatos.Models
    {
    public class Contato
        {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' é obrigatório.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O campo 'Nome' deve ter mais de 2 caracteres.")]
        public string Nome { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O campo 'E-mail' é obrigatório.")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }

        [Display(Name = "Telefone Celular")]
        [Required(ErrorMessage = "O campo 'Celular' é obrigatório.")]
        [RegularExpression("^(1[1-9]|[4689][0-9]|2[12478]|3([1-5]|[7-8])|5([13-5])|7[193-7])9[0-9]{8}$", ErrorMessage = "Número de celular em formato inválido. Utilize apenas números")]
        public string NumeroCelular { get; set; }

        public bool Favoritos { get; set; }

        [Display(Name = "Criado em")]
        public DateTime CriadoEm { get; set; } = DateTime.Now;

        }
    }
