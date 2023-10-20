using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Boolean arrs = false;
            //if (arrs)
            //{
            //    Console.WriteLine("Hello world gagam");

            //}else
            //{
            //    Console.WriteLine(arrs);

            //}
            //Console.ReadLine();
            //Console.WriteLine("adinizi girin");
            //string name = Console.ReadLine();
            /*Console.WriteLine("your's names"+ name)*/;
            //Console.WriteLine($"welcome  {name}");
            //a
            //Console.ReadLine();
            Console.WriteLine("notunu gir");
            int first_note = Convert.ToInt32(Console.ReadLine());
            int second_note=Convert.ToInt32(Console.ReadLine());
            int third_note =Convert.ToInt32(Console.ReadLine());

            int sonuc = (first_note + second_note + third_note) / 3;

            if(80 < sonuc && sonuc <= 100)
            {
                Console.WriteLine("A+");
            }else if(60 < sonuc && sonuc <=80){
                Console.WriteLine("A");
            }else if(40 < sonuc && 60 >= sonuc)
            {
                Console.WriteLine("B+");
            }else if(40 > sonuc)
            {
                Console.WriteLine("F");
            }
            Console.ReadLine();
        }
        
    }
}
