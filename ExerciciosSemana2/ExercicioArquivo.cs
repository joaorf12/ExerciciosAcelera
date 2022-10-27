using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetorMatrizArquivo
{
    internal class ExercicioArquivo
    {
        StreamReader sr;
        StreamWriter sw;
        string nome;

        public ExercicioArquivo()
        {
        }
        public ExercicioArquivo(string nome)
        {
            this.nome = nome;
        }

        //Exercicio Email
        public void criarAbrirArquivo()
        {
            sw = new StreamWriter("C:\\Arquivo\\" + nome + ".txt", true, Encoding.UTF8);
        }

        public void lerArquivo()
        {
            string linha;
            sr= new StreamReader("C:\\Arquivo\\" + nome + ".txt");
            linha= sr.ReadLine();
            while( linha != null)
            {
                Console.WriteLine(linha);
                linha = sr.ReadLine();
            }
            sr.Close();
        }

        public void gravaMensagem(string email)
        {
            sw.WriteLine(email);
        }

        public void fecharArquivo()
        {
            sw.Close();
        }

        //Exercicio Figurinha
        public void criarAbrirArquivoFigurinha()
        {
            sw = new StreamWriter("C:\\Arquivo\\"+nome+".csv", true, Encoding.UTF8);
        }
        public void lerArquivoFigurinha()
        {
            string linha;
            sr = new StreamReader("C:\\Arquivo\\"+ nome + ".csv");
            linha = sr.ReadLine();
            while (linha != null)
            {
                Console.WriteLine(linha);
                linha = sr.ReadLine();
            }
            sr.Close();
        }

        public void gravaFigurinha(string figurinha)
        {
            sw.WriteLine(figurinha);
        }

    }
}
