using System;

namespace CEUUA11_2023_MassartNathan
{
    class Program
    {
        static void Main(string[] args)
        {
            Traitement MesOutils = new Traitement();
            string choix;
            int a;
            int b;
            string phClaire = "";
            string phClef = "";
            bool restart = true;

            while (restart)
            {
                Console.WriteLine("                                             ---------------------------------------");
                Console.WriteLine("                                                    Bienvenue dans le Cryptage");
                Console.WriteLine("                                             ---------------------------------------");
                Console.WriteLine("             ");
                Console.WriteLine("             ");
                do
                {
                    Console.WriteLine("Menu : " +

                    "\n    1. Cryptage Vigenere" +
                    "\n    2. Cryptage par affinement");

                    choix = Console.ReadLine();
                    if (choix == "1")
                    {
                        Console.WriteLine("Cryptage Vigenere");
                        Console.Write("Entrez la phrase claire : ");
                        phClaire = Console.ReadLine();
                        Console.Write("Entrez la clé : ");
                        phClef = Console.ReadLine();
                        MesOutils.VerifierCle(phClef);
                        string phClaireSSE;
                        MesOutils.RetireEspaces(phClaire, out phClaireSSE);
                        MesOutils.CryptVigenere(phClaire, phClef, out string[,] MatVigenere);
                        for (int i = 0; i < MatVigenere.GetLength(0); i++)
                        {
                            for (int y = 0; y < MatVigenere.GetLength(1); y++)
                            {
                                Console.Write(MatVigenere[i, y] + "|");
                            }
                            Console.WriteLine("");
                        }
                        restart = false;
                    }
                    if (choix == "2")
                    {
                        Console.WriteLine("Cryptage Affine");
                        Console.Write("Entrez la phrase claire : ");
                        phClaire = Console.ReadLine();
                        Console.Write("Entrez la clé : ");
                        phClef = Console.ReadLine();
                        MesOutils.VerifierCle(phClef);
                        string phClaireSSE;
                        MesOutils.RetireEspaces(phClaire, out phClaireSSE);
                        Console.Write("Entrez la a : ");
                        MesOutils.LectureR("a : ", out a);
                        Console.Write("Entrez la b : ");
                        MesOutils.LectureR("b : ", out b);
                        MesOutils.CryptAffine(phClaire, a, b, out string[,] MatAffine);
                        for (int i = 0; i < MatAffine.GetLength(0); i++)
                        {
                            for (int y = 0; y < MatAffine.GetLength(1); y++)
                            {
                                Console.Write(MatAffine[i, y] + "|");
                            }
                            Console.WriteLine("");
                        }
                        restart = false;
                    }
                } while (restart == false);
            }

        } 

            
        }
    }
}
