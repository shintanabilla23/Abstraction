using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Mouse : Hardware
    {
        public override void Komponen()
        {
            Console.WriteLine("Keyboard adalah perangkat input yang digunakan untuk memasukkan karakter dan fungsi ke dalam sistem komputer ");
        }
    }
}