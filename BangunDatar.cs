using System;

namespace quiz_09092019
{
    class BangunDatar
    {
        public static void luasPersegi()
        {
            Console.WriteLine("Menghitung Luas Persegi");

            Console.WriteLine("=============================");
            
            int sisi, luas;

            Console.Write("Sisinya berapa nak? ");
            sisi = Convert.ToInt32(Console.ReadLine());

            luas = sisi * sisi;

            Console.WriteLine("Ta-Daa! Luas Persegi adalah "+luas);
        }

        public static void luasSegitiga()
        {
            Console.WriteLine("Menghitung Luas Segitiga");

            Console.WriteLine("=============================");

            int alas, tinggi;
            double luas, half;
            half=0.5;

            Console.Write("Alasnya berapa nak? ");

            alas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tingginya berapa nak? ");

            tinggi = Convert.ToInt32(Console.ReadLine());

            luas = half * alas * tinggi;

            Console.WriteLine("Ta-Daa! Luas Segitiga adalah "+luas);
        }

            //luas lingkaran
        public static void luasLingkaran()
        {
            Console.WriteLine("Menghitung Luas Lingkaran");

            Console.WriteLine("=============================");

            int jari;
            double luas;
            double phi;
            phi=3.14;

            Console.Write("Jari-jarinya berapa nak? ");
            jari = Convert.ToInt32(Console.ReadLine());

            luas = phi * jari * jari;

            Console.WriteLine("Ta-Daa! Luas Lingkaran adalah "+luas);
        }
    }
}
