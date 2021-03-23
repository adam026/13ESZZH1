using System;
using System.Text;
using System.Linq;
using System.Threading;
using System.Collections.Generic;

namespace _13ESZZH1
{
    class Program
    {
        static Random rnd = new Random();

        static void Main()
        {
            //BudapestenAt();
            //RndHely();
            //Legnagyobb();
            //Leghosszabb();
            //Sorbaba();
            //Osztalyzo();
            Szokasos();
            Console.ReadKey();
        }

        private static void BudapestenAt()
        {
            Console.Write("Kérem az 1. település nevét: ");
            string elsotelepules = Console.ReadLine();
            Console.Write("Kérem az 1. település Budapesttől való távolságát km-ben: ");
            int elsotelepules_km = int.Parse(Console.ReadLine());

            Console.Write("Kérem a 2. település nevét: ");
            string masodiktelepules = Console.ReadLine();
            Console.Write("Kérem a 2. település Budapesttől való távolságát km-ben: ");
            int masodiktelepules_km = int.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"{elsotelepules}-ből {masodiktelepules}-be Budapesten keresztül {elsotelepules_km + masodiktelepules_km} km-t kell megtenni");
        }

        private static void RndHely()
        {
            Console.WriteLine("Kérek egy tetszőleges szöveget: ");
            string szoveg = Console.ReadLine();
            Console.Clear();

            int szelesseg = Console.WindowWidth;
            int magassag = Console.WindowHeight;

            for (int i = 0; i < szoveg.Length; i++)
            {
                int balrol = rnd.Next(szelesseg - szoveg.Length);
                int fentrol = rnd.Next(magassag);

                Console.SetCursorPosition(balrol, fentrol);

                Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);

                Console.WriteLine(szoveg[i]);
                Thread.Sleep(200);

            }
        }

        private static void Legnagyobb()
        {
            int[] T1 = new int[5];
            int[] T2 = new int[5];
            int[] T3 = new int[5];

            for (int i = 0; i < T1.Length; i++)
            {
                T1[i] = rnd.Next(1, 1000);
                T2[i] = rnd.Next(1, 1000);
                T3[i] = rnd.Next(1, 1000);
            }

            int osszeg1 = 0;
            int osszeg2 = 0;
            int osszeg3 = 0;

            for (int i = 0; i < T1.Length; i++)
            {
                osszeg1 += T1[i];
                osszeg2 += T2[i];
                osszeg3 += T3[i];
            }

            List<int> osszegek = new List<int>();
            osszegek.Add(osszeg1);
            osszegek.Add(osszeg2);
            osszegek.Add(osszeg3);

            
            int maxi = osszegek[0];
            int maxindex = 1;

            for (int i = 0; i < osszegek.Count(); i++)
            {
                if (osszegek[i] > maxi)
                {
                    maxi = osszegek[i];
                    maxindex = i + 1;
                }
            }
            

            for (int i = 0; i < T1.Length; i++)
            {
                Console.Write($"{T1[i]}, "); 
            }
            Console.WriteLine($"Összeg: {osszeg1}");

            Console.WriteLine("----------------------------------------");

            for (int i = 0; i < T2.Length; i++)
            {
                Console.Write($"{T2[i]}, ");
            }

            Console.WriteLine($"Összeg: {osszeg2}");

            Console.WriteLine("----------------------------------------");

            for (int i = 0; i < T3.Length; i++)
            {
                Console.Write($"{T3[i]}, ");
            }

            Console.WriteLine($"Összeg: {osszeg3}");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine($"Az elemek összege a T{maxindex} tömbben a legnagyobb");
        }

        private static void Leghosszabb()
        {

            List<string> szavak = new List<string>();
            Console.Write("Kérem az első szót: ");
            string szo1 = Console.ReadLine();
            szavak.Add(szo1);

            Console.Write("Kérem a második szót: ");
            string szo2 = Console.ReadLine();
            szavak.Add(szo2);

            Console.Write("Kérem a harmadik szót: ");
            string szo3 = Console.ReadLine();
            szavak.Add(szo3);

            string maxi = szavak[0];

            for (int i = 0; i < szavak.Count(); i++)
            {
                if (szavak[i].Length > maxi.Length)
                {
                    maxi = szavak[i];
                }
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine($"A 3 szó közül a(z) {maxi} a leghoszabb!");
 
        }

        private static void Sorbaba()
        {
            Console.WriteLine("Te hány magyart hoztál a világra? ");
            int magyar = int.Parse(Console.ReadLine());
            string[] nev = new string[magyar];
            int[] kor = new int[magyar];
            for (int i = 0; i < magyar; i++)
            {
                Console.Write($"{i + 1} gyermek neve: ");
                string aktualisnev = Console.ReadLine();
                nev[i] = aktualisnev;

                Console.Write($"{i + 1} gyermek életkora: ");
                int aktualiskor = int.Parse(Console.ReadLine());
                kor[i] = aktualiskor;
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Eredeti sorrend: ");
            for (int i = 0; i < nev.Length; i++)
            {
                Console.Write($"{nev[i]}, ");
            }

            Console.WriteLine("\n\n");

            for (int i = 0; i < kor.Length; i++)
            {
                Console.Write($"{kor[i]}, ");
            }

            Array.Sort(kor, nev);

            Console.WriteLine("\n\n");

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Rendezés utáni sorrend: ");
            for (int i = 0; i < nev.Length; i++)
            {
                Console.Write($"{nev[i]}, ");
            }

            Console.WriteLine("\n\n");

            for (int i = 0; i < kor.Length; i++)
            {
                Console.Write($"{kor[i]}, ");
            }

        }

        private static void Osztalyzo()
        {
            Console.Write("Kérem a dolgozat százalékos eredményét: ");
            int szazalek = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------------");
            Console.Write("Érdemjegy: ");

            if (szazalek > 0 && szazalek < 50) Console.Write("1.");
            else if (szazalek >= 50 && szazalek < 60) Console.Write("2.");
            else if (szazalek >= 60 && szazalek < 80) Console.Write("3.");
            else if (szazalek >= 80 && szazalek < 90) Console.Write("4.");
            else if (szazalek >= 90 && szazalek <= 100) Console.Write("5.");
            else Console.WriteLine("Nem megfelelő százalékos eredményt adtál meg! Az érték 0 és 100 % közt kell hogy legyen!");

        }

        private static void Szokasos()
        {
            Console.WriteLine("1-2. Feladat");
            Console.WriteLine("\n");
            int[] haromjegyu = new int[20];

            for (int i = 0; i < 20; i++)
            {
                int szam = 0;
                do
                {
                    int generaltszam = rnd.Next(100, 1000);
                    szam = generaltszam;
                    
                } while (szam % 3 != 0);

                haromjegyu[i] = szam;
            
            }

            for (int i = 0; i < haromjegyu.Length; i++)
            {
                Console.Write($"{haromjegyu[i]}, ");
                if ((i + 1) % 5 == 0)
                {
                    Console.Write("\n");
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("3. Feladat");

            int osszeg = 0;

            for (int i = 0; i < haromjegyu.Length; i++)
            {
                osszeg += haromjegyu[i];
            }

            Console.WriteLine($"A tömb elemeinek átlaga: {osszeg / (float)haromjegyu.Length}");

            Console.WriteLine("\n");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("4. Feladat");

            int mini = haromjegyu[0];

            for (int i = 0; i < haromjegyu.Length; i++)
            {
                if (haromjegyu[i] < mini)
                {
                    mini = haromjegyu[i];
                }
            }

            int maxi = haromjegyu[0];

            for (int i = 0; i < haromjegyu.Length; i++)
            {
                if (haromjegyu[i] > maxi)
                {
                    maxi = haromjegyu[i];
                }
            }

            Console.WriteLine($"A tömb legkisebb eleme: {mini}.\nA tömb legnagyobb eleme: {maxi}.\nEzek különbsége: {maxi - mini}");

            Console.WriteLine("\n");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("5. Feladat");

            List<int> paratlan = new List<int>();

            for (int i = 0; i < haromjegyu.Length; i++)
            {
                if (haromjegyu[i] % 2 != 0)
                {
                    paratlan.Add(i);
                }
            }

            Console.WriteLine("A tömb páratlan elemei: ");

            for (int i = 0; i < paratlan.Count; i++)
            {
                Console.Write($"{paratlan[i]}, ");
            }

            paratlan.Reverse();
            Console.WriteLine("\n");
            Console.WriteLine("A tömb páratlan elemei csökkenő sorrendben: ");

            for (int i = 0; i < paratlan.Count; i++)
            {
                Console.Write($"{paratlan[i]}, ");
            }

            Console.WriteLine("\n");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("6. Feladat");
            int nagyobbmint800 = 0;
            int oszthatoottel = 0;
            int otszazalatt = 0;

            for (int i = 0; i < haromjegyu.Length; i++)
            {
                if (haromjegyu[i] > 800) nagyobbmint800++;
                if (haromjegyu[i] % 5 == 0) oszthatoottel++;
                if (haromjegyu[i] < 500) otszazalatt++;
            }

            if (nagyobbmint800 > 0)
            {
                Console.WriteLine("A tömb minimum egy eleme nagyobb mint 800!");
            }
            else Console.WriteLine("A tömbnek nincs olyan eleme ami nagyobb mint 800!");

            Console.WriteLine("A tömb minden elemének van 1 osztója, saját maga :D");

            if (oszthatoottel > 3)
            {
                Console.WriteLine("A tömbnek minimum 3 eleme van ami osztható öttel!");
            }
            else Console.WriteLine("A tömbnek nincs 3 eleme ami osztható öttel!");

            if ((otszazalatt / haromjegyu.Length) > 0.4)
            {
                Console.WriteLine("Az elemek minimum 40%-a 500 alatt van!");
            }
            else Console.WriteLine("Az elemeknek kevesebb mint 40%-a van csak 500 alatt!");
        }

    }
}
