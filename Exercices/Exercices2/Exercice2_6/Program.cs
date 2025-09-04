namespace Exercice2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double poids, taille, IMC;

            Console.WriteLine("Quel est votre poids en kg ?");
            poids = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Quel est votre taille en mètres ?");
            taille = double.Parse(Console.ReadLine() ?? "0");

            IMC = poids / (taille * taille);
            Console.WriteLine("Votre IMC est de " + IMC);
        }
    }
}
