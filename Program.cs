using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaString2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n -- Prvi zadatak --");

            string s1 = "Hrvatska ima more";
            string s2 = "Italija je prvak svijeta";
            string s3 = s1.Substring(0, 8) + s2.Substring(7);

            Console.WriteLine(s3);

            Console.WriteLine("\n -- Drugi zadatak --");

            Console.Write("Unesite niz znakova: ");
            string s4 = Console.ReadLine();

            Console.WriteLine(s4.Replace(' ', '_'));

            Console.WriteLine("\n -- Treci zadatak --");

            Console.Write("Unesite niz znakova: ");
            string s5 = Console.ReadLine();

            string sVelika = s5.ToUpper();
            string sMala = s5.ToLower();
            string sPrvaTri = s5.Substring(0, 3);
            string sZadnjihPet = s5.Substring(s5.Length - 5);
            string s8_11 = "";
            if (s5.Length >= 11)
            {
                s8_11 = s5.Substring(8, 4);
            }

            Console.WriteLine(sVelika);
            Console.WriteLine(sMala);
            Console.WriteLine(sPrvaTri);
            Console.WriteLine(sZadnjihPet);
            Console.WriteLine(s8_11);

            Console.WriteLine("\n -- Cetvrti zadatak --");

            Console.Write("Unesite neku recenicu: ");
            string s6 = Console.ReadLine();

            string[] s6Rijeci = s6.Split(' ');

            Console.WriteLine("Prva rijec: {0}", s6Rijeci[0]);
            Console.WriteLine("Zadnja rijec: {0}", s6Rijeci[s6Rijeci.Length - 1]);

            Console.WriteLine("\n -- Peti zadatak --");

            Console.WriteLine("Unesite jedan cijeli i jedan decimalni broj odvojene razmakom: ");

            string s7 = Console.ReadLine();

            string[] s8 = s7.Split(' ');
            string x = s8[0];
            string y = s8[1];

            Console.WriteLine("Prvi broj: {0} \nDrugi broj: {1}", x, y);

            Console.ReadKey();
        }
    }
}
