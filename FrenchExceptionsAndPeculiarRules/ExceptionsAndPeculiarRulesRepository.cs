namespace FrenchExceptionsAndPeculiarRules;

public class ExceptionsAndPeculiarRulesRepository
{
    public readonly List<ExceptionRule> ExceptionsAndPeculiarRules = new()
    {
        new ExceptionRule(
            textWhereNoticed: "Il est vingt-deux heures et quart / Il est onze heures moins le quart",
            mainActor: "et quart / moins le quart",
            explanation: "En français, les expressions pour indiquer « quarter past » et « quarter to » suivent une règle asymétrique :\n" +
                         "- « et quart » (quarter past) s’utilise **sans article** : « Il est trois heures et quart ».\n" +
                         "- « moins le quart » (quarter to) **nécessite l’article défini « le »** : « Il est quatre heures moins le quart ».\n" +
                         "Cette différence est idiomatique et fait partie des expressions figées pour dire l’heure.",
            notes: "Exemples :\n" +
                   "• 3:15 → « Il est trois heures et quart » (pas : et le quart)\n" +
                   "• 10:45 → « Il est onze heures moins le quart »\n" +
                   "• 5:45 → « Il est six heures moins le quart »\n" +
                   "Incorrect : « Il est vingt-deux heures et le quart »\n" +
                   "Incorrect : « Il est onze heures moins quart »\n" +
                   "Règle rapide :\n" +
                   "Quarter past → « et quart » (sans « le »)\n" +
                   "Quarter to → « moins le quart » (avec « le »)"
        ),

        new ExceptionRule(
            textWhereNoticed: "Les fleurs sont rouges / des yeux marron / des drapeaux bleu blanc rouge",
            mainActor: "color adjectives agreement",
            explanation: "En français, la plupart des adjectifs de couleur s’accordent normalement en genre et en nombre avec le nom qu’ils décrivent. " +
                         "Cependant, certaines couleurs ne s’accordent pas lorsqu’elles proviennent à l’origine d’un nom (fruit, objet, matière) ou lorsqu’on combine plusieurs couleurs.",
            notes: "1. Couleurs normales → accord avec le nom\n" +
                   "• une fleur rouge → singulier\n" +
                   "• des fleurs rouges → pluriel\n" +
                   "• une voiture bleue → féminin\n\n" +
                   "2. Couleurs provenant d’un nom → pas d’accord\n" +
                   "• des yeux marron\n" +
                   "• des robes orange\n" +
                   "• des chaussures chocolat\n\n" +
                   "3. Plusieurs couleurs ensemble → pas d’accord\n" +
                   "• des drapeaux bleu blanc rouge\n" +
                   "• des chemises vert et bleu\n\n" +
                   "Règle rapide : couleurs normales → accord ; couleurs venant d’un nom ou combinaison de couleurs → pas d’accord."
        ),

        new ExceptionRule(
            textWhereNoticed: "un bel homme / un vieil arbre / un nouvel appartement",
            mainActor: "beau / bel, vieux / vieil, nouveau / nouvel",
            explanation: "Certains adjectifs masculins singuliers changent de forme devant un nom commençant par une voyelle ou un h muet. " +
                         "Cette transformation existe pour **éviter deux voyelles consécutives et rendre la prononciation plus fluide**. " +
                         "Ainsi, les adjectifs « beau », « vieux » et « nouveau » prennent une forme spéciale : « bel », « vieil » et « nouvel ». " +
                         "Cette règle relève de l’euphonie (harmonie des sons) en français.",
            notes: "Formes :\n" +
                   "• beau → bel (devant voyelle/h muet)\n" +
                   "• vieux → vieil\n" +
                   "• nouveau → nouvel\n\n" +
                   "Exemples :\n" +
                   "• un beau livre → consonne\n" +
                   "• un bel homme → voyelle\n" +
                   "• un vieux château → consonne\n" +
                   "• un vieil arbre → voyelle\n" +
                   "• un nouveau film → consonne\n" +
                   "• un nouvel appartement → voyelle\n\n" +
                   "Règle rapide : masculin singulier + voyelle/h muet → bel, vieil, nouvel."
        ),

        new ExceptionRule(
            textWhereNoticed: "une belle maison / un petit chat / un jeune homme / un bon repas",
            mainActor: "BAGS adjectives",
            explanation: "En français, la plupart des adjectifs se placent **après le nom**, mais un petit groupe d’adjectifs très courants se place **avant le nom**. " +
                         "On les regroupe souvent sous l’acronyme **BAGS**, qui signifie : Beauty, Age, Goodness, Size. " +
                         "Ces adjectifs sont courts, fréquents et décrivent des qualités générales plutôt que des caractéristiques détaillées.",
            notes: "BAGS = adjectifs placés avant le nom :\n" +
                   "• Beauty (beauté) : beau, joli\n" +
                   "• Age (âge) : jeune, vieux, nouveau, ancien\n" +
                   "• Goodness (qualité) : bon, mauvais, meilleur\n" +
                   "• Size (taille) : petit, grand, gros\n\n" +
                   "Exemples :\n" +
                   "• une belle maison → beauty\n" +
                   "• un jeune homme → age\n" +
                   "• un bon repas → goodness\n" +
                   "• un petit chat → size\n\n" +
                   "Comparaison :\n" +
                   "• un petit chat noir → BAGS avant, descriptif après\n" +
                   "• une voiture rouge → adjectif descriptif normal, après le nom\n\n" +
                   "Règle rapide : la majorité des adjectifs vont après le nom, mais les adjectifs BAGS vont généralement avant."
        ),

        new ExceptionRule(
            textWhereNoticed: "Regarde-moi le culot de ce gamin ! / Regarde-moi ce bordel !",
            mainActor: "Regarde-moi + [expression]",
            explanation: "L’expression « regarde-moi » suivie d’un nom ou d’une phrase sert à **attirer l’attention sur quelque chose de surprenant, audacieux ou scandaleux**. " +
                         "Grammaticalement, « regarde-moi » signifie littéralement « regarde-moi », mais ici c’est **idiomatique** et ne renvoie pas à 'moi' personnellement. " +
                         "Cette construction est très fréquente à l’oral pour exprimer l’indignation, la surprise ou l’emphase.",
            notes: "Exemples :\n" +
                   "• Regarde-moi le culot de ce gamin ! → Can you believe the nerve of this kid!\n" +
                   "• Regarde-moi ce bordel ! → Look at this mess!\n" +
                   "• Regarde-moi ce scandale ! → Check out this scandal!\n" +
                   "Règle rapide : « Regarde-moi + [nom / expression] » = exprime surprise, indignation ou emphase, très courant à l’oral, idiomatique."
        ),

        new ExceptionRule(
            textWhereNoticed: "Nul ne doit souiller ce mur / Personne ne peut entrer",
            mainActor: "nul / personne / rien + ne without pas",
            explanation: "Lorsque le sujet est un mot négatif comme « nul », « personne » ou « rien », le « ne » placé après le sujet suffit pour marquer la négation. " +
                         "On n’ajoute pas « pas » dans ce type de construction. Cette règle s’emploie surtout en français formel ou littéraire.",
            notes: "Exemples :\n" +
                   "• Nul ne doit souiller ce mur → No one must soil this wall\n" +
                   "• Personne ne peut entrer → No one can enter\n" +
                   "• Rien ne bouge → Nothing moves\n" +
                   "Incorrect : Nul ne doit pas souiller ce mur\n" +
                   "Règle rapide : Sujet négatif (nul, personne, rien) → ne + verbe, pas de « pas »."
        ),

        new ExceptionRule(
            textWhereNoticed: "Il est censé arriver à midi / Je suis censé finir ce travail",
            mainActor: "censer",
            explanation: "Le verbe « censer » est un verbe régulier du 1er groupe (-ER), donc il se conjugue normalement. " +
                         "Cependant, il est rarement utilisé et apparaît presque toujours dans l’expression **« être censé + infinitif »**, " +
                         "qui signifie « être supposé faire quelque chose » : « Il est censé arriver à midi » → « He is supposed to arrive at noon ».",
            notes: "Exemples :\n" +
                   "• Je suis censé finir ce travail aujourd’hui → I’m supposed to finish this work today\n" +
                   "• Il est censé comprendre les instructions → He is supposed to understand the instructions\n" +
                   "• Présent : je cense, tu censes, il cense, nous censons, vous censez, ils censent\n" +
                   "• Participe passé : censé (utilisé avec « être » dans l’expression)\n" +
                   "Règle rapide : verbe régulier -ER → conjuguer normalement ; expression fréquente → « être censé + infinitif »."
        ),

        new ExceptionRule(
                textWhereNoticed: "un nouvel épisode / un nouveau film / un épisode intéressant",
                mainActor: "nouveau / nouvel",
                explanation: "L’adjectif « nouveau » appartient au groupe BAGS (Beauty, Age, Goodness, Size) et **se place avant le nom**. " +
                             "Il change de forme en « nouvel » devant un nom masculin singulier commençant par une voyelle ou un h muet pour faciliter la prononciation.",
                notes: "Exemples :\n" +
                       "• un nouvel épisode → masculin singulier, nom commence par voyelle\n" +
                       "• un nouveau film → masculin singulier, nom commence par consonne\n" +
                       "• un épisode intéressant → adjectif descriptif normal, va après le nom\n" +
                       "Règle rapide :\n" +
                       "1. BAGS → avant le nom, nouveau → nouvel devant voyelle/h muet\n" +
                       "2. Descriptifs → après le nom"
            ),

        new ExceptionRule(
            textWhereNoticed: "Il est un peu fatigué / Le français devient un peu plus souple",
            mainActor: "un peu",
            explanation: "L’expression « un peu » combine l’article indéfini « un » et le nom « peu » pour former une **locution adverbiale**. " +
                         "Elle modifie un adjectif ou un adverbe, indiquant la quantité ou le degré : « un peu fatigué » → légèrement fatigué.",
            notes: "Exemples :\n" +
                   "• Il est un peu fatigué → adverbe modifiant l’adjectif fatigué\n" +
                   "• Le français devient un peu plus souple → adverbe modifiant l’adverbe plus\n" +
                   "• Un peu de sucre → ici peu = nom, un = article → signifie une petite quantité (différent de adverbial)\n" +
                   "Règle rapide : quand un peu précède un adjectif/adverbe → adverbe ; quand il précède de + nom → nom + article"
        ),


        new ExceptionRule(
            textWhereNoticed: "Ce livre est intéressant / Cet homme est gentil / Cette voiture est rouge",
            mainActor: "ce / cet / cette",
            explanation: "En français, les adjectifs démonstratifs changent selon le genre, le nombre et la première lettre du nom :\n" +
                         "- « Ce » → masculin singulier, devant une consonne : Ce livre est intéressant.\n" +
                         "- « Cet » → masculin singulier, devant une voyelle ou un h muet : Cet homme est gentil.\n" +
                         "- « Cette » → féminin singulier : Cette voiture est rouge.\n" +
                         "Ils signifient tous « this » ou « that » en anglais et s’accordent avec le nom qu’ils déterminent.",
            notes: "Exemples :\n" +
                   "• Ce chien est mignon → masculin singulier, consonne\n" +
                   "• Cet ordinateur est rapide → masculin singulier, voyelle\n" +
                   "• Cette idée est intéressante → féminin singulier\n" +
                   "Règle rapide :\n" +
                   "1. Masculin singulier + consonne → ce\n" +
                   "2. Masculin singulier + voyelle/h muet → cet\n" +
                   "3. Féminin singulier → cette"
        ),

        new ExceptionRule(
            textWhereNoticed: "Je voudrais un verre de vin",
            mainActor: "« de » after quantity",
            explanation: "En français, lorsqu’un nom est précédé d’une expression de quantité ou d’une mesure (un verre, une bouteille, un kilo, beaucoup, peu, trop), on utilise uniquement « de » devant le nom et **pas le partitif du / de la / des**. La quantité spécifie déjà combien, donc le partitif n’est pas nécessaire.",
            notes: "Exemples :\n" +
                   "• Je veux du vin → je veux du vin (partitif, quantité non spécifiée)\n" +
                   "• Je voudrais un verre de vin → un verre = quantité, on utilise de seul\n" +
                   "• Une bouteille de jus → quantité, on utilise de\n" +
                   "• Un kilo de pommes → quantité, on utilise de\n" +
                   "• Beaucoup de travail → expression de quantité, on utilise de\n" +
                   "Règle rapide : après une mesure ou expression de quantité → utiliser « de » seul, pas le partitif."
        ),

        new ExceptionRule(
            textWhereNoticed: "Ce sont mes frères",
            mainActor: "ce",
            explanation: "Dans la structure « Ce + être + nom », « ce » est un pronom neutre qui ne s’accorde pas avec le nom qui suit. Il reste toujours « ce » (singulier) ou « ce sont » pour le pluriel du verbe, même si le nom est pluriel ou féminin.",
            notes: "Exemples :\n" +
                   "• Ce livre est intéressant. → singulier, masculin\n" +
                   "• Cette maison est grande. → singulier, féminin\n" +
                   "• Ce sont mes frères. → pluriel, nom masculin\n" +
                   "• Ce sont mes sœurs. → pluriel, nom féminin\n" +
                   "Incorrect : Ces sont mes frères \n" +
                   "Règle rapide : Avec « être » comme verbe, utiliser « ce » (neutre) et non « ces » ; le pronom ne s’accorde jamais avec le nom."
        ),

        new ExceptionRule(
            textWhereNoticed: "Combien de livres as-tu lus cette année ?",
            mainActor: "de",
            explanation: "Après une expression de quantité comme « combien », « beaucoup », « peu », « trop » ou « assez », le français utilise « de » et non l’article pluriel « des ». L’expression de quantité indique déjà une quantité indéfinie.",
            notes: "Correct : « Combien de livres… »  Incorrect : « Combien des livres… ». L’article « des » s’utilise uniquement en l’absence d’une expression de quantité, par exemple : « Je lis des livres. »"
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
                   "Sujet : « Personne n’est venu » (= nobody came) \n" +
                   "Objet : « Je n’ai vu personne » (= I saw no one) \n" +
                   "Incorrect : « Personne n’est pas venu » \n" +
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

        new ExceptionRule(
            textWhereNoticed: "À quoi penses-tu ? vs Que fais-tu ?",
            mainActor: "quoi / que",
            explanation: "En français, le choix entre « que » et « quoi » dépend de la présence d’une préposition :\n" +
                         "- « que » s’emploie comme **complément d’objet direct** du verbe, sans préposition : « Que fais-tu ? »\n" +
                         "- « quoi » s’emploie comme **complément d’objet d’une préposition** (à, de, avec, etc.) : « À quoi penses-tu ? », « De quoi parles-tu ? »\n" +
                         "Il est donc grammaticalement impossible de mettre « que » après une préposition :  « À que penses-tu ? »",
            notes: "Exemples :\n" +
                   "Correct : « Que fais-tu ? » (que = objet direct de faire) \n" +
                   "Correct : « À quoi penses-tu ? » (quoi = objet de la préposition à) \n" +
                   "Correct : « De quoi parles-tu ? » (quoi = objet de la préposition de) \n" +
                   "Incorrect : « À que penses-tu ? » \n" +
                   "Règle rapide : après une préposition → utiliser « quoi » ; comme objet direct → utiliser « que »."
        ),
        
        new ExceptionRule(
            textWhereNoticed: "Que manges-tu ? / Que fais-tu ? vs De quoi parles-tu ?",
            mainActor: "que / quoi",
            explanation: "Le choix entre « que » et « quoi » dépend de la présence d’un objet direct ou d’une préposition :\n" +
                         "- Si le verbe agit directement sur un objet, on utilise « que » : « Que manges-tu ? », « Que fais-tu ? »\n" +
                         "- Si le verbe nécessite une préposition pour compléter son sens, on utilise « quoi » après la préposition : « De quoi parles-tu ? », « À quoi penses-tu ? »",
            notes: "Exemples :\n" +
                   "Verbe avec objet direct :\n" +
                   "• « Que manges-tu ? » (manger → objet direct)\n" +
                   "• « Que fais-tu ? » (faire → objet direct)\n" +
                   "Verbe avec préposition :\n" +
                   "• « De quoi parles-tu ? » (parler → besoin de préposition « de »)\n" +
                   "• « À quoi penses-tu ? » (penser → besoin de préposition « à »)\n" +
                   "Règle rapide : objet direct → « que » ; après préposition → « quoi »."
        ),

        new ExceptionRule(
            textWhereNoticed: "Que fais-tu ? vs Tu fais quoi ?",
            mainActor: "que / quoi",
            explanation: "En français, le choix entre « que » et « quoi » dépend du style et de la position dans la question :\n" +
                         "- Dans les questions formelles / écrites, on utilise l’inversion et « que » avant le verbe : « Que fais-tu ? », « Que manges-tu ? »\n" +
                         "- Dans les questions informelles / parlées, le mot « quoi » se place après le verbe : « Tu fais quoi ? », « Tu manges quoi ? »\n" +
                         "Il est incorrect d’utiliser « que » à la fin d’une question : « Tu fais que ? »",
            notes: "Exemples :\n" +
                   "Formel (inversion) :\n" +
                   "• « Que manges-tu ? »\n" +
                   "• « Que fais-tu ce soir ? »\n" +
                   "• « Que veux-tu ? »\n" +
                   "Informel (oral) :\n" +
                   "• « Tu manges quoi ? »\n" +
                   "• « Tu fais quoi ce soir ? »\n" +
                   "• « Tu veux quoi ? »\n" +
                   "Règle rapide : Forme formelle / inversion → « que » avant le verbe ; Forme informelle / parlée → « quoi » après le verbe."
        ),

        new ExceptionRule(
            textWhereNoticed: "Il y a des fleurs",
            mainActor: "a",
            explanation: "Dans l’expression « il y a », le verbe « avoir » reste toujours à la troisième personne du singulier (« a »), même si le nom qui suit est au pluriel. Le sujet grammatical est le « il » impersonnel, et non le nom pluriel.",
            notes: "Exemples :\n" +
                   "• Il y a un chat. → singulier\n" +
                   "• Il y a des fleurs. → pluriel\n" +
                   "• Il y a beaucoup de livres. → pluriel\n" +
                   "Incorrect : Il y ont des fleurs\n" +
                   "Règle rapide : l’expression « il y a » est fixe ; le verbe ne change jamais, quelle que soit la quantité ou le nombre du nom."
        ),

    };
}
