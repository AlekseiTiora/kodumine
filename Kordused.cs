using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodumine
{
    class Kordused
    {
        static void Main(string[] argumendid)
        {



            /* Random rnd = new Random();

             int A = rnd.Next(1, 10);//переменная для компа
             int AA;//kasutaja arv
             int K = 0;//katsed
             do
             {
                 Console.WriteLine("{0} Popitka. kakoe 4islo?",K);
                 AA = int.Parse(Console.ReadLine());
                 K++;
             } while (AA!=A && K!=6);

             if (AA==A)
             {
                 Console.WriteLine("Molodec ti ugodal 4islo. komputer zagadal 4islo {0}",A);
             }

             else
             {
                 Console.WriteLine("ti ne ugodal probui eshe");
             }*/

            /*int ridadearv = 10, veergudearv = 10;
            if(argumendid.Length == 2)
            {
                ridadearv = int.Parse(argumendid[0]);
            }
            for (int rida = 1; rida <=ridadearv; rida++)
            {
                for(int veerg = 1; veerg <= veergudearv; veerg++)
                {
                    Console.Write("{0,5}", rida * veerg); //5kohta
                }
                Console.WriteLine();
            }*/

            int arv;
            int[] arvud = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Sisesta {0} arv", i + 1);
                arv = int.Parse(Console.ReadLine());
                arvud[i] = arv;
            }
            Array.Sort(arvud);

            int arv4 = 0;
            Array.Reverse(arvud);
            foreach(var a in arvud)
            {
                arv4 = arv4 * 10 + a;
            }
            Console.Write(arv4);








            Console.ReadLine();
        }
    }
}


