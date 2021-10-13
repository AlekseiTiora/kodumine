using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodumine
{
    class Alamprogramm
    {
        public static int Korruta(int arv1, int arv2)
        {
            return arv1 * arv2 / 2;
        }

        public static Double Eval(String expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            return Convert.ToDouble(table.Compute(expression, String.Empty));
        }



        public static void Main(string[] args)
        {
            /* Console.WriteLine(Korruta(2, 9));
             Double arv1 = 5;
             Double arv2 = 6;
             Double result = Eval(arv1.ToString()+"+"+arv2.ToString()) ;
             Console.WriteLine(result);*/

            Console.WriteLine("napishi 1 4islo");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("napishi 2 4islo");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"({a} + {b} / 2 = {Korruta(a, b)}");





            Console.ReadLine();
        }
    }
}
