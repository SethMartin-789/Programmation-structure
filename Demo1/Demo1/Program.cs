using System;
using System.Globalization;

/* DROITS D'AUTEUR
 * Consulter le fichier "README - Droits d'auteur.md" de la solution.
 */

namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /****************************************
             * Ligne de code générée par défaut
             * 
             * Démarrer pour afficher la fenêtre de sortie
             ****************************************/

            Console.WriteLine("Hello, World!");
            Console.Write("Hello, World!");
            Console.Write(" What, World?\n\nHmmm? Bon bein, bye bye!\n\n");


            /****************************************
             * Le flux d'exécution
             * 
             * Les instructions de code sont exécutées dans l'ordre, une ligne à la fois.
             ****************************************/


            Console.WriteLine("Programmation Structurée... bienvenue à mon TED talk!");
            Console.WriteLine("Bienvenue à tous!");




            /****************************************
             * Les commentaires
             ****************************************/

            // pour commenter une seule ligne de code

            /*
            pour commenter
            plusieurs
            lignes de code
            */



            /****************************************
             * Les messages d'erreur
             * 
             * L'éditeur de code surveille en permanence le code.
             * L'écriture du code C# est un exercice de précision...
             ****************************************/

            // Erreur CS0103: Le nom 'console' n'existe pas dans le contexte actuel
            Console.WriteLine("test");

            // Erreur CS1012: Trop de caractères dans le littéral de caractère
            Console.WriteLine('t');



            /****************************************
             * Write vs WriteLine
             ****************************************/

            /*
            Console.WriteLine("Bravo!");
            Console.WriteLine(" ");
            Console.WriteLine("Vous avez écrit vos premières lignes de code!");
            */

            /*
            Console.Write("Bravo!");
            Console.Write(" ");
            Console.Write("Vous avez écrit vos premières lignes de code!");
            */



            /****************************************
             * Comment votre code a fonctionné?
             * Un peu de vocabulaire :
             * 
             * Chaîne litérale : la phrase entourée de guillements --> "Bienvenue à tous!"
             * Méthode (possède des parenthèses) --> WriteLine()
             * Classe (moyen de stocker et d'organiser toutes les méthodes) --> Console
             * Opérateur d'accès aux membres --> le point (.)
             * Opérateur de fin d'instruction --> le point-virgule (;)
             ****************************************/

            //Console.WriteLine("Bienvenue à tous!");



            /****************************************
             * Write et WriteLine supportes plusieurs types de données
             ****************************************/

            /*
            Console.WriteLine("abc");
            Console.WriteLine(123);
            Console.WriteLine(25.5);
            */



            /****************************************
             * Les variables
             * 
             * Une variable est un élément de données dont la valeur peut changer pendant sa durée de vie.
             * 
             * Vous utilisez des variables pour stocker temporairement des valeurs que vous avez
             * l'intention d'utiliser ultérieurement dans votre code.
             * 
             * Déclaration d'une variable :
             * Vous devez d'abord déclarer le type de données de la variable, puis lui attribuer un nom
             * 
             * Règles et conventions de nommage des variables:
             * - Doivent commencer par une lettre minuscule ou un trait de soulignement.
             * - Peuvent contenir des caractères alphanumériques et le trait de soulignement.
             * - Doivent utiliser la casse mixte. Par exemple : string nomFamille;
             * - Doivent être descriptifs et explicites dans votre application (éviter les contractions et les abréviations).
             * - Doivent être un ou plusieurs mots entiers ajoutés les uns aux autres.
             * - Respectent la casse (sensible à la casse) : prenom est différent de prenOm
             * - Éviter les accents : é, à, â, ç, etc.
             * - NE doivent PAS inclure le type de données : string strNomFamille
             * - NE doivent PAS être un mot clé C#.
             ****************************************/


            /****************************************
             * Déclarer une variable
             * 
             * C# est un langage fortement typé : il faut spécifier le type de données pour chaque variable.
             ****************************************/

            //string prenom;
            //int totalDePoints;
            //double montantTotal;


            /****************************************
             * Affecter une valeur à la variable
             ****************************************/
            /*
            string prenom;
            prenom = "Bob";
            */

            //string prenom = "Bob";


            /****************************************
             * Affectation incorrecte
             ****************************************/

            // Erreur CS0131: La partie gauche d'une assignation doit être une variable, une propriété ou un indexeur
            // Erreur CS0103: Le nom 'prenom' n'existe pas dans le contexte actuel
            //"Bob" = prenom;

            // Erreur CS0029: Impossible de convertir implicitement le type 'string' en 'int'
            //int prenom;
            //prenom = "Bob";


            /****************************************
             * Récupérer une valeur stockée dans une variable
             ****************************************/
            /*
            string prenom;
            int age;

            prenom = "Bob";
            age = 18;

            Console.WriteLine(prenom);
            Console.WriteLine(age);
            */

            /****************************************
             * Réaffecter la valeur d'une variable
             ****************************************/
            /*
            string prenom;
            prenom = "Bob";
            Console.WriteLine(prenom);
            prenom = "Jack";
            Console.WriteLine(prenom);
            prenom = "Jim";
            Console.WriteLine(prenom);
            */


            /****************************************
             * Initialiser la variable
             ****************************************/

            //Erreur CS0165: Utilisation d'une variable locale non assignée 'prenom'
            /*
            string prenom;
            Console.WriteLine(prenom);
            */



            /****************************************
             * Lire une réponse de l'utilisateur dans la console
             ****************************************/

            /*
            string prenom;

            Console.WriteLine("Quel est ton prénom?");
            prenom = Console.ReadLine() ?? "";

            Console.Write("Bonjour ");
            Console.WriteLine(prenom);
            */


            /****************************************
             * Convertir une chaîne en entier
             * 
             * string --> int
             ****************************************/

            DateTime dateLocale = DateTime.Now;
            int anneeDeNaissance;
            int moisDeNaissance;
            bool differenceMois;
            int age;
            string anneeLue;
            string moisLue;

            Console.WriteLine("Quelle est ton année de naissance?");

            anneeLue = Console.ReadLine() ?? "0";
            anneeDeNaissance = int.Parse(anneeLue);

            Console.WriteLine("Quel est votre mois de naissance (en nombre)?");
            moisLue = Console.ReadLine() ?? "0";
            moisDeNaissance = int.Parse(moisLue);

            differenceMois = dateLocale.Month >= moisDeNaissance;
            Console.WriteLine(differenceMois);
            

            /*
            Console.Write("Vous avez ");
            Console.Write(age);
            Console.WriteLine(" ans.");
            */

            Console.ReadKey();
        }
    }
}