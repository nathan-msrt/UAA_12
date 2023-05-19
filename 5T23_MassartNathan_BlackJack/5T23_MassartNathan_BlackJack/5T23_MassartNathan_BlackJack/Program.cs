using System;

namespace _5T23_MassartNathan_BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                             ---------------------------------------");
            Console.WriteLine("                                                    Bienvenue dans le BLACKJACK");
            Console.WriteLine("                                             ---------------------------------------");
            Console.WriteLine("             ");
            Console.WriteLine("             ");
            Console.WriteLine("                               Les règles du jeu sont simples, vous devez battre la main du croupier");
            Console.WriteLine("                           en vous rapprochant le plus de 21 si vous passez au dessus de 21 vous avez perdu.");
            Console.WriteLine("                       Si vous avez la situation du blackjack c'est à dire un as et une buche (valet, dame ou roi)");
            Console.WriteLine("                                 dès le début du jeu vous avez automatiquement gagnez la partie! ");
            Console.WriteLine("             ");
            Console.WriteLine("                                          Les valeurs des cartes sont les suivantes :");
            Console.WriteLine("             ");
            Console.WriteLine("                                      - de 2 à 9 : valeur nominale de la carte.");
            Console.WriteLine("                                      - de 10 au roi : valeur de 10 points.");
            Console.WriteLine("                                      - as : 1 ou 11 au choix du joueur.");
            Console.WriteLine("             ");
            bool restart = true;
            int nbJoueur = 0;
            string PseudoJoueur;
            int couleur;
            int chiffre;
            int somme;
            int nbTour = 0;
            int[,] Matrices;
            int[,] TabCroupier;
            Traitement MesOutils = new Traitement();
            while (restart)

            {
                //demandez le nb de joueurs et demandez le pseudo 
                Console.WriteLine("Combien de joueurs êtes vous ? Entrez un chiffre (max 6)");
                MesOutils.LectureR("Nombre de joueurs : ", out nbJoueur);
                Matrices = new int[nbJoueur, 8];
                Console.WriteLine("Quel est votre pseudo ?");
                MesOutils.("Pseudo : ", out PseudoJoueur);
                MesOutils.tour1(nbJoueur, out chiffre, out couleur, ref nbTour, ref Matrices);
                MesOutils.tour1Croupier(out chiffre, out couleur, ref nbTour, ref TabCroupier);
                TabCroupier = new int[nbJoueur, 8];
                // faire intervenir le tour du croupier a piocher une carte 
                //exemple : 
                for (int i = 0; i < nbJoueur; i++)
                {
                    MesOutils.SommeJoueur(TabCroupier, i, out somme);
                    Console.WriteLine("joueur n°" + i + " = " + somme);
                }
                //-----
                for (int i = 0; i < TabCroupier.GetLength(0); i++)
                {
                    for (int y = 0; y < TabCroupier.GetLength(1); y++)
                    {
                        Console.Write(TabCroupier[i, y] + "|");
                    }
                    Console.WriteLine("");
                }

                //demander a l'utilisateur si il veut repiocher une carte ou rester ou doubler ou split 
                //utiliser TourSuivant et alea carte dedans et faire la somme avec le mp sommeJoueur


                
                restart = false;


            }


        }
        
        
        
    }
}