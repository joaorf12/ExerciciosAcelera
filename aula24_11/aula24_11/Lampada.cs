using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula24_11
{
    internal class Lampada
    {
        public bool ligada;
        //public String status;
        public double potencia;
        public String cor;

        //ctor cria construtor autatico
        public Lampada(String cor, double potencia)
        {
            this.cor = cor;
            this.potencia = potencia;
        }

        /*public void ligar()
        {
            status = "Ligada";
        }

        public void desligar()
        {
            status = "Desligada";
        }

        public void meiaLuz()
        {
            status = "Meia-luz";
        }*/

        public bool isLigada()
        {
            return ligada;
        }

        public void ligar()
        {
            if (!isLigada())
            {
                ligada = true;
                Console.WriteLine("Ligando a Lampada!");
            }
            else
            {
                Console.WriteLine("Já está ligada!");
            }
        }

        public void desligar()
        {
            if (isLigada())
            {
                ligada = false;
                Console.WriteLine("Desligando a Lampada!");
            }
            else
            {
                Console.WriteLine("Já está desligada!");
            }
        }
    }
}
