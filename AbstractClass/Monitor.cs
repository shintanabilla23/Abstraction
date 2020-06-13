using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Monitor : Hardware
    {
        public override void Komponen()
        {
            Console.WriteLine("Perangkat keras yang digunakan untuk menampilkan menampilkan data grafis tampilan yang ada pada CPU");
        }
    }
}