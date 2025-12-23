using System;

class Client
{
    public static void Client_profil(string nom)
    {
        // declaration des variables
        string nom_utilisateur = "";
        string utilisateur_id = "";
        bool idendifiant_valide = false;
        bool mot_de_passe_valide = false;
       // string nom = "";
        // declaration du tableau du nom d'utilisateur et mot de passes
        string[] utilisateur = new string[3] { "pascal123", "pascaline345", "pauline567" };
        string[] utilisateur_mot_pass = new string[3] { "2004", "2005", "2006" };

        while (!idendifiant_valide)
        {
            Console.WriteLine("Quel est votre identifiant?\n");
            nom_utilisateur = Console.ReadLine();
            for (int i = 0; i < utilisateur.Length; i++)
            {
                if (nom_utilisateur == utilisateur[i])
                {
                    idendifiant_valide = true;
                    //nom = utilisateur[i];



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
            utilisateur_id = Console.ReadLine();
            for (int i = 0; i < utilisateur_mot_pass.Length; i++)
            {
                if (utilisateur_mot_pass[i] == utilisateur_id)
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

