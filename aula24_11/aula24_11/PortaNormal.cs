using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula24_11
{
    internal class PortaNormal : Porta
    {
        public override void abrir()
        {
            Console.WriteLine("Abrindo porta normal");
        }
    }
}
