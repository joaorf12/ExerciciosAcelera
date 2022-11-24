using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula24_11
{
    internal class Pessoa
    {
        private String nome;
        private String email;
        private String cpf;
        private String data_nasc;

        public string Email { get => email; set => email = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Data_nasc { get => data_nasc; set => data_nasc = value; }
        public string Nome { get => nome; set => nome = value; }

        public String imprimir()
        {
            return "Nome: " + this.Nome + "\n"
                + "CPF: " + this.Cpf + "\n"
                + "Data de Nascimento: " + this.Data_nasc + "\n"
                + "Email: " + this.Email;
        }
    }
}
