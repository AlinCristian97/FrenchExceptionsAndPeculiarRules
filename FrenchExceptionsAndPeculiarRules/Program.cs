using System;
using System.Security.Principal;

namespace FrenchExceptionsAndPeculiarRules
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var repository = new ExceptionsAndPeculiarRulesRepository();
            var list = repository.ExceptionsAndPeculiarRules;

            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Aucune règle d’exception disponible dans le dépôt.");
                return;
            }

            var randomIndex = Random.Shared.Next(list.Count);
            var rule = list[randomIndex];

            Console.WriteLine(Constants.LongDivider);
            Console.WriteLine("Règle d’exception aléatoire :");
            Console.WriteLine(Constants.ShortDivider);
            Console.Write($"Texte : ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{Constants.GuillemetOuvrant} {rule.TextWhereNoticed} {Constants.GuillemetFermant}");
            Console.ResetColor();
            Console.WriteLine(Constants.ShortDivider);
            Console.Write($"Élément principal : ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(rule.MainActor);
            Console.ResetColor();
            Console.WriteLine(Constants.ShortDivider);
            Console.Write($"Explication : ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(rule.Explanation);
            Console.ResetColor();
            if (!string.IsNullOrWhiteSpace(rule.Notes))
            {
                Console.WriteLine(Constants.ShortDivider);
                Console.Write($"Notes : ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(rule.Notes);
                Console.ResetColor();
            }
            Console.WriteLine(Constants.LongDivider);
        }
    }
}
