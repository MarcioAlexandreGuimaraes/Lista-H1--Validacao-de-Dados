using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

public class CodigoProdutoValidoAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value == null) 
            return new ValidationResult("O código do produto não pode ser nulo");

        string codigo = value.ToString().ToUpper();
        string pattern = @"^[A-Z]{3}-\d{4}$"; 
        if (Regex.IsMatch(codigo, pattern))
        {
            return ValidationResult.Success;
        }

        return new ValidationResult(ErrorMessage);
    }
}
