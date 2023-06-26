using System;
using System.Collections.Generic;
using System.Text;

public struct Traitement
{

    public void CryptVinegere(string phClaire, string phClef, out string[,] MatVinegere)
    {
        MatVinegere = new string[4, phClaire.Length]; //création de matrice a 4 entré
        int j = 0;
        for (int i = 0; i <= phClaire.Length - 1; i++)
        {
            MatVinegere[0, i] = phClaire[i].ToString();
            if (j == phClef.Length) //pour repeter le mot clefs
            {
                j = 0;
            }
            MatVinegere[1, i] = phClef[j].ToString();
            MatVinegere[2, i] = ((int)phClef[j] - 65).ToString();

            MatVinegere[3, i] = Convert.ToChar((int)phClaire[i] + (int)phClef[j] - 65).ToString();
            j = j + 1;
        }
    }
    public void CryptAffine(string phClaire, int a , int b , out string[,]MatAffine)
    {
        int x = 0;
        int y = 0;
        MatAffine = new string [4, phClaire.Length];
        for (int i = 0; i <= phClaire.Length -1  ; i++)
        {
            MatAffine[0, i] = phClaire[i].ToString().ToUpper();
            x = ((int)phClaire[i] - 65);
            MatAffine[1, i] = x.ToString();
            y = (a * x + b) % 26;
            MatAffine[2, i] = y.ToString();
            MatAffine[3, i] = Convert.ToChar(y + 65).ToString();
        }
    }
    public void RetireEspaces(string phCLaire, out string phClaireSSE)
    {
        int i;
        int Ig;
        phClaireSSE = "";
        Ig = phCLaire.Length;
        for (i = 0; i < Ig; i++)
        {
            if (phCLaire[i] != ' ')
            {
                phClaireSSE += phCLaire[i];
            }
        }
    }
    public void ConcatenerMatrice(string[,] matrice, out string resultat)
    {
        resultat = "";
        for (int l = 0; l <= matrice.GetLength(0) - 1; l++) //l = Ligne en cours de traitement (s’incrémente dans une boucle)
        {
            for (int c = 0; c <= matrice.GetLength(1) - 1; c++) // c = Colonne en cours de traitement (s’incrémente dans une boucle)
            {
                resultat = resultat + matrice[l, c] + " ";
            }
            resultat = resultat + "\n";
        }
    }
    public void ConcateneDerniereLigne(string[,] matrice, out string resultat)
    {
        resultat = "";
            for (int c = 0; c <= matrice.GetLength(1) - 1; c++) // c = Colonne en cours de traitement (s’incrémente dans une boucle)
            {
                resultat = resultat + matrice[3, c] + " ";
            }
    }

    public void VerifierCle(string cle, out bool ok)
    {
        ok = true;
        foreach (char c in cle)
        {
            if (!char.IsLetter(c))
            {
                Console.WriteLine("Clé invalide. Veuillez entrer une clé contenant uniquement des caractères alphabétiques.");
                ok = false;
                return;
            }
        }

    }
    public void LectureR(string question, out int n)
    {
        string nUser;
        Console.Write(question);
        nUser = Console.ReadLine();
        while (!int.TryParse(nUser, out n))
        {

            Console.WriteLine("Attention ! Vous devez taper un nombre réel !");
            nUser = Console.ReadLine();
        }
    }
}
