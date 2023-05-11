using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos;

public class CreateFilmeDto
{
    [Required(ErrorMessage = "O Título do filme é obrigatório")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O tamanho do gênero do filme é obrigatório")]
    [StringLength(50, ErrorMessage = "O tamanho do gênero nao pode exceder 50 caracters")]
    public string Genero { get; set; }
    [Required]
    [Range(70, 600, ErrorMessage = "A duracao deve ter entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}
