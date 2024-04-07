using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Cliente
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Nome { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    // Supondo que o Logotipo seja o caminho para o arquivo no sistema de arquivos ou Blob
    public string Logotipo { get; set; }

    // Um cliente pode ter vários logradouros
    public List<Logradouro> Logradouros { get; set; }
}
