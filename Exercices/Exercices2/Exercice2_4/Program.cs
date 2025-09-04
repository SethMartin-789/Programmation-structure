double nombre;

Console.WriteLine("Écrire cinq nombres en appuyant sur Entrée entre chacun :");
nombre = double.Parse(Console.ReadLine() ?? "0");
nombre += double.Parse(Console.ReadLine() ?? "0");
nombre += double.Parse(Console.ReadLine() ?? "0");
nombre += double.Parse(Console.ReadLine() ?? "0");
nombre += double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("La moyenne est : " + (nombre / 5));

_ = Console.ReadLine();
