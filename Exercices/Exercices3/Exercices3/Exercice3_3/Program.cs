namespace Exercice3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double litresConsommes, distanceParcourue, consommationMoyenneEssence;

            Console.WriteLine("Saisir la distance parcourue et appuyer sur la touche Entrée :");
            distanceParcourue = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Saisir la quantité de litres consommés et appuyer sur la touche Entrée :");
            litresConsommes = double.Parse(Console.ReadLine() ?? "0");

            consommationMoyenneEssence = litresConsommes / (distanceParcourue / 100);
            Console.WriteLine($"Voici la consommation moyenne d'essence de votre voiture : {consommationMoyenneEssence:F4} L/100km.");
        }
    }
}
