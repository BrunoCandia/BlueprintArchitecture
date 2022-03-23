namespace Blueprint.Application.Models.Result
{
    public class ValidationError
    {
        public string Identifier { get; set; } = String.Empty;
        public string ErrorMessage { get; set; } = String.Empty;
        public ValidationSeverity Severity { get; set; } = ValidationSeverity.Error;
    }
}
