using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodumine
{
    class startklass
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello!");
            //string eesnimi = Console.ReadLine();
            //Console.WriteLine("Hello, " + eesnimi);
            // if (eesnimi.ToLower() =="juku")
            //{
            //   Console.WriteLine("Tule minu juurde külla! Lähme kinno kui vana sa oled?");

            //  int aasta =int.Parse(Console.ReadLine());

            //  if (aasta < 0 || aasta >= 120)
            // {
            //  Console.WriteLine("Viga andmetega");
            // }

            // else if (aasta < 6)
            // {
            //  Console.WriteLine("sulle on Tasuta");
            // }

            //else if (aasta <=14 && aasta >=6)
            // {
            //  Console.WriteLine("sa pead osta lastepilet");
            // }

            // else if (aasta <=64 && aasta >= 15)
            // {
            //    Console.WriteLine("sa pead osta täispilet");
            // }

            // else if (aasta >= 65 && aasta <= 100)
            // {
            //     Console.WriteLine("sa pead osta Sooduspilet");
            // }
            // }

            // else
            // {
            //Console.WriteLine("Täna mind kodus pole!");
            // }

           // Console.WriteLine("Tere, Mis teie nimid on?");
           // string nimi = Console.ReadLine();
           // string nimi2 = Console.ReadLine();
            
            

           // if(nimi.ToLower() =="maksim" && nimi2.ToLower() == "erik" || nimi2.ToLower() == "maksim" && nimi.ToLower() == "erik")
           // {
           //     Console.WriteLine("Mida sa tahtsid?");
           //     Console.WriteLine("{0} ja {1} Ma tahtsin teile öelda et ma olen täna teie pinginaaber", nimi, nimi2);
           // }

           // else
          //  {
          //      Console.WriteLine("Te ei ole minu pinginaabrid");
           // }


           // Console.WriteLine("kui pikk on ristkülikukujulise ruumi sein?");

           // Console.WriteLine("Esimine sein on:");
            //int cm1 = Math.Abs(int.Parse(Console.ReadLine()));
           // Console.WriteLine("Teine sein on:");
           // int cm2 = Math.Abs(int.Parse(Console.ReadLine()));

          //  Console.WriteLine("Põranda pindala");
          //  Console.WriteLine(cm1 * cm2 + " cm2");
          //  Console.WriteLine("Kas sa tahad remondi teha:");
          //  string otvet = Console.ReadLine();
           // if (otvet=="jah")
           // {
           //     Console.WriteLine("kui kallis suur ruut metr");
           //     decimal hind = decimal.Parse(Console.ReadLine());
           //     Console.WriteLine(Math.Round(hind * ((cm1/100) * (cm2/100)),2) + " summa");


          //  }
          //  else
          //  {
          //      Console.WriteLine("Head aega");
          //  }

          //  Console.WriteLine("kirjuta sum:");
          //  int arv= int.Parse(Console.ReadLine());
          //  if (arv >0)
          //  {
          //      int procent = (arv * 30 / 100);
          //      Console.WriteLine("S ={0}", arv - procent);
          //  }

            //Console.WriteLine("Kirjuta temperatuur");
            //decimal temp = decimal.Parse(Console.ReadLine());
            //    if (temp < 18 )
            //    {
            //    Console.WriteLine("See on väike temperatuur");
            //    }

            //    else if (temp > 18)
             //   {
             //   Console.WriteLine("See on suur temperatuur");
            //    }

            //    else if (temp == 18)
            //    {
            //    Console.WriteLine("See on normalne temperatuur");
            //    }


            Console.WriteLine("Kui pikk sa oled?");
            decimal pikk = decimal.Parse(Console.ReadLine());
                if ( pikk < 50 && pikk >300)
                {
                Console.WriteLine("error");
                }

                else if(pikk > 100 && pikk < 150)
                {
                Console.WriteLine("sina oled väike pikkus");
                }








            //int arv1 = int.Parse(Console.ReadLine());
            //int arv2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("arvude {0} ja {1} korrutis võrdub {2}",arv1,arv2,arv1*arv2);




            Console.ReadLine();
        }
    }
}

