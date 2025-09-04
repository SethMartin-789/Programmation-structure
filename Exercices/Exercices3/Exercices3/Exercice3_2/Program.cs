namespace Exercice3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateLocale = DateTime.Now;
            int anneeDeNaissance;
            int moisDeNaissance;
            int anneeFutur;
            int age;
            int ageFutur;
            string anneeLue;
            string moisLue;

            Console.WriteLine("Quelle est votre année de naissance?");

            anneeLue = Console.ReadLine() ?? "0";
            anneeDeNaissance = int.Parse(anneeLue);
            age = dateLocale.Year - anneeDeNaissance;

            Console.WriteLine("Quel est votre mois de naissance (en nombre)?");
            moisLue = Console.ReadLine() ?? "0";
            moisDeNaissance = int.Parse(moisLue);

            age = dateLocale.Year - anneeDeNaissance;
            if (moisDeNaissance > dateLocale.Month)
            {
                age = age - 1;
            }
            Console.WriteLine("Tu as " + age + " ans");

            Console.WriteLine("Saisir l'année désirée et appuyer sur la touche Entrée :");
            anneeFutur = int.Parse(Console.ReadLine() ?? "0");
            ageFutur = age + (anneeFutur - dateLocale.Year);

            Console.WriteLine($"Votre âge à l'année désirée est {ageFutur} ans");
        }
    }
}
