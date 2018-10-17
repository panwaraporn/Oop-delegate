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
            MyDelegate del1 = new MyDelegate(Prints);
            MyDelegate del2 = new MyDelegate(p.Printo);
            MyDelegate del = del2 + del1;
            //del += new MyDelegate(p.Printo);

            del("Hello");
            del -= del1;
            del1("After -=");

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
