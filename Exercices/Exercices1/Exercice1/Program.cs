namespace Exercice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateLocale = DateTime.Now;
            int anneeDeNaissance;
            int moisDeNaissance;
            int age;
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
        }
    }
}
