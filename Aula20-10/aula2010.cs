using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulas
{
    internal class aula2010
    {
        public void continuar()
        {
            Console.WriteLine("Digite qualquer tecla para continuar: ");
            char c = char.Parse(Console.ReadLine());
        }
        public void oi()
        {
            int[] v = new int[10];
            Console.WriteLine("oi");
        }
        public static void oi2()
        {
            int[] v = new int[10];
            Console.WriteLine("oi");
        }
        public void somaMedia()
        {
            double[] notas = new double[50];
            double media = 0;
            for(int i = 0; i < 50; i++)
            {
                Console.WriteLine("Digite a nota do aluno "+(i+1)+": ");
                notas[i]= double.Parse(Console.ReadLine());
                media += notas[i];
            }
            media = media / 50;
            Console.WriteLine("Média: "+media);
            continuar();
        }

        public void maior()
        {
            int[] vetor= new int[10];
            int i, maior;
            for(i=0; i < 10; i++)
            {
                Console.WriteLine("Digite o elemento "+i+" do vetor: ");
                vetor[i]= int.Parse(Console.ReadLine());
            }
            maior = vetor[0];
            for( i=0; i < 10; i++)
            {
                if(maior > vetor[i])
                {
                    maior = vetor[i];
                }
            }
            Console.WriteLine(maior);
            continuar();
        }
        //Vetor [L] [C]
        public void matrixEx()
        {
            int i, j;
            int[,] A = new int[3, 4];
            for (i = 0; i < 3; i++)
            {
                for(j = 0; j < 4; j++)
                {
                    Console.WriteLine("A["+i+" , "+j+"] = " + A[i,j]);
                }
            }
            continuar();
        }

        public void arquivoEscrever()
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\arquivo\\teste.txt");
                sw.WriteLine("Estou escrevendo um texto aqui...");
                sw.WriteLine("E posso ter uma seguda linha");
                sw.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exceção: "+ e.Message);
            }
            finally
            {
                Console.WriteLine("Bloco finally");
            }
            continuar();
        }

        public void arquivoLer()
        {
            String line;
            try
            {
                StreamReader sr= new StreamReader("C:\\arquivo\\teste.txt");
                line= sr.ReadLine();

                while( line != null)
                {
                    Console.WriteLine(line);
                    line= sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exceção: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Bloco finally");
            }
            continuar();
        }
        /*
            int x;
            x = 5;
            Console.WriteLine("Hello, World!: "+ x);

            Console.WriteLine("Digite um valor: ");
            x= x + int.Parse(Console.ReadLine());

            if(x > 0)
            {
                Console.WriteLine("Número maior que 0");
            }
            */

        /*
        Console.WriteLine("Números de 0 a 10");
        for(int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Números de 20 a 5");
        for(int i = 20; i >= 5; i--)
        {
            Console.WriteLine(i);
        }
        */

        /*
        Console.WriteLine("Leitura");
        Console.WriteLine("Digite o valor inicial: ");
        int inicio = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor final: ");
        int fim= int.Parse(Console.ReadLine());
        if (inicio < fim)
        {
            for (int i = inicio + 1; i < fim; i++)
            {
                Console.WriteLine(i);
            }
        }
        else if (inicio > fim)
        {
            for(int i = inicio - 1; i > fim; i--)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("Valores iguais");
        }
        */

        /*
        Console.WriteLine("Leitura");
        Console.WriteLine("Digite um valor: ");
        int x = int.Parse(Console.ReadLine());
        if(x > 0 && x <= 100)
        {
            for (int i = 0; i <= 100; i = i + x)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("Número negativo ou maior que 100");
        }
        */
        /*
        Console.WriteLine("Leitura");
        Console.WriteLine("Digite um valor: ");
        int x = int.Parse(Console.ReadLine());
        if (x > 0 && x <= 100)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % x == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("Número negativo ou maior que 100");
        }
        */

        /*
        while (true) {
        Console.WriteLine("Digite o numero de alunos: ");
        int a = int.Parse(Console.ReadLine());
        double n1, n2, n3;
        for (int i = 1; i <= a; i++)
        {
            Console.WriteLine("Aluno "+i);
            Console.WriteLine("Digite a 1ª nota: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 2ª nota: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 3ª nota: ");
            n3 = double.Parse(Console.ReadLine());

            n1 = (n1 + n2 + n3) / 3;
            if (n1 >= 7)
            {
                Console.WriteLine("Média: " + n1.ToString("N2") + " Aluno Aprovado!");
            }
            else
            {
                Console.WriteLine("Média: " + Math.Round(n1, 2) + " Aluno Reprovado!");
            }
        }
            Console.WriteLine("Deseja adicionar mais alunos? (s/n)");
            char op= char.Parse(Console.ReadLine());
            switch(op){
                case 'n':
                    break;
            }
        }
        */
        /*
        int opcao;
        while( true )
        {
            Console.WriteLine("Digite um numero de 1 a 4 para continuar o programa");
            opcao = int.Parse(Console.ReadLine());
            if (opcao <= 4 && opcao >= 1) {
                break;
            }

        }
        switch (opcao)
        {
            case 1:
                Console.WriteLine("Primeira opcão");
                break;

            case 2:
                Console.WriteLine("Segunda opcão");
                break;
            case 3:
                Console.WriteLine("Terceira opcão");
                break;
            case 4:
                Console.WriteLine("Quarta opcão");
                break;
        }*/
    }
}
