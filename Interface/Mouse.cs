using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Mouse : IHardware
    {
        public void Komponen()
        {
            Console.WriteLine("Keyboard adalah perangkat input yang digunakan untuk memasukkan karakter dan fungsi ke dalam sistem komputer ");
        }
    }
}