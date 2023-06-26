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
            string phClaire;
            string phClef;
            string matrice;
            string restart;
            bool ok;

          
            do
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
                } while ((choix != "1") && (choix != "2"));
                if (choix == "1")
                {
                    Console.WriteLine("Cryptage Vigenere");
                    Console.Write("Entrez la phrase claire : ");
                    phClaire = Console.ReadLine();
                    do
                    {
                        Console.Write("Entrez la clé : ");
                        phClef = Console.ReadLine();
                        MesOutils.VerifierCle(phClef, out ok);
                    } while (phClef == "" && ok == false);
                    string phClaireSSE;
                    MesOutils.RetireEspaces(phClaire, out phClaireSSE);
                    MesOutils.CryptVinegere(phClaireSSE, phClef, out string[,] MatVigenere);
                    MesOutils.ConcatenerMatrice(MatVigenere, out matrice);
                    Console.WriteLine(matrice);
                    Console.WriteLine("Voici votre phrase crypté :");
                    MesOutils.ConcateneDerniereLigne(MatVigenere, out matrice);
                    Console.WriteLine(matrice);
                }
                else if (choix == "2")
                {
                    Console.WriteLine("Cryptage Affine");
                    Console.Write("Entrez la phrase claire : ");
                    phClaire = Console.ReadLine();
                    string phClaireSSE;
                    MesOutils.RetireEspaces(phClaire, out phClaireSSE);
                    do
                    {
                        Console.Write("Entrez le coéficient ");
                        MesOutils.LectureR("a : ", out a);

                    } while (!((a >= 1 && a <= 25) && (a % 2 == 1) && (a != 13)));
                    do
                    {
                        Console.Write("Entrez le coéficient ");
                        MesOutils.LectureR("b : ", out b);

                    } while (b<0 || b>26);
                    MesOutils.CryptAffine(phClaire, a, b, out string[,] MatAffine);
                    MesOutils.ConcatenerMatrice(MatAffine, out matrice);
                    Console.WriteLine(matrice);
                    Console.WriteLine("Voici votre phrase crypté :");
                    MesOutils.ConcateneDerniereLigne(MatAffine, out matrice);
                    Console.WriteLine(matrice);
                }
                Console.WriteLine("Voulez vous recommencer oui ou non ? (o = oui et autre = non)");
                restart = Console.ReadLine();
            } while (restart == "o");

            

        } 
    }
}
