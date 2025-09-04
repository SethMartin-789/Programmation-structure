/* DROITS D'AUTEUR
 * Consulter le fichier "README - Droits d'auteur.md" de la solution.
 */

using System.Net.WebSockets;

namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /****************************************
             * Caractère d'échappement : \
             * 
             * ENTRÉE (retour de chariot) --> \n
             * TAB --> \t
             * \ --> \\
             * " --> \"
             ****************************************/

            /*
            Console.WriteLine("Programmation Structurée\nBienvenue à tous!");

            Console.WriteLine("Item A :\t25,00$");
            Console.WriteLine("Item B :\t50,00$");
            Console.WriteLine("Item C :\t75,00$");
            */

            // Erreur CS1009: Séquence d'échappement non reconnue
            // Erreur CS1009: Séquence d'échappement non reconnue
            //Console.WriteLine("Le chemin complet : C:\windows\system32");

            //Console.WriteLine("Le chemin complet : C:\\windows\\system32");

            // Erreur CS1003: Erreur de syntaxe, ',' attendu
            // Erreur CS1003: Erreur de syntaxe, ',' attendu
            // Erreur CS0103: Le nom 'backslash' n'existe pas dans le contexte actuel
            //Console.WriteLine("Le caractère d'échappement est le "backslash".");

            //Console.WriteLine("Le caractère d'échappement est le \"backslash\".");



            /****************************************
             * Code unicode des caractères
             * 
             * https://en.wikipedia.org/wiki/List_of_Unicode_characters
             ****************************************/

//            Console.WriteLine("A : \u0041");
//            Console.WriteLine("Z : \u005A");
//            Console.WriteLine("a : \u0061");
//            Console.WriteLine("Pied-de-mouche: \u00B6");
//            Console.WriteLine("Signe plus-moins : \u00B1");



            /****************************************
             * Interpolation de chaîne : $
             * 
             * {} --> pour insérer des variables
             ****************************************/

            /*
            string prenom = "Bob";

            Console.WriteLine($"Bonjour {prenom}");
            */

            /*
            string salutation = "Bonsoir";
            string prenom = "Bob";
            string message = $"{salutation} {prenom}, comment vas-tu?";

            Console.WriteLine(message);
            */




            /****************************************
             * Interpolation de chaîne avec alignement
             * 
             ****************************************/

            /*
            string nom1 = "Paul";
            string nom2 = "John";
            string nom3 = "Ringo";
            string nom4 = "George";
            double somme1 = 1.1;
            double somme2 = 22.2;
            double somme3 = 3.33;
            double somme4 = 44.44;
            Console.WriteLine($"{"Nom",-20} {"Somme",5}");
            Console.WriteLine($"{nom1,-20} {somme1,5}");
            Console.WriteLine($"{nom2,-20} {somme2,5}");
            Console.WriteLine($"{nom3,-20} {somme3,5}");
            Console.WriteLine($"{nom4,-20} {somme4,5}");
            */


            /****************************************
             * Lire (sur la même ligne que la question)
             * et afficher une réponse de l'utilisateur dans la console
             ****************************************/

            /*
            string prenom;

            Console.Write("Quel est ton prénom? ");
            prenom  = Console.ReadLine() ?? "";
            Console.WriteLine($"Bonjour {prenom}");
            */



            /****************************************
             * Opérateurs mathématiques
             * 
             * Attention à la convertion implicite...
             *   int <-- int / int
             *   double <-- int / double
             *   double <-- double / int
             *   double <-- double / double
             ****************************************/

            /*
            int somme = 7 + 5;
            int difference = 7 - 5;
            int produit = 7 * 5;
            double quotient = 7 / 5;

            Console.WriteLine("Somme : " + somme);
            Console.WriteLine("Difference : " + difference);
            Console.WriteLine("Produit : " + produit);
            Console.WriteLine("Quotient : " + quotient); // Oups... 7 / 5 = 1
            */

            /*
            //double quotient = 7 / 5.0;
            //double quotient = 7.0 / 5;
            double quotient = 7.0 / 5.0;
            Console.WriteLine("Quotient : " + quotient);
            */



            /****************************************
             * L'opérateur de reste (modulo) : %
             * 
             * Vous donne le reste de la division.
             ****************************************/

            /*
            int reste1 = 7 % 5;
            int reste2 = 25 % 5;

            Console.WriteLine(reste1);
            Console.WriteLine(reste2);
            */



            /****************************************
             * La priorité des opérateurs
             * 
             * 1. Parenthèses
             * 2. Exposants
             * 3. Multiplication et Division (de gauche à droite)
             * 4. Addition et Soustraction (de gauche à droite)
             ****************************************/

            /*
            int valeur1 = 3 + 4 * 5;
            int valeur2 = (3 + 4) * 5;
            int valeur3 = 20 / (2 + 3) * 4;

            Console.WriteLine(valeur1);
            Console.WriteLine(valeur2);
            Console.WriteLine(valeur3);
            */



            /****************************************
             * Incrémenter et décrémenter des valeurs
             * 
             * Opérateurs d’assignation composée : +=, -=, *=, et /=
             ****************************************/

            int valeur = 0;

            valeur = valeur + 5;
            Console.WriteLine(valeur); // la valeur est égale à 5 rendu ici

            valeur += 5;
            Console.WriteLine(valeur); // la valeur est égale à 10 rendu ici

            valeur = valeur - 5;
            Console.WriteLine(valeur); // la valeur est égale à 5 rendu ici

            valeur -= 5;
            Console.WriteLine(valeur); // la valeur est égale à 0 rendu ici

            valeur += 10;
            valeur /= 10;
            Console.WriteLine(valeur); // la valeur est égale à 1 rendu ici

            valeur *= 6;
            Console.WriteLine(valeur); // la valeur est égale à 6 rendu ici


            Console.ReadKey();
        }
    }
}