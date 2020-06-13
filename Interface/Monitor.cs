using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Monitor : IHardware
    {
        public void Komponen()
        {
            Console.WriteLine("Perangkat keras yang digunakan untuk menampilkan menampilkan data grafis tampilan yang ada pada CPU");
        }
    }
}