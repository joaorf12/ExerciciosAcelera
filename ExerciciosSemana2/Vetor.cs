using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetorMatrizArquivo
{
    internal class Vetor
    {
        public void exercicio1()
        {
            int[] v = new int[10];
            int par= 0, impar= 0;
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um numero para a posição "+i+" do vetor: ");
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }
            }
            Console.WriteLine("Quantidade de números impares: "+impar);
            Console.WriteLine("Quantidade de números pares: "+par);
            Console.WriteLine("Digite uma letra para continuar: ");
            string l = Console.ReadLine();
        }
        
        public void exercicio2()
        {
            int[] v1 = new int[10], v2= new int[10], r= new int[10];
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Numero "+i+" do vetor 1: ");
                v1[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Numero " + i + " do vetor 2: ");
                v2[i] = int.Parse(Console.ReadLine());
                r[i] = v1[i] * v2[i];
            }
            for (int i = 0; i < 10; i++)
                Console.WriteLine("Resultado "+i+": " + r[i]);
            Console.WriteLine("Digite uma letra para continuar: ");
            string l = Console.ReadLine();
        }

        public void exercicio3()
        {

        }

    }
}
