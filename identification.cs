using System;

class Identification
{
  
    
        public static void Identifiant()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        
      
        Console.WriteLine("_____________________________________________________");
        Console.WriteLine("|                                                   |");
        Console.WriteLine("|               ****** ALDA ******                  |");
        Console.WriteLine("|                                                   |");
       Console.ResetColor();
        Console.WriteLine("");
        Console.WriteLine("|                                                   |");
        Console.WriteLine("|     Trouver les pros dans tout les domaines       |");
        Console.WriteLine("|          Plus rapide et tres efficases            |");
        Console.WriteLine("|                                                   |");
        Console.WriteLine("|---------------------------------------------------|");

        // declaration des variables
        string choix = "";
        //poser la question pour qu"il soisiisse sa categorie
        while (true)
        {
            Console.WriteLine("Vous devez choisir le numero qui correspond a  votre categorie \n");
            Console.WriteLine("1- Client\n");
            Console.WriteLine("2- Profectionnel\n");
            Console.WriteLine("3- sortir\n");
            Console.Write("Votre choix...\n");
            choix = Console.ReadLine();
         
            // redirection selon le choix
            switch (choix){
                case "1":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Bienvenu dans le profil client\n");
                    Console.ResetColor();
                    Client.Client_profil();
                    return;
                   
                case "2":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Bienvenu dans le profil profetionnel\n");
                    Console.ResetColor();
                    break;

                case "3":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("merci d'avoir visiter l'ALDA\n");
                    Console.ResetColor();
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

   
       
       

    






