using System.ComponentModel.DataAnnotations;

public class Aluno
{
    [Required(ErrorMessage = "O Nome é obrigatório")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O RA é obrigatório")]
    [RaValido(ErrorMessage = "O RA deve começar com 'RA' seguido de 6 números")]
    public string Ra { get; set; }

    [Required(ErrorMessage = "O Email é obrigatório")]
    [EmailAddress(ErrorMessage = "Email inválido")]
    public string Email { get; set; }

    [Required(ErrorMessage = "O CPF é obrigatório")]
    [RegularExpression(@"\d{11}", ErrorMessage = "O CPF deve conter 11 números")]
    public string Cpf { get; set; }

    [Required(ErrorMessage = "O campo Ativo é obrigatório")]
    public bool Ativo { get; set; }
}
