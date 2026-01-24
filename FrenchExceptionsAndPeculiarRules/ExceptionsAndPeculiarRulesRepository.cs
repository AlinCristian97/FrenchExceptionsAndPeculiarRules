namespace FrenchExceptionsAndPeculiarRules;

public class ExceptionsAndPeculiarRulesRepository
{
    public readonly List<ExceptionRule> ExceptionsAndPeculiarRules = new()
    {
        new ExceptionRule(
            textWhereNoticed: "Combien de livres as-tu lus cette année ?",
            mainActor: "de",
            explanation: "Après une expression de quantité comme « combien », « beaucoup », « peu », « trop » ou « assez », le français utilise « de » et non l’article pluriel « des ». L’expression de quantité indique déjà une quantité indéfinie.",
            notes: "Correct : « Combien de livres… » ❌ Incorrect : « Combien des livres… ». L’article « des » s’utilise uniquement en l’absence d’une expression de quantité, par exemple : « Je lis des livres. »"
        ),
    };
}
