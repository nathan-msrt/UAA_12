using System;
using System.Collections.Generic;
using System.Text;

public struct Traitement
{
    public void CryptVigenere(string phClaire, string phClef, out string[,]MatVigenere)
    {
        phClaire = "";
        phClef = "";
        int codeAscii;
        MatVigenere = new string [4, phClaire.Length];
        int j = 0;
        for (int i = 0; i < phClaire.Length - 1; i++)
        {
            MatVigenere[0, 1] = phClaire[i];
            if (j == phClef.Length)
            {
                j = 0;
            }
            MatVigenere[1, i] =  phClef[j];
            MatVigenere[2, i] = (((int)phClef[j]) - 65).ToString();
            if ((int)phClaire[i] + int.Parse(MatVigenere[2, i])<= 90)
            {
                codeAscii = (int)char.Parse(MatVigenere[0, i]) + int.Parse(MatVigenere[2, i]);
            }
            else
            {
                codeAscii = (int)char.Parse(MatVigenere[0, i]) + int.Parse(MatVigenere[2, i]) - 26;
            }
            MatVigenere[3, i] = Convert.ToChar(codeAscii).ToString();
            j = j + 1;
        }

    }
    public void CryptAffine(string phClaire, int a , int b , out string[,]MatAffine)
    {
        a = 0;
        b = 0;
        int x = 0;
        int y = 0;
        MatAffine = new string [4, phClaire.Length];
        for (int i = 0; i < phClaire.Length -1  ; i++)
        {
            MatAffine[0, i] = phClaire[i];
            x = ((int)phClaire[i] - 65);
            MatAffine[1, i] = x;
            y = (a * x + b) % 26;
            MatAffine[2, i] = y;
            MatAffine[3, i] = y + 65;
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
    public void VerifierCle(string cle)
    {
        foreach (char c in cle)
        {
            if (!char.IsLetter(c))
            {
                Console.WriteLine("Clé invalide. Veuillez entrer une clé contenant uniquement des caractères alphabétiques.");
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
