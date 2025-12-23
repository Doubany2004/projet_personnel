using System;

class Program
{
static void Main(string[] args)
	{
        // Déclaration et saisie du nom
        Console.Write("Entrez votre nom : ");
        string nom = Console.ReadLine();


        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Identification.Identifiant(nom);
       
        Console.ReadKey();
    }
}

