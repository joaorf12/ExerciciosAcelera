using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetorMatrizArquivo
{
    internal class Matriz
    {
        //[LINHAS , COLUNAS]
        //int[,] m = new int[5, 5];
        public void exercicio1()
        {
            int[,] x = new int[5, 3];
            for( int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if( j == 0)
                    {
                        Console.WriteLine("Digite 5 números: ");
                        x[i,j] = int.Parse(Console.ReadLine());

                    }
                    else if( j == 1)
                    {
                        x[i, j] = x[i, j-1] + 10;
                    }
                    else if( j == 2)
                    {
                        x[i, j] = x[i, j - 2] * 2;
                    }
                }
            }
            for( int i = 0; i < 5; i++)
            {
                for( int j = 0; j < 3; j++)
                {
                    if( j != 2)
                    {
                        Console.Write(x[i, j]+", ");
                    }
                    else
                    {
                        Console.WriteLine(x[i, j] + "\n");
                    }
                }
            }

            Console.WriteLine("Digite uma letra para continuar: ");
            string l = Console.ReadLine();
        }

        public void exercicio2()
        {
            int[,] x = new int[3, 3];
            int maior=0, menor= 0, linha= 0;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Digite um número: ");
                    x[i,j]= int.Parse(Console.ReadLine());
                    if (i == 0 && j == 0 || x[i, j] >= maior)
                    {
                        maior = x[i, j];
                        linha = i;
                    }
                }
            }
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j != 2)
                    {
                        Console.Write(x[i, j] + ", ");
                    }
                    else
                    {
                        Console.WriteLine(x[i, j] + "\n");
                    }
                }
            }
            for ( int j = 0; j < 3; j++)
            {
                if (j == 0 || x[linha, j] <= menor)
                {
                    menor= x[linha, j];
                }
            }
            Console.WriteLine("Linha: "+(linha +1)+"\n"+
                "Maior: "+maior+"\n" +
                "Menor: "+menor);

            Console.WriteLine("Digite uma letra para continuar: ");
            string l = Console.ReadLine();
        }
    }
}
