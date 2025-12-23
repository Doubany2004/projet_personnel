using System;

 class Salon
{
	public static void Salon_beaute(string nom)
	{
        // declaration des variables
        string choix_salon = "";
        Console.WriteLine("✅ Bienvenu " + nom+ " a EVELINE SALON BEAUTE\n");
        
        Console.WriteLine("Choisisez le numero du service dont vous avez besoin\n");
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1- 💇‍ COIFFURE\n");
            Console.WriteLine("2-😶‍🌫️💆‍ SOINS DE VISAGE\n");
            Console.WriteLine("3- 💅 MANUCURE\n");
            Console.WriteLine("4 ❌ precedent\n");
            Console.ResetColor();
            Console.Write("votre choix");
            choix_salon = Console.ReadLine("\n");
            switch (choix_salon)
            {
                case "1":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("_____________________________________________________");
                    Console.WriteLine("|                                                   |");
                    Console.WriteLine("|         ******💇‍ EVELINE COIFFURE ******          |");
                    Console.WriteLine("|                                                   |");
                    Console.WriteLine("|---------------------------------------------------|");
                    Console.ResetColor();
                    break;
                case "2":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("_____________________________________________________");
                    Console.WriteLine("|                                                   |");
                    Console.WriteLine("|      ******💇‍ EVELINE SOINS DE VISAGE ******      |");
                    Console.WriteLine("|                                                   |");
                    Console.WriteLine("|---------------------------------------------------|");
                    Console.ResetColor();
                    break;
                case "3":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("_____________________________________________________");
                    Console.WriteLine("|                                                   |");
                    Console.WriteLine("|         ****** 💅 EVELINE MANUCURE ******         |");
                    Console.WriteLine("|                                                   |");
                    Console.WriteLine("|---------------------------------------------------|");
                    Console.ResetColor();
                    break;
                case "4":
                    Service.Service_disponible(nom);
                    return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("choix invalide...\n");
                    Console.ResetColor();
                    break;

            }
        }
    }
}
