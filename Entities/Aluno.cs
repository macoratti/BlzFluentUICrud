namespace BlzFluentUICrud.Entities;

public class Aluno
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;    
    public string Email { get; set; } = string.Empty;
    public int Idade { get; set; }
    public string? Foto { get; set; } 

}
