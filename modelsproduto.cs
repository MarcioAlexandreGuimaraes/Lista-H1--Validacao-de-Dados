using System.ComponentModel.DataAnnotations;

public class Produto
{
    [Required(ErrorMessage = "A Descrição é obrigatória")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "O Preço é obrigatório")]
    [Range(0.01, double.MaxValue, ErrorMessage = "O Preço deve ser maior que zero")]
    public decimal Preco { get; set; }

    [Required(ErrorMessage = "O Estoque é obrigatório")]
    [Range(0, int.MaxValue, ErrorMessage = "O Estoque não pode ser negativo")]
    public int Estoque { get; set; }

    [Required(ErrorMessage = "O Código do Produto é obrigatório")]
    [CodigoProdutoValido(ErrorMessage = "O código do produto deve seguir o formato AAA-1234")]
    public string CodigoProduto { get; set; }
}

