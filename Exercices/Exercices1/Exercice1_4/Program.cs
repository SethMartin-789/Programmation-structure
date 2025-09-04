namespace Exercice1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom, numeroDA;

            // Saisie des données initiales
            Console.WriteLine("Saisir votre nom complet et appuyer sur la touche Entrée :");
            nom = Console.ReadLine() ?? "aucun";
            Console.WriteLine("Saisir votre numéro de DA et appuyer sur la touche Entrée :");
            numeroDA = Console.ReadLine() ?? "aucun";

            // Affichage des résultats
            Console.WriteLine("\n**************************");
            Console.WriteLine("420-163-CH");
            Console.WriteLine("Programmation Structurée");
            Console.WriteLine("Nom : " + nom);
            Console.WriteLine("#DA : " + numeroDA);
            Console.WriteLine("**************************");
        }
    }
}
