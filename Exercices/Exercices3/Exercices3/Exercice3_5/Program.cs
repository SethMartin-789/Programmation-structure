namespace Exercice3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rayon, diametre, superficie, circonference;

            Console.WriteLine("Saisir le rayon d'un cercle et appuyer sur Entrée :");
            rayon = double.Parse(Console.ReadLine() ?? "0.0");
            diametre = rayon * 2;
            superficie = Math.Pow(rayon, 2) * Math.PI;
            circonference = rayon * Math.PI * 2;

            Console.WriteLine("\nLes informations d'un cercle de rayon {rayon} cm sont :" +
                         $"\n\tDiamètre :\t{diametre:F2} cm" +
                         $"\n\tCirconférence :\t{circonference:F2} cm" +
                         $"\n\tSuperficie :\t{superficie:F2} cm²");
        }
    }
}
