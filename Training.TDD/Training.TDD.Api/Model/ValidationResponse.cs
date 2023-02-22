namespace Training.TDD.Api.Model;

public class ValidationResponse
{
    public bool IsValid { get; set; }
    public IEnumerable<string> Errors { get; set; }
}