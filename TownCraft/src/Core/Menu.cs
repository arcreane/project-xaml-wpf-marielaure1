using System;

namespace TownCraft.Core
{
    public class Menu
    {
        public static void SelectOption(int option)
        {
            // G�rer la s�lection de l'option
            switch (option)
            {
                case 1:
                    // Nouvelle partie
                    Console.WriteLine("Nouvelle partie d�marr�e.");
                    break;
                case 2:
                    // Charger partie
                    Console.WriteLine("Chargement de la partie...");
                    break;
                case 3:
                    // Options
                    Console.WriteLine("Options du jeu.");
                    break;
                case 4:
                    // Quitter
                    Console.WriteLine("Quitter le jeu.");
                    break;
                default:
                    Console.WriteLine("Option invalide.");
                    break;
            }
        }

        // M�thode pour obtenir toutes les sauvegardes
        public static string[] GetAllSaves()
        {
            // Ici, vous pouvez impl�menter la logique pour r�cup�rer toutes les sauvegardes du jeu
            // Par exemple, vous pouvez lire les fichiers de sauvegarde depuis un r�pertoire sp�cifique

            // Pour l'exemple, je retourne un tableau de cha�nes vides
            return new string[0];
        }
    }
}
