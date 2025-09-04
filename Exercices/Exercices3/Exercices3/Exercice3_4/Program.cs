namespace Exercice3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double largeur, longueur, superficie, perimetre;

            Console.WriteLine("Saisir la largeur du terrain en mètre et appuyer sur la touche Entrée :");
            largeur = double.Parse(Console.ReadLine() ?? "0.0");

            Console.WriteLine("Saisir la longueur du terrain en mètre et appuyer sur la touche Entrée :");
            longueur = double.Parse(Console.ReadLine() ?? "0.0");

            perimetre = largeur * 2 + longueur * 2;
            superficie = largeur * longueur;
            Console.WriteLine("\nLes dimensions du terrain sont :\n" +
                              $"\tPérimètre\t: {perimetre:F2} m\n" +
                              $"\tSuperficie\t: {superficie:F2} m²");
        }
    }
}
