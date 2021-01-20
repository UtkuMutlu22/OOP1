using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[]
            //{
            //    "Engin","Murat","Kerem","Halil","Utku"
            //};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[4]);


            List<string> isimler2 = new List<string>();
            isimler2.Add("Utku");
            isimler2.Add("Engin");
            isimler2.Add("Murat");
            isimler2.Add("Kerem");
            isimler2.Add("Halil");
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[4]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[5]);




        }
    }
}
