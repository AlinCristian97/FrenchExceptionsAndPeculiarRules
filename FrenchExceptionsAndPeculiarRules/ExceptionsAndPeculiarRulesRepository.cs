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

        new ExceptionRule(
            textWhereNoticed: "Je n’ai pas de livres.",
            mainActor: "de",
            explanation: "À la forme négative, les articles indéfinis et partitifs « des », « du » et « de la » deviennent « de ». La négation annule l’idée de quantité ou de partitif.",
            notes: "Affirmatif : « J’ai des livres », « Je bois du café », « Je mange de la salade ». ➝ Négatif : « Je n’ai pas de livres », « Je ne bois pas de café », « Je ne mange pas de salade ». Exception : le verbe « être » ne suit pas cette règle (ex. : « Ce ne sont pas des livres. »)."
        ),


    };
}
