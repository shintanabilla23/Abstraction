using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstraction.AbstractClass;    //Menggunakan Abstract Class
//using Abstraction.Interface;        //Apabila Menggunakan Interface

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Hardware hardware;
            hardware = new Monitor();
            hardware.Komponen();

            Console.WriteLine();
            hardware = new Keyboard();
            hardware.Komponen();

            Console.WriteLine();
            hardware = new Mouse();
            hardware.Komponen();
            

            /*IHardware hardware;     //Apabila menggunakan Abstract Class
            hardware = new Monitor();
            hardware.Komponen();
            Console.WriteLine();
            hardware = new Keyboard();
            hardware.Komponen();
            Console.WriteLine();
            hardware = new Mouse();
            hardware.Komponen();
            */
            
            Console.ReadKey();
        }
    }
}