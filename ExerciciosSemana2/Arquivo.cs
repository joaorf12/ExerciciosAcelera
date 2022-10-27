﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetorMatrizArquivo
{
    internal class Arquivo
    {
        string nome, mensagem;
        StreamReader sr;
        StreamWriter sw;

        public Arquivo(string nome)
        {
            this.nome = nome;
        }

        public void criarAbrirArquivo()
        {
            sw = new StreamWriter("C:\\Arquivo\\" + nome + ".txt", true, Encoding.UTF8);
        }

        public void lerArquivo()
        {
            string linha;
            sr = new StreamReader("C:\\Arquivo\\" + nome + ".txt");
            linha= sr.ReadLine();
            while( linha != null)
            {
                Console.WriteLine(linha);
                linha = sr.ReadLine();
            }
            sr.Close();
        }

        public void gravaMensagem(string mensagem)
        {
            sw.WriteLine(mensagem);
        }

        public void fecharArquivo()
        {
            sw.Close();
        }
    }
}
