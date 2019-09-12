using System;

namespace quiz_09092019
{
    class Program
    {
        static void Main(string[] args)
        {

            BangunDatar daftar = new BangunDatar();

            BangunDatar.luasPersegi();

            Console.WriteLine("=============================");

            BangunDatar.luasSegitiga();

            Console.WriteLine("=============================");

            BangunDatar.luasLingkaran();
        }
    }
}
