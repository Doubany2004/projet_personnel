using System;

 class Client
{
	public static void Client_profil()
	{
		// declaration des variables
		string nom_utilisateur = "";
        string utilisateur_id ="";
		// declaration du tableau du nom d'utilisateur et mot de passes
string[] utilisateur = new string[3] { "pascal", "pascaline", "pauline" };
        string[] utilisateur_mot_pass = new string[3] { "2004", "2005", "2006" };

        while (true)
		{
            Console.WriteLine("Quel est votre identifiant?\n");
            nom_utilisateur = Console.ReadLine();
			for(int i = 0; i < utilisateur.Length; i++)
			{
				if (nom_utilisateur == utilisateur[i])
				{
                     Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("identifiant accepté\n");
                    Console.ResetColor();
                    break;

                }

				else
				{
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("identifiant incorrect\n");
                    Console.ResetColor();
                    break;
                }



               
            }
            // declaration du  mot de passes
            Console.Write("Quel est votre mot de passe...\n");
            utilisateur_id = Console.ReadLine();
            for (int i = 0; i < utilisateur_mot_pass.Length; i++)
            {
                if (utilisateur_mot_pass[i] == utilisateur_id)
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Bienvenu " + utilisateur[i]);
                    Console.ResetColor();
                    return;
                }
                else
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("mot de passe incorrect\n");
                    Console.ResetColor();
                    break;

                }





            }
        }

    }
}
