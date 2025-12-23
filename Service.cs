using System;

 class Service
{
	public static void Service_disponible(string nom)
	{

        // declaration des variables
        int service_choisi = 0;
        Console.ForegroundColor = ConsoleColor.Blue;


        Console.WriteLine("_____________________________________________________");
        Console.WriteLine("|                                                   |");
        Console.WriteLine("|               ****** ALDA ******                  |");
        Console.WriteLine("|                                                   |");
        Console.ResetColor();
        Console.WriteLine("");
        Console.WriteLine("|                                                   |");
        Console.WriteLine("|                     SERVICES                      |");
        Console.WriteLine("|                                                   |");
        Console.WriteLine("|                                                   |");
        Console.WriteLine("|---------------------------------------------------|");
        Console.WriteLine("");
        Console.WriteLine("Bienvenu " + nom);
        while (true)
        {

            Console.WriteLine("Voila les services que nous proposons\n");
            Console.WriteLine("Choisisez le numero de servise dont vous avez besoin\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1-💅 Salon de beaute\n");
            Console.WriteLine("2-⚡ Electricien\n");
            Console.WriteLine("3-🔧 Plombier\n");
            Console.WriteLine("4- ❌ Precedent\n");
            Console.ResetColor();
            Console.Write("Votre choix..");
            service_choisi = int.Parse(Console.ReadLine());
            switch (service_choisi)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("_____________________________________________________");
                    Console.WriteLine("|                                                   |");
                    Console.WriteLine("|         ****** 💅 SALON DE BEAUTE ******          |");
                    Console.WriteLine("|                                                   |");
                    Console.WriteLine("|---------------------------------------------------|");
                    Console.ResetColor();
                    Salon.Salon_beaute(nom);
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("_____________________________________________________");
                    Console.WriteLine("|                                                   |");
                    Console.WriteLine("|             ****** ⚡ Electricien ******          |");
                    Console.WriteLine("|                                                   |");
                    Console.WriteLine("|---------------------------------------------------|");
                    Console.ResetColor();
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("_____________________________________________________");
                    Console.WriteLine("|                                                   |");
                    Console.WriteLine("|          ****** 🔧 Plombier  ******               |");
                    Console.WriteLine("|                                                   |");
                    Console.WriteLine("|---------------------------------------------------|");
                    Console.ResetColor();
                    break;
                case 4:
                    Identification.Identifiant(nom);
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
