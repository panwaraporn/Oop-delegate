using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_delegate
{
    delegate void MyDelegate(string s); // 1. declare delegate
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            // Prints("Hello world");
            // p.Printo("Hello world");
            //2. create delegate object
            // MyDelegate delo = new MyDelegate(p.Printo);
            // MyDelegate dels = new MyDelegate(Prints);
            MyDelegate del = new MyDelegate(Prints);
            del += new MyDelegate(p.Printo);
            del("Hello");
            //delo("Hello object");
            //dels("Hello Static");

            //Console.WriteLine("Hello World");
        }
        public static void Prints(string v) //metod ที่เรียกได้ทันที
        {
            Console.WriteLine(v + "from Prints");
        }
        public void Printo(string v)
        {
            Console.WriteLine(v + "form Printo");
        }
    }
}
