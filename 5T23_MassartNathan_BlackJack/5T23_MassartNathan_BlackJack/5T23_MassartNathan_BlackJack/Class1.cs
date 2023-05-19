using System;
using System.Collections.Generic;
using System.Text;


   public struct Traitement
   {
        public void aleacarte(out string chiffreCouleur, out int chiffre, out int couleur)
        {
            chiffreCouleur = "";
            Random alea = new Random();

            chiffre = alea.Next(1, 14);
            couleur = alea.Next(1, 5);

            if (chiffre == 11)
            {
                chiffreCouleur = "valet de";
            }
            else if (chiffre == 12)
            {
                chiffreCouleur = "reine de";
            }
            else if (chiffre == 13)
            {
                chiffreCouleur = "roi de";
            }
            else
            {
                chiffreCouleur = chiffre.ToString();
            }
            if (couleur == 1)
            {
                chiffreCouleur += " trefle noir";
            }
            else if (couleur == 2)
            {
                chiffreCouleur += " carreau rouge";
            }
            else if (couleur == 3)
            {
                chiffreCouleur += " pique noir";
            }
            else
            {
                chiffreCouleur += " coeur rouge";
            }
        }

        public void tour1(int nbJoueur, out int chiffre, out int couleur, ref int nbTour, ref int[,] Matrices)
        {
            chiffre = 0;
            couleur = 0;
            string chiffreCouleur;
            for (int i = 0; i < nbJoueur; i++)
            {
                aleacarte(out chiffreCouleur, out chiffre, out couleur);
                if (chiffre > 10)
                {
                    Matrices[i, nbTour] = 10;
                }
                else
                {
                    Matrices[i, nbTour] = chiffre;
                }
                Console.WriteLine(chiffreCouleur);


            }
            nbTour += 1;
        }

        public void tour1Croupier( out int chiffre, out int couleur, ref int nbTour, ref int[,] TabCroupier)
        {
            chiffre = 0;
            couleur = 0;
            string chiffreCouleur;
            for (int i = 0; i <= 1 ; i++)
            {
                aleacarte(out chiffreCouleur, out chiffre, out couleur);
                if (chiffre > 10)
                {
                    TabCroupier[i, nbTour] = 10;
                }
                else
                {
                    TabCroupier[i, nbTour] = chiffre;
                }
                Console.WriteLine(chiffreCouleur);


            }
            nbTour += 1;
        }

        public void SommeJoueur(int[,] Matrices, int numeroJoueur, out int somme)
        {
                somme = 0;
                for (int i = 0; i < Matrices.GetLength(1); i++)
                {
                    somme += Matrices[numeroJoueur, i];
                }
        }
        public void LectureR(string question, out int n)
        {
            string nbJoueur;
            Console.Write(question);
            nbJoueur = Console.ReadLine();
            while (!int.TryParse(nbJoueur, out n))
            {

                Console.WriteLine("Attention ! Vous devez taper un nombre réel !");
                nbJoueur = Console.ReadLine();
            }
        }
   }


