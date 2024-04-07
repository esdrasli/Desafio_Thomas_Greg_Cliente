using System.ComponentModel.DataAnnotations;

public class Logradouro
{
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string Endereco { get; set; }

    // Chave estrangeira para Cliente
    public int ClienteId { get; set; }

    // Referência de navegação para Cliente
    public Cliente Cliente { get; set; }
}
