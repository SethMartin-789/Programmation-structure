namespace Exercices3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit, celsius;

            Console.WriteLine("Saisir la température en Fahrenheit et appuyer sur la touche Entrée :");
            fahrenheit = double.Parse(Console.ReadLine() ?? "0");
            celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"La température correspondante en celsius est {celsius:F2} \u00B0C");
        }
    }
}
