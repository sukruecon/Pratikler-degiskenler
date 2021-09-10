using System;

namespace degisken
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string str1 = "15";
            int sayı2 = 32;

            string yeniDeger = str1 + sayı2.ToString();

            Console.WriteLine(yeniDeger);

            int sayı3 = sayı2 + Convert.ToInt32(str1);

            Console.WriteLine(sayı3);

            int sayı4 = sayı2 + int.Parse(str1);
            Console.WriteLine(sayı4);

            string datetime = DateTime.Now.ToString("dd/MM/yy");
            Console.WriteLine(datetime);

            string saat = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(saat);            

        }
    }
}
