using System;

 class Professionnel
{
	public static void Professionnel_profil()
	{
        // declaration des variables
        string nom_professionnel = "";
        string professionnel_id = "";
        bool idendifiant_valide = false;
        bool mot_de_passe_valide = false;
        string nom = "";
        // declaration du tableau du nom d'utilisateur et mot de passes
        string[] professionnel = new string[3] {"eveline","mark","luc" };
        string[] professionnel_mot_pass = new string[3] {"004","005","006" };

        while (!idendifiant_valide)
        {
            Console.WriteLine("Quel est votre identifiant?\n");
            nom_professionnel = Console.ReadLine();
            for (int i = 0; i < professionnel.Length; i++)
            {
                if (nom_professionnel == professionnel[i])
                {
                    idendifiant_valide = true;
                    nom = professionnel[i];



                }

            }
            if (!idendifiant_valide)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ❌ Idendifiant incorrect\n");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("✅ Idendifiant valide");
                Console.ResetColor();
                break;
            }

        }
        while (!mot_de_passe_valide)
        {
            // declaration du  mot de passes
            Console.Write("Quel est votre mot de passe...");
            professionnel_id = Console.ReadLine();
            for (int i = 0; i < professionnel_mot_pass.Length; i++)
            {
                if (professionnel_mot_pass[i] == professionnel_id)
                {

                    mot_de_passe_valide = true;
                }


            }

            if (!mot_de_passe_valide)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ❌ mot de passe incorrect\n");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("✅ Bienvenu " + nom);
                Console.ResetColor();
                break;
            }




        }
    }
}
