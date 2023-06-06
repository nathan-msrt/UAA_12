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
            chiffreCouleur = "Valet de";
        }
        else if (chiffre == 12)
        {
            chiffreCouleur = "Reine de";
        }
        else if (chiffre == 13)
        {
            chiffreCouleur = "Roi de";
        }
        else
        {
            chiffreCouleur = chiffre.ToString();
        }
        if (couleur == 1)
        {
            chiffreCouleur += " Trefle Noir";
        }
        else if (couleur == 2)
        {
            chiffreCouleur += " Carreau Rouge";
        }
        else if (couleur == 3)
        {
            chiffreCouleur += " Pique Noir";
        }
        else
        {
            chiffreCouleur += " Coeur Rouge";
        }
    }

    public void tour1(int nbJoueur, out int chiffre, out int couleur, ref string pseudo, ref int nbTour, ref int[,] Matrices)
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
            if (i >= 1)
            {
                Console.WriteLine("Le Joueur n°" + i + " a reçu la carte : " + chiffreCouleur);
            }
            else
            {
                Console.WriteLine(pseudo + " vous avez reçu : " + chiffreCouleur);
            }

        }
    }
    public void tour2(int nbJoueur, out int chiffre, out int couleur, ref string pseudo, ref int nbTour, ref int[,] Matrices)
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
            if (i >= 1)
            {
                Console.WriteLine("Le Joueur n°" + i + " a reçu sa deuxième carte : " + chiffreCouleur);
            }
            else
            {
                Console.WriteLine(pseudo + " vous avez reçu votre deuxième carte : " + chiffreCouleur);
            }

        }
    }

    public void tour1Croupier(out int chiffre, out int couleur, ref int nbTour, ref int[] TabCroupier)
    {
        chiffre = 0;
        couleur = 0;
        string chiffreCouleur;


        aleacarte(out chiffreCouleur, out chiffre, out couleur);
        if (chiffre > 10)
        {
            TabCroupier[nbTour] = 10;
        }
        else
        {
            TabCroupier[nbTour] = chiffre;
        }
        Console.WriteLine("Le croupier a reçu : " + chiffreCouleur);
        Console.WriteLine("");
        nbTour += 1;
    }
    public void tour2Croupier(out int chiffre, out int couleur, ref int nbTour, ref int[] TabCroupier)
    {
        chiffre = 0;
        couleur = 0;
        string chiffreCouleur;


        aleacarte(out chiffreCouleur, out chiffre, out couleur);
        if (chiffre > 10)
        {
            TabCroupier[nbTour] = 10;
        }
        else
        {
            TabCroupier[nbTour] = chiffre;
        }
        Console.WriteLine("Le croupier a reçu sa deuxième carte : " + chiffreCouleur);
        Console.WriteLine("");
        nbTour += 1;
    }
   /* public void repiocheCarteCroupierNON(out int chiffre, out int couleur, ref int nbTour, ref int[] TabCroupier)
    {
        chiffre = 0;
        couleur = 0;
        string chiffreCouleur;


        aleacarte(out chiffreCouleur, out chiffre, out couleur);
        if (chiffre > 10)
        {
            TabCroupier[nbTour] = 10;
        }
        else
        {
            TabCroupier[nbTour] = chiffre;
        }
        Console.WriteLine("De son côté le croupier a pioché : " + chiffreCouleur);
        Console.WriteLine("");
        nbTour += 1;
    }*/
    public void repiocheCarteCroupier(out int chiffre, out int couleur, ref int nbTour, ref int[] TabCroupier)
    {
        chiffre = 0;
        couleur = 0;
        string chiffreCouleur;


        aleacarte(out chiffreCouleur, out chiffre, out couleur);
        if (chiffre > 10)
        {
            TabCroupier[nbTour] = 10;
        }
        else
        {
            TabCroupier[nbTour] = chiffre;
        }
        Console.WriteLine("De son côté le croupier a pioché : " + chiffreCouleur);
        Console.WriteLine("");
        nbTour += 1;
    }
    public void repiocheCartePseudo(out int chiffre, out int couleur, ref string pseudo, ref int nbTour, ref int[,] Matrices)
    {
        chiffre = 0;
        couleur = 0;
        string chiffreCouleur;


        aleacarte(out chiffreCouleur, out chiffre, out couleur);
        if (chiffre > 10)
        {
            Matrices[0, nbTour] = 10;
        }
        else
        {
            Matrices[0, nbTour] = chiffre;
        }
        Console.WriteLine(pseudo + " vous avez reçu une autre carte : " + chiffreCouleur);
        Console.WriteLine("");
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

    public void SommeCroupier(int[] TabCroupier, int croupier, out int sommeCroupier)
    {
        sommeCroupier = 0;
        for (int i = 0; i < TabCroupier.Length; i++)
        {
            sommeCroupier += TabCroupier[i];
        }
    }
    public void VerifPoints(ref int nbTour, ref int sommePseudo, ref int sommeCroupier)
    {
        if (sommeCroupier > sommePseudo)
        {
            Console.WriteLine("Vous avez perdu avec " + sommePseudo + " points contre " + sommeCroupier + " points du croupier. Le Croupier gagne la partie.");
        }
        else if (sommePseudo == 21 && nbTour == 1)
        {
            Console.WriteLine("Vous avez gagnez avec un BlackJack vous avez couché le croupier");
        }
        else if (sommeCroupier == sommePseudo)
        {
            Console.WriteLine("Vous avez egalité avec le Croupier ( " + sommeCroupier + " )");
        }
        else if (sommeCroupier < sommePseudo)
        {
            Console.WriteLine("Vous avez gagnez avec " + sommePseudo + " points contre " + sommeCroupier + " points du croupier");
        }
        else if (sommeCroupier > 21 && sommePseudo <= 21)
        {
            Console.WriteLine("Vous avez gagnez avec " + sommePseudo + " points contre " + sommeCroupier + " points du croupier. Le Croupier a dépassé 21");
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


