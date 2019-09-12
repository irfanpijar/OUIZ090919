using System;

namespace quiz_09092019
{
    class BangunRuang
    {
        public static void volumeBalok()
        {
            Console.WriteLine("Menghitung Volume Balok");
            
            int panjang, lebar, tinggi, volume;

            Console.Write("Panjangnya berapa nak? ");
            panjang = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lebarnya berapa nak? ");
            lebar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tingginya berapa nak? ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            volume = panjang * lebar * tinggi ;

            Console.WriteLine("Ta-Daa! Volume Balok adalah "+volume);
        }

        //Volume Kubus
        public static void volumeKubus()
        {
            Console.WriteLine("Menghitung Volume Kubus"); //Text

            //Variable
            int sisi, volume;

            //Input
            Console.Write("Sisinya berapa nak? "); 
            sisi = Convert.ToInt32(Console.ReadLine());

            //Processing
            volume = sisi * sisi * sisi ;

            //Output
            Console.WriteLine("Ta-Daa! Volume Kubus adalah "+volume);
        }
    }
}
