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

        new ExceptionRule(
            textWhereNoticed: "Personne n’est venu.",
            mainActor: "personne",
            explanation: "Lorsque « personne » est le sujet d’une phrase négative, il exprime déjà la négation et remplace « pas ». Il s’emploie donc avec « ne » mais **sans « pas »**, et il précède le verbe : « Personne n’est venu ». Cette inversion du sujet négatif avec le verbe est typique en français. " +
                         "À la différence de « rien », « pas » ou « jamais » (qui suivent l’auxiliaire), le sujet « personne » se place avant le verbe et entraîne l’usage de « ne » avec le verbe.",
            notes: "Exemples :\n" +
                   "Sujet : « Personne n’est venu » (= nobody came) ✅\n" +
                   "Objet : « Je n’ai vu personne » (= I saw no one) ✅\n" +
                   "Incorrect : « Personne n’est pas venu » ❌\n" +
                   "Règle : Sujet négatif « personne » → personne + ne + verbe (pas de « pas »); Objet négatif « personne » → ne + verbe + personne."
        ),

        new ExceptionRule(
            textWhereNoticed: "Je n’ai rien vu vs Je n’ai vu personne",
            mainActor: "personne",
            explanation: "Dans une phrase négative avec un verbe composé, la place de l’adverbe/négation dépend du mot :\n" +
                         "- Pour « rien », « pas », « que », l’adverbe suit le « ne » et précède le participe passé : « Je n’ai rien vu », « Je n’ai que vu ».\n" +
                         "- Pour « personne » en fonction d’objet direct, il suit le participe passé : « Je n’ai vu personne ».\n" +
                         "Cette distinction est importante car « Je n’ai personne vu » est considéré incorrect en français standard, sauf en style littéraire ou poétique.",
            notes: "Exemples :\n" +
                   "Correct : « Je n’ai rien vu », « Je n’ai pas vu le film », « Je n’ai que vu des extraits »\n" +
                   "Correct : « Je n’ai vu personne »\n" +
                   "Incorrect : « Je n’ai personne vu »\n" +
                   "Règle : Rien, pas, que → avant le participe passé; Personne → après le participe passé (quand c’est l’objet)."
        ),


    };
}
