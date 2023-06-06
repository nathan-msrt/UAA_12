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
            //string PseudoJoueur;
            int couleur;
            int chiffre;
            int somme;
            int sommeCroupier;
            int nbTour = 0;
            int[,] Matrices;
            int[] TabCroupier;
            string repiocher = "";
            string pseudo = "";
            int sommePseudo = 0;
        Traitement MesOutils = new Traitement();
            while (restart)
            {
                //demandez le nb de joueurs et demandez le pseudo 
                Console.WriteLine("Combien de joueurs êtes vous ? Entrez un chiffre (max 6)");
                //regarde si l'utilisateur met bien un nombre correct
                MesOutils.LectureR("Nombre de joueurs : ", out nbJoueur);
                //création matrice pour connaitre les cartes des joueurs
                Matrices = new int[nbJoueur, 8];
                //creation tableau pour connaitre les cartes du croupier
                TabCroupier = new int[ 8];
                //demande du pseudo
                Console.WriteLine("Quel est votre pseudo ?");
                pseudo = Console.ReadLine();
                Console.WriteLine("");
                do
                {
                    //demarage du jeu en distribuant une carte jusque ligne 92
                    MesOutils.tour1(nbJoueur, out chiffre, out couleur, ref pseudo, ref nbTour, ref Matrices);
                    MesOutils.tour1Croupier(out chiffre, out couleur, ref nbTour, ref TabCroupier);
                    for (int i = 0; i < nbJoueur; i++)
                    {
                        MesOutils.SommeJoueur(Matrices, i, out somme);
                        if (i >= 1)
                        {
                            //affichage des points des joueurs
                            Console.WriteLine("Le Joueur n°" + i + " a " + somme + " points");
                            Console.WriteLine("");
                        }
                        else
                        {
                            //affichage des points de l'utilisateur
                            Console.WriteLine(pseudo + " vous avez " + somme + " points");
                            Console.WriteLine("");
                        }
                    }

                    MesOutils.SommeCroupier(TabCroupier, nbTour, out sommeCroupier);
                    //affichage des points du croupier
                    Console.WriteLine("Le croupier a " + sommeCroupier + " points");
                    //Console.WriteLine("");
                    /*for (int i = 0; i < Matrices.GetLength(0); i++)
                    {
                        for (int y = 0; y < Matrices.GetLength(1); y++)
                        {
                            Console.Write("------" +"\n");
                            Console.Write("|" + Matrices[i, y] + "|");
                            Console.Write("------");
                        }
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                    for (int i = 0; i < TabCroupier.Length; i++)
                    {
                        Console.Write(TabCroupier[i] + "|");
                    }*/
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Appuyez sur enter pour continuer");
                    Console.ReadLine();
                    Console.Clear();
                    //demarage du tour 2 en distribuant une autre carte jusque ligne 92
                    MesOutils.tour2(nbJoueur, out chiffre, out couleur, ref pseudo, ref nbTour, ref Matrices);
                    MesOutils.tour2Croupier(out chiffre, out couleur, ref nbTour, ref TabCroupier);

                    for (int i = 0; i < nbJoueur; i++)
                    {
                        MesOutils.SommeJoueur(Matrices, i, out somme);
                        if (i >= 1)
                        {
                            //affichage des points des joueurs
                            Console.WriteLine("Le Joueur n°" + i + " a cumulé pour l'instant " + somme +"points");
                            Console.WriteLine("");
                        }
                        else
                        {
                            //affichage des points de l'utilisateur
                            sommePseudo = somme;
                            Console.WriteLine(pseudo + " vous avez cumulé pour l'instant " + somme + "points");
                            Console.WriteLine("");
                        }
                    }
                    //affichage des points du croupier
                    MesOutils.SommeCroupier(TabCroupier, nbTour, out sommeCroupier);
                    Console.WriteLine("Le croupier a cumulé pour l'instant " + sommeCroupier +"points");
                    //Console.WriteLine("");
                    /*for (int i = 0; i < Matrices.GetLength(0); i++)
                    {
                        for (int y = 0; y < Matrices.GetLength(1); y++)
                        {
                            Console.Write(Matrices[i, y] + "|");
                        }
                        Console.WriteLine("");
                    }
                    for(int i = 0; i < TabCroupier.Length; i++)
                    {
                        Console.Write(TabCroupier[i] + "|");
                    }*/
                    Console.WriteLine("");
                    if (sommePseudo == 21)
                    {
                        Console.WriteLine("Vous avez un BlackJack. Vous avez directement gagnez !");
                    }
                    //demande si l'utilisateur veut repiocher une carte
                    Console.WriteLine("Voulez-vous repiocher une carte ? OUI ou NON");
                    repiocher = Console.ReadLine();
                    while (repiocher == "OUI")
                    {
                       
                        //repioche d'une carte
                        MesOutils.repiocheCartePseudo(out chiffre, out couleur, ref pseudo, ref nbTour, ref Matrices);

                        for (int i = 0; i < nbJoueur; i++)
                        {
                            MesOutils.SommeJoueur(Matrices, i, out sommePseudo);
                            if (i == 0)
                            {
                                //affichage des points de l'utilisateur

                                Console.WriteLine(pseudo + " vous avez cumulé un total de " + sommePseudo + "points");
                                Console.WriteLine("");
                            }
                            if (sommePseudo > 21)
                            {
                                //fin du jeu si l'utilisateur dépasse 21
                                Console.WriteLine("Désolé " + pseudo + " vous avez été au dessus de 21 points. Vous avez perdu !");
                                restart = false;
                            }
                        }
                        Console.WriteLine("");
                        //demande si l'utilisateur veut repiocher une carte
                        Console.WriteLine("Voulez-vous repiocher une carte ? OUI ou NON");
                        repiocher = Console.ReadLine();
                    }
                    if (sommeCroupier <= 15)
                    {
                        do
                        {
                            //repioche d'une carte
                            MesOutils.repiocheCarteCroupier(out chiffre, out couleur, ref nbTour, ref TabCroupier);
                        } while (sommeCroupier <=15);
                        
                    } 
                    MesOutils.SommeCroupier(TabCroupier, nbTour, out sommeCroupier);

                    if (sommeCroupier > 21 && sommePseudo <= 21)
                    {
                        //fin du jeu si le croupier a dépassé 21 et que l'utilisateur a pas dépassé 21
                        Console.WriteLine("Le croupier a été au dessus de 21 points. Vous avez gagnez avec" + sommePseudo + "points");
                        Console.WriteLine("");
                        restart = false;
                    }

                    for (int i = 0; i < nbJoueur; i++)
                    {
                        MesOutils.SommeJoueur(Matrices, i, out somme);
                        if (i == 0)
                        {
                            //affichage des points de l'utilisateur
                            sommePseudo = somme;
                            Console.WriteLine(pseudo + " vous avez cumulé un total de " + sommePseudo + "points");
                            Console.WriteLine("");
                        }
                    }
                    //affichage des points du croupier
                    Console.WriteLine("Le croupier a cumulé un total de " + sommeCroupier + "points");
                    Console.WriteLine("");
                    MesOutils.SommeJoueur(Matrices, 0, out sommePseudo);
                    MesOutils.VerifPoints(ref nbTour, ref sommePseudo, ref sommeCroupier);
                    // demande si l'utilisateur veut recommencer
                    Console.Write("Voulez-vous recommencer (O/N) ? ");
                    string reponse = Console.ReadLine();

                    if (reponse.ToUpper() == "N") {
                        restart = false;
                    }
                    else
                    {
                        Console.Clear();
                        Matrices = new int[nbJoueur, 8];
                        TabCroupier = new int[8];
                        nbTour = 0;
                    }
                    //fin

                    
                } while (restart);

            }


        }
        
        
        
    }
}