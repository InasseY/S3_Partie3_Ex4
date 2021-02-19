using System;

namespace Partie3_Ex4
{
    class Program
    {
        static void Main(string[] args)

        {
        

            //définir une variable aléatoire, 
            Random aleatoire = new Random();
            int secretnumber = aleatoire.Next(1, 51);
            int attempts = 1; // nombre d'essaie 
            int success = 0;

            Console.WriteLine("Devine un nombre entre 1 et 50 ");
            int input = int.Parse(Console.ReadLine());

            do
            {
                if (input == secretnumber)
                {
                    Console.WriteLine($"essaie n°{attempts} \n Gagné !");
                    success = 1;
                }
                else if (input < secretnumber)
                {
                    Console.WriteLine($"essaie n° {attempts} \n trop petit, retente ta chance !");
                    attempts++;
                    input = int.Parse(Console.ReadLine());
                }
                else if (input > secretnumber)
                {
                    Console.WriteLine($"essaie n° {attempts} \n Ah trop grand!  retente ta chance !");
                    attempts++;
                    input = int.Parse(Console.ReadLine());
                }
            } while (success == 0);
        }
    }
}



/* Code qui fonctionne 

      Random random = new Random();
      int tries = 0;
      int nb = random.Next(1, 51);
      Console.WriteLine("devinez le nombre entre 1 et 50 !");
      int nbUser = Convert.ToInt32(Console.ReadLine());
      tries++;


      while (nbUser > nb)
      {
          Console.WriteLine($"c'est plus petit que {nbUser}, vous avez fait {tries} tentatives ! Devinez à nouveau");
          nbUser = Convert.ToInt32(Console.ReadLine());
          tries++;

      }

      while (nbUser < nb)
      {
          Console.WriteLine($"c'est plus grand que {nbUser}, vous avez fait {tries} tentatives ! Devinez à nouveau !");
          nbUser = Convert.ToInt32(Console.ReadLine());
          tries++;



      }

      while (nbUser != nb)
      {
          Console.WriteLine($"encore raté :/ ce n'est pas {nbUser} , vous avez fait {tries} tentatives devinez à nouveau");
          nbUser = Convert.ToInt32(Console.ReadLine());
          tries++;

      }

      Console.WriteLine($"C'est pas trop tot ! vous avez trouvé en {tries} tentatives,  Félicitation !");*/



