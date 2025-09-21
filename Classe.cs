using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

public class RaValidoAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value == null) 
            return new ValidationResult("RA não pode ser nulo");

        string ra = value.ToString().ToUpper();
        string pattern = @"^RA\d{6}$";

        if (Regex.IsMatch(ra, pattern))
        {
            return ValidationResult.Success;
        }

        return new ValidationResult(ErrorMessage);
    }
}
