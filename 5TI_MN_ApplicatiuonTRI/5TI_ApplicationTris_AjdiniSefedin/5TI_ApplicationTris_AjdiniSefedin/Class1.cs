using System;
using System.Diagnostics;
using System.Threading;

namespace traitTableaux
{
    class Program
    {
        static void Main(string[] args)
        {
            outils mesOutils = new outils();
            int choix;
            int[] tableau;
            int min;
            int max;
            int nombre;
            string aff;
            string recommencer;

            do
            {

                Console.WriteLine("                             --------------------------------------------------                    ");
                Console.WriteLine("                             Bienvenue dans ce programme de tris de tableaux !");
                Console.WriteLine("                             --------------------------------------------------                    ");
                Console.WriteLine("                                                                                                   ");
                Console.WriteLine("                                                                                                   ");
                Console.WriteLine("                                                                                                   ");
                mesOutils.LireReel("Choississez le tri que vous preferez ! \n   1 = tri a bulle  \n   2 = tri insertion \n   3 = tri intuitif \n   4 = tri selection \n   5 = tri shell \n", out choix);
                mesOutils.LireReel("nombre de place dans le tableau\n", out nombre);
                mesOutils.LireReel("minimum\n", out min);
                mesOutils.LireReel("maximum\n", out max);
                mesOutils.creationAleatoire(nombre, max, min, out tableau);

                
            

            if (choix == 1)

            {
                mesOutils.Tri_bulle(ref tableau);
                mesOutils.affichage(tableau, out aff);
                Console.WriteLine(aff);

                long écoulé = Tester(n => Thread.Sleep(n), 500);
                Console.WriteLine($"Exécution en {écoulé} ms");

                static long Tester<T>(Action<T> a, T arg)
                {
                    var sw = new Stopwatch();
                    sw.Start();
                    a(arg);
                    sw.Stop();
                    return sw.ElapsedMilliseconds;
                }


            }
            if (choix == 2)

            {
                mesOutils.Tri_insertion(ref tableau);
                mesOutils.affichage(tableau, out aff);
                Console.WriteLine(aff);

                long écoulé = Tester(n => Thread.Sleep(n), 500);
                Console.WriteLine($"L'Execution a été fait en {écoulé} ms");

                static long Tester<T>(Action<T> a, T arg)
                {
                    var sw = new Stopwatch();
                    sw.Start();
                    a(arg);
                    sw.Stop();
                    return sw.ElapsedMilliseconds;
                }
            }
            if (choix == 3)

            {
                mesOutils.Tri_intuitif(ref tableau);
                mesOutils.affichage(tableau, out aff);
                Console.WriteLine(aff);

                long écoulé = Tester(n => Thread.Sleep(n), 500);
                Console.WriteLine($"L'Execution a été fait en {écoulé} ms");

                static long Tester<T>(Action<T> a, T arg)
                {
                    var sw = new Stopwatch();
                    sw.Start();
                    a(arg);
                    sw.Stop();
                    return sw.ElapsedMilliseconds;
                }
            }
            if (choix == 4)

            {
                mesOutils.Tri_selection(ref tableau);
                mesOutils.affichage(tableau, out aff);
                Console.WriteLine(aff);

                long écoulé = Tester(n => Thread.Sleep(n), 500);
                Console.WriteLine($"L'Execution a été fait en {écoulé} ms");

                static long Tester<T>(Action<T> a, T arg)
                {
                    var sw = new Stopwatch();
                    sw.Start();
                    a(arg);
                    sw.Stop();
                    return sw.ElapsedMilliseconds;
                }
            }
            if (choix == 5)

            {
                mesOutils.Tri_shell(ref tableau);
                mesOutils.affichage(tableau, out aff);
                Console.WriteLine(aff);

                long écoulé = Tester(n => Thread.Sleep(n), 500);
                Console.WriteLine($"L'Execution a été fait en {écoulé} ms");

                static long Tester<T>(Action<T> a, T arg)
                {
                    var sw = new Stopwatch();
                    sw.Start();
                    a(arg);
                    sw.Stop();
                    return sw.ElapsedMilliseconds;
                }
            }
                Console.WriteLine("Voulez-vous recommencer ? oui / non");
                recommencer = Console.ReadLine();

            } while (recommencer == "oui");
        }
    }
}
