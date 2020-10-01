using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CA201001
{
    class Program
    {
        static Random rnd = new Random();
        static readonly string name = "Kiss Bence";
        static void Main(string[] args)
        {
            //nev10
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(name);
            }

            //ismetlesN
            Console.Write("\nAdjon meg egy számot: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adjon meg egy szöveget: ");
            string txt = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{txt} ");
            }

            Console.ReadKey();

            //visszaszamol
            /*for (int i = 10; i > 0; i--)
            {
                Console.Clear();
                Console.WriteLine($"{i}...");
                Thread.Sleep(1000);
            }*/
            //Environment.Exit(0);
            //bezáródáshoz a felső utasítást uncommentelni kell, azért raktam így, mert kifejezetten előnytelen ha bezáródik már a 3. feladatnál

            //nev_mozog
            /*for (int i = 0; i < Console.WindowWidth - name.Length; i++)
            {
                Console.Clear();
                Console.SetCursorPosition(i, 0);
                Console.Write(name);
                Thread.Sleep(50);
            }
            Console.ReadKey();*/

            //randomcsillag
            Console.Clear();
            for (int i = 0; i < 200; i++)
            {
                Console.SetCursorPosition(rnd.Next(Console.WindowWidth), rnd.Next(Console.WindowHeight));
                Console.Write("*");
            }
            Console.ReadKey();

            //randomszin
            Console.Clear();
            for (int i = 0; i < 200; i++)
            {
                Console.SetCursorPosition(rnd.Next(Console.WindowWidth), rnd.Next(Console.WindowHeight));
                Console.ForegroundColor = (ConsoleColor)rnd.Next(0, 16);
                Console.Write("*");
            }
            Console.ReadKey();

            //negyzetszamok
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i <= 30; i++)
            {
                Console.WriteLine($"{i} négyzete: {i * i}");
            }
            Console.ReadKey();

            //2hatvanyok
            Console.Clear();
            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine($"A 2 {i}. hatványa: {Math.Pow(2, i)}");
            }
            Console.ReadKey();

            //paratlan
            Console.Clear();
            Console.WriteLine("100-nál nem nagyobb páratlan számok:");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0) Console.WriteLine(i);
            }
            Console.ReadKey();

            //paratlan2
            Console.Clear();
            Console.WriteLine("100-nál nem nagyobb páratlan számok csökkenő sorrendben:");
            for (int i = 100; i >= 1; i--)
            {
                if (i % 2 != 0) Console.WriteLine(i);
            }
            Console.ReadKey();

            //szamtanisor1
            Console.Clear();
            Console.WriteLine("Első számtani sor:");
            n = 10;
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"{i+1}. elem: {n}");
                n += 7;
            }

            //szamtanisor2
            Console.Write("\nAdja meg az első tagot: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg a differenciáját: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Második számtani sor:");
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"{i + 1}. elem: {n}");
                n += d;
            }

            //szamtanisor3
            Console.Write("\nAdja meg a sorozat egy tagját: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg a sorozat következő tagját: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Harmadik számtani sor:");
            d = b - a;
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine($"{a - (d * i)}");
            }
            Console.WriteLine($"{a}\n{b}");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{b + (d * i)}");
            }
            Console.ReadKey();

            //homerseklet_atvaltas
            Console.Clear();
            for (int i = -30; i <= 30; i++)
            {
                Console.WriteLine($"{i}°C = {i * 1.8 + 32}°F");
            }
            Console.ReadKey();

            //ketjegyu3
            Console.Clear();
            Console.WriteLine("Hárommal osztható kétjegyű számok:");
            for (int i = 10; i < 100; i++)
            {
                if (i % 3 == 0) Console.WriteLine(i);
            }
            Console.ReadKey();

            //osztok
            Console.Clear();
            Console.Write("Adjon meg egy pozitív számot: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{n} osztói:");
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) Console.WriteLine(i);
            }
            Console.ReadKey();

            //prim_teszt
            Console.Clear();
            Console.Write("Adjon meg egy pozitív számot: ");
            n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) count++;
            }
            if (count == 2) Console.WriteLine("Prímszám");
            else Console.WriteLine("Nem prímszám");
            Console.ReadKey();

            //lnko
            Console.Clear();
            Console.Write("Adjon meg egy számot: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adjon meg egy másik számot: ");
            b = Convert.ToInt32(Console.ReadLine());
            int index = a > b ? a : b;
            int lnko = 1;
            for (int i = 1; i < index; i++)
            {
                if (a % i == 0 && b % i == 0) lnko = i;
            }
            Console.WriteLine($"Lnko: {lnko}");
            Console.ReadKey();

            //szim3jegyu
            Console.Clear();
            Console.WriteLine("Háromjegyű számok, amelynek az első és utolsó számjegye egyforma:");
            for (int i = 100; i < 1000; i++)
            {
                if (Convert.ToString(i)[0] == Convert.ToString(i)[2]) Console.WriteLine(i);
            }
            Console.ReadLine();

            //fibonacci
            Console.Clear();
            Console.WriteLine("Első 10 fibonacci szám:");
            a = 1;
            b = 1;
            Console.WriteLine($"{a}\n{b}");
            int c;
            for (int i = 0; i < 8; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(b);
            }




            Console.ReadKey();
        }
    }
}
