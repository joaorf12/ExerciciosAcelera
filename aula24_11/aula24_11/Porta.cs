using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula24_11
{
    internal abstract class Porta
    {
        public string cor;
        public double tamanho;
        public string tipoFechaduro;
        public abstract void abrir();
    }
}
