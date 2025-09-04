using System.Text;

namespace Exercice2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string cheminAcces = Path.GetFullPath(@".");

            Console.WriteLine("Messages :");
            Console.WriteLine("\tMessage #12R5  :\t\"Accès aux fichiers interdit !\"");
            Console.WriteLine("\tChemin d'accès :\t" + cheminAcces);
            Console.WriteLine("\tPied-de-mouche :\t" + '\x00B6');
            Console.WriteLine("\t'O' barré      :\t" + '\x00D8');

            _ = Console.ReadLine();
        }
    }
}
