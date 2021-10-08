using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodumine
{
    class Kordused
    {
        static void Main(string[] args)
        {

            /*string[] nimed = new string[8] { "Aleksei", "Nikita", " Maksim", "Erik", "Artem", "Andrei", "Ilja", "Kolja" };
            nimed[2] = "BOBA";
            int nr = 0;
            while (nr < 8)
            {
                Console.WriteLine("Tere,{0} õpilane", nimed[nr]);
                nr = nr + 1;
            }
            Console.WriteLine();
            for (int i = 0; i < nimed.Length; i++)
            {
                Console.WriteLine("Tere,{0} õpilane", nimed[i]);
            }
            Console.WriteLine();
            foreach (var nimi in nimed)
            {
                Console.WriteLine("Tere,{0} õpilane", nimi);
            }
            Console.WriteLine();
            nr = 0;
            do
            {
                Console.WriteLine("Tere,{0} õpilane", nimed[nr]);
                nr++;
            } while (nr!=nimed.Length) ;*/

             Random rnd = new Random();
             int N = rnd.Next(2, 6);
             int M = rnd.Next(7, 14);
             int [] mass  = new int[M - N];
            Console.WriteLine(N);
            Console.WriteLine(M);
            int j = 0;
            for (int i = N; i < M+1; i++)
            {
                Console.Write(i - N);
                Console.ReadLine();
                mass[j] = i;
                Console.WriteLine("{0}",i*i);
                j++;
            }
            foreach (var m in mass)
            {
                Console.WriteLine(m);
            }

            Console.WriteLine("kirjutage 5 numbrit");
            Console.ReadKey();



            Console.ReadLine();
        }
    }
}


