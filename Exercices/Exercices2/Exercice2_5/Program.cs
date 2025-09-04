namespace Exercice2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pieces, reste, parts;

            Console.WriteLine("Combien de pièces de 1$ sont à partager ?");
            pieces = int.Parse(Console.ReadLine() ?? "0");
            
            Console.WriteLine("En combien de parts ce montant doit être partagé ?");
            parts = int.Parse(Console.ReadLine() ?? "0");
            reste = pieces % parts;
            pieces = (pieces - reste) / parts;

            Console.WriteLine($"Chaque part contiendra {pieces}$ et il restera {reste}$ qui ne pourra pas être partagé.");
        }
    }
}
