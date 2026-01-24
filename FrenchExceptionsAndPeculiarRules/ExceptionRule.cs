namespace FrenchExceptionsAndPeculiarRules;

public class ExceptionRule
{
    public string TextWhereNoticed { get; set; } = string.Empty;
    public string MainActor { get; set; } = string.Empty; 
    public string Explanation { get; set; } = string.Empty;
    public string? Notes { get; set; } = string.Empty;

    public ExceptionRule(string textWhereNoticed, string mainActor, string explanation, string? notes = null)
    {
        TextWhereNoticed = textWhereNoticed;
        MainActor = mainActor;
        Explanation = explanation;
        Notes = notes;
    }
}
