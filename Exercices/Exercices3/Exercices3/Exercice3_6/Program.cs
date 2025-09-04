namespace Exercice3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double TVQ = 0.09975;
            const double TPS = 0.05000;
            const double POURBOIRE = 0.15;

            string nomSandwich;
            double coutSandwich;
            double coutTVQ;
            double coutTPS;
            double coutTotalSandwich;
            double pourboireSuggeree;

            // Saisie des données
            Console.WriteLine("Saisir le nom du sandwich et appuyer la touche Entrée :");
            nomSandwich = Console.ReadLine() ?? "";

            Console.WriteLine("\nSaisir le coût du sandwich en $ avec décimales avant taxes et appuyer Entrée :");
            coutSandwich = Math.Round(double.Parse(Console.ReadLine() ?? "0"), 2);

            // Calculs des taxes, du total et du pourboire suggérée
            coutTVQ = Math.Round(coutSandwich * TVQ, 2);
            coutTPS = Math.Round(coutSandwich * TPS, 2);
            coutTotalSandwich = Math.Round(coutSandwich + coutTVQ + coutTPS, 2);
            pourboireSuggeree = Math.Round(coutSandwich * POURBOIRE, 2);

            // Affichage de la facture
            Console.WriteLine("\n*********************************************************");
            Console.WriteLine($"\tFacture pour le sandwich {nomSandwich} :");
            Console.WriteLine("*********************************************************");
            Console.WriteLine($"\tCoût du sandwich :\t{coutSandwich:F2} $");
            Console.WriteLine($"\tTPS :\t\t\t{coutTPS:F2} $");
            Console.WriteLine($"\tTVQ :\t\t\t{coutTVQ:F2} $");
            Console.WriteLine($"\tTotal :\t\t\t{coutTotalSandwich:F2} $");
            Console.WriteLine("*********************************************************");
            Console.WriteLine($"\tPourboire suggéré :\t{pourboireSuggeree:F2} $");
            Console.WriteLine("*********************************************************");
        }
    }
}
