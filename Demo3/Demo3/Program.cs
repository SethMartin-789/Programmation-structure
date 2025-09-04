/* DROITS D'AUTEUR
 * Consulter le fichier "README - Droits d'auteur.md" de la solution.
 */

namespace Demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***************************************************************************
             * Le type de données "decimal"
             * 
             * double  : - Stocké sur 8 octets (64 bits) en mémoire.
             *           - Les calculs avec les doubles sont plus rapides.
             *           
             * decimal : - Stocké sur 16 octets (128 bits) en mémoire.
             *           - Utiliser lorsque vous voulez stocker des valeurs monétaires,
             *             ou tout autre cas où la précision est essentielle.
             ***************************************************************************/

            /* Voici une situation où nous devons utiliser le type decimal :
             */
            /*
            double montantDouble = 0.1;
            montantDouble += 0.1;
            montantDouble += 0.1;
            montantDouble -= 0.3;
            Console.WriteLine($"Utilisation de double  : {montantDouble:F25}");

            decimal montantDecimal = 0.1m;
            montantDecimal += 0.1m;
            montantDecimal += 0.1m;
            montantDecimal -= 0.3m;
            Console.WriteLine($"Utilisation de decimal : {montantDecimal}");
            */


            /* Autre exemple où le decimal doit être utilisé.
             */
            /*
            double coutDouble = 100.0;
            double taxesDouble = 0.14975; // 5% + 9,975%
            double totalDouble = coutDouble * (1 + taxesDouble);
            Console.WriteLine($"Utilisation de double  : {coutDouble:F} + {taxesDouble:F25} = {totalDouble:F25}");

            decimal coutDecimal = 100.0m;
            decimal taxesDecimal = 0.14975m; // 5% + 9,975%
            decimal totalDecimal = coutDecimal * (1 + taxesDecimal);
            Console.WriteLine($"Utilisation de decimal : {coutDecimal:F} + {taxesDecimal} = {totalDecimal}");
            */


            /* Autre exemple où l'utilisation du double est suffisant.
             * 
             * Calculer le temps nécessaire pour parcourir une distance donnée à une vitesse donnée. 
             */
            /*
            double distanceDouble = 1234567.89;
            double vitesseDouble = 1234.567;
            double dureeDouble = distanceDouble / vitesseDouble;
            Console.WriteLine("Utilisation de double  : Temps nécessaire (en secondes) = " + dureeDouble);

            decimal distanceDecimal = 1234567.89m; // Utilisation de decimal
            decimal vitesseDecimal = 1234.567m; // Utilisation de decimal
            decimal dureeDecimal = distanceDecimal / vitesseDecimal;
            Console.WriteLine("Utilisation de decimal : Temps nécessaire (en secondes) = " + dureeDecimal);
            */

            /****************************************
             * Les constantes
             * 
             * Une constante NE peut PAS changer de valeur pendant sa durée de vie.
             * 
             * Vous utilisez des constantes pour stocker des valeurs FIXES que vous avez
             * l'intention d'utiliser ultérieurement dans votre code (possiblement plusieurs fois).
             * 
             * Déclaration d'une constante :
             * Vous devez d'abord déclarer le type de données de la variable, puis lui attribuer un nom
             * 
             * Règles et conventions de nommage des constantes:
             * Mêmes règles que les variables sauf...
             * - Doivent être entièrement écrit en MAJUSCULE : cont double PI
             * - Les mots doivent être séparés par un trait de soulignement : const string NOM_ECOLE
             ****************************************/

            /*
            const string NOM_ECOLE = "Cégep de Chicoutimi";

            Console.Write("Bienvenue au ");
            Console.WriteLine(NOM_ECOLE);
            */



            /****************************************
             * Les fonctions mathématiques
             * 
             * Math.PI | Floor | Round | Abs | Sqrt | Pow | Max | Min
             ****************************************/

            /********************************
             * const double Math.PI
             ********************************/

            //Console.WriteLine($"La valeur de PI : {Math.PI}");

            /*
            double valeurPI = Math.PI;
            Console.WriteLine($"La valeur de PI : {valeurPI}");
            */

            /*
            double calculX = 5 * Math.PI;
            Console.WriteLine($"Le résultat d'un calcul X : {calculX}");
            */


            /********************************
             * double Math.Floor(double d)
             ********************************/

            /*
            double plancher = Math.Floor(2.3);
            Console.WriteLine($"La valeur inférieure : {plancher}");
            */


            /********************************
             * double Math.Round(double value, int digits)
             ********************************/

            /*
            double arrondiPI = Math.Round(Math.PI, 4);
            Console.WriteLine($"La valeur arrondie de PI : {arrondiPI}");
            */


            /********************************
             * int Math.Abs(int value)
             * double Math.Abs(double value)
             ********************************/

            /*
            int absolue1 = Math.Abs(7);
            int absolue2 = Math.Abs(-7);
            double absolue3 = Math.Abs(-8.5);

            Console.WriteLine($"La valeur absolue (7) : {absolue1}");
            Console.WriteLine($"La valeur absolue (-7) : {absolue2}");
            Console.WriteLine($"La valeur absolue (-8.5) : {absolue3}");
            */


            /********************************
             * double Math.Sqrt(double d)
             ********************************/

            /*
            double racineCarree = Math.Sqrt(16);
            Console.WriteLine($"La racine carrée : {racineCarree}");
            */


            /********************************
             * double Math.Pow(double x, double y)
             ********************************/

            /*
            double resultat = Math.Pow(2, 3);
            Console.WriteLine($"Le résultat : {resultat}");
            */



            /********************************
             * int Math.Max(int x, int y)
             * double Math.Max(double x, double y)
             ********************************/

            /*
            int max1 = Math.Max(7, 5);
            double max2 = Math.Max(2.5, 8.5);

            Console.WriteLine($"Le max 1 : {max1}");
            Console.WriteLine($"Le max 2 : {max2}");
            */


            /********************************
             * int Math.Min(int x, int y)
             * double Math.Min(double x, double y)
             ********************************/

            /*
            int min1 = Math.Min(7, 5);
            double min2 = Math.Min(2.5, 8.5);

            Console.WriteLine($"Le min 1 : {min1}");
            Console.WriteLine($"Le min 2 : {min2}");
            */


            /****************************************
             * Nombre aléatoire
             ****************************************/

            /*
            Random rand = new Random();
            int nombreAleatoire = rand.Next(1, 100); // excluant 100, donc 1 à 99!

            Console.WriteLine($"Le résultat du tirage : {nombreAleatoire}");
            */


            /****************************************
             * Conversion implicite vs explite (casting)
             * 
             * Un entier divisé par un entier --> donne un entier
             * Il faut explicitement convertir en double un des membres de la division
             ****************************************/

            /*
            double moyenne;

            moyenne = 100 / 3;
            Console.WriteLine($"La moyenne (implicite) : {moyenne}");

            moyenne = 100.0 / 3;
            Console.WriteLine($"La moyenne (implicite) : {moyenne}");

            moyenne = (double)100 / 3;
            Console.WriteLine($"La moyenne (explicite) : {moyenne}");
            */

            /*
            int somme = 100;
            int nbItems = 3;
            double moyenne;

            moyenne = somme / nbItems;
            Console.WriteLine($"La moyenne (implicite) : {moyenne}");

            moyenne = (double)somme / nbItems;
            Console.WriteLine($"La moyenne (explicite) : {moyenne}");
            */


            /****************************************
             * Utilisation de la structure DateTime
             * 
             * Pour récupérer :
             * le jour, le mois et l'année en cours.
             ****************************************/

            /*
            int jour = DateTime.Now.Day;
            int mois = DateTime.Now.Month;
            int year = DateTime.Now.Year;

            Console.WriteLine($"Jour : {jour}");
            Console.WriteLine($"Mois : {mois}");
            Console.WriteLine($"Année : {year}");
            */

            // Quand assigner DateTime.Now à une variable?
            /*
            Console.WriteLine(DateTime.Now.Second);
            Thread.Sleep(1000); // pause de 1 seconde
            Console.WriteLine(DateTime.Now.Second);
            Thread.Sleep(1000); // pause de 1 seconde
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine();

            DateTime maintenant = DateTime.Now;
            Console.WriteLine(maintenant.Second);
            Thread.Sleep(1000); // pause de 1 seconde
            Console.WriteLine(maintenant.Second);
            Thread.Sleep(1000); // pause de 1 seconde
            Console.WriteLine(maintenant.Second);
            */



            /****************************************
             * Format d'affichage des nombres
             * 
             * F ou Fx
             * C ou Cx
             * 
             * Note : cela NE change PAS la valeur de la variable.
             ****************************************/

            /*
            double valeurPI = Math.PI;

            Console.WriteLine($"La valeur arrondie de PI : {valeurPI:F}");
            Console.WriteLine($"La valeur arrondie de PI : {valeurPI:F4}");
            Console.WriteLine($"La valeur de PI : {valeurPI}");
            */

            /*
            double montantTaxes = 25.7452;

            Console.WriteLine($"Le montant arrondi des taxes : {montantTaxes:C}");
            Console.WriteLine($"Le montant arrondi des taxes : {montantTaxes:C4}");
            Console.WriteLine($"Le montant des taxes : {montantTaxes}");
            */



            /****************************************
             * Couleur dans la console (fenêtre d'exécution)
             * 
             * Console.ForegroundColor
             * Console.BackgroundColor
             ****************************************/

            /*
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nBonjour tout le monde!");
            */

            /*
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\nBonjour tout le monde!");
            Console.ResetColor();
            */

            /*
            Console.WriteLine("\nBonjour tout le monde!");
            Console.ForegroundColor = ConsoleColor.Black;
            */

            /*
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("\n Cours ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(" Programmation ");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(" Structurée ");

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Black;
            */



            /****************************************
             * Effacer le contenu de la console (fenêtre d'exécution)
             * 
             * Console.Clear()
             ****************************************/

            /*
            string prenom;

            Console.Write("Saisir votre prénom et appuyer sur Entrée : ");
            prenom = Console.ReadLine() ?? "";

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Bonjour {prenom}, bienvenue au cours de programmation structurée.");
            Console.ForegroundColor = ConsoleColor.Black;
            */


            Console.ReadKey();
        }
    }
}