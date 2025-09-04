namespace Exercice1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom, poids;

            // Saisie des données initiales
            Console.WriteLine("Saisir votre nom complet et appuyer sur la touche Entrée :");
            nom = Console.ReadLine() ?? "aucun";
            Console.WriteLine("Saisir votre poids en kg et appuyer sur la touche Entrée :");
            poids = Console.ReadLine() ?? "aucun";

            // Affichage des résultats
            Console.WriteLine("\n**************************");
            Console.WriteLine("Nom : " + nom);
            Console.WriteLine("Âge : " + poids);
            Console.WriteLine("**************************");
        }
    }
}
