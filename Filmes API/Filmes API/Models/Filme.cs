using Filmes_API.Models;
using System.ComponentModel.DataAnnotations;

namespace Filme_API.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; internal set; }

        [Required(ErrorMessage = "O titulo do filme é obrigatorio")]
        [StringLength(100)]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O gênero do filme é obrigatorio")]
        [MaxLength(50, ErrorMessage = "O Tamanho maximo não pode exceder 50 caracteres")]

        public string Genero { get; set; }

        [Required]
        [Range(70,600, ErrorMessage = "A duração so pode ser entre 70 e 600")]
        public int Duracao { get; set; }

        public virtual ICollection<Sessao> Sessoes { get; set; }

    }
}
