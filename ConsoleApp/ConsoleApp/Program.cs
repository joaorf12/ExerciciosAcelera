using ConsoleApp.DataModels;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq.Expressions;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digite:\n" +
                "1 para criar uma pessoa\n" +
                "2 para alterar o nome da pessoa\n" +
                "3 para inserir um email\n" +
                "4 para excluir uma pessoa\n" +
                "5 para consultar tudo\n" +
                "6 para consultar pelo ID\n" +
                "7 para consultar pelo nome");

                int op = int.Parse(Console.ReadLine());

                Contexto contexto = new Contexto();

                switch (op)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Inserir o nome da pessoa: ");
                            Pessoa p = new Pessoa();
                            p.nome = Console.ReadLine();

                            Console.WriteLine("Informe um email");
                            string email = Console.ReadLine();

                            p.Emails = new List<Email>()
                        {
                            new Email()
                            {
                                email = email
                            }
                        };
                            contexto.Add(p);
                            contexto.SaveChanges();

                            Console.WriteLine("Pessoa inserida com sucesso!");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 2:
                        try
                        {
                            Console.WriteLine("Informar o ID da pessoa: ");
                            int id = int.Parse(Console.ReadLine());

                            Pessoa pAlt = contexto.Pessoas.Find(id);

                            Console.WriteLine("Informe o nome correto: ");
                            pAlt.nome = Console.ReadLine();

                            contexto.Pessoas.Update(pAlt);
                            contexto.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 3:
                        try
                        {
                            Console.WriteLine("Inserir o ID da pessoa: ");
                            int id = int.Parse(Console.ReadLine());

                            Pessoa p = contexto.Pessoas.Find(id);

                            Console.WriteLine("Informe o novo email");
                            string email = Console.ReadLine();

                            p.Emails = new List<Email>()
                        {
                            new Email()
                            {
                                email = email
                            }
                        };
                            contexto.Pessoas.Update(p);
                            contexto.SaveChanges();

                            Console.WriteLine("Inserido com sucesso!");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 4:
                        try
                        {
                            Console.WriteLine("Informar o ID da pessoa: ");
                            int id = int.Parse(Console.ReadLine());
                            Pessoa pAlt = contexto.Pessoas.Find(id);

                            Console.WriteLine("Confirmar a exclusão de " + pAlt.nome);
                            Console.WriteLine("E dos seus emails:");

                            foreach (Email item in pAlt.Emails)
                            {
                                Console.WriteLine("\t" + item.email);
                            }

                            Console.WriteLine("Digite 1 para SIM e outra tecla para NÃO");
                            if (int.Parse(Console.ReadLine()) == 1)
                            {
                                contexto.Pessoas.Remove(pAlt);
                                contexto.SaveChanges();
                                Console.WriteLine(pAlt.nome + " excluída com sucesso!");
                            }
                            else
                            {
                                return;
                            }


                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 5:
                        List<Pessoa> lists = (from Pessoa p in contexto.Pessoas
                                              select p).Include(pes => pes.Emails).ToList<Pessoa>();
                        foreach (Pessoa item in lists)
                        {
                            Console.WriteLine(item.nome);
                            foreach(Email itemE in item.Emails)
                            {
                                Console.WriteLine("\t"+itemE.email);
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 6:
                        Console.WriteLine("Inserir o ID da pessoa: ");
                        int idPessoa = int.Parse(Console.ReadLine());

                        Pessoa pessoa = contexto.Pessoas
                            .Include(p => p.Emails)
                            .FirstOrDefault(x => x.Id == idPessoa);
                        Console.WriteLine(pessoa.nome);

                        if(pessoa.Emails != null)
                        {
                            foreach (Email item in pessoa.Emails)
                            {
                                Console.WriteLine("\t" + item.email);
                            }
                        }
                        break;

                    case 7:
                        Console.WriteLine("Inserir o nome da pessoa: ");
                        string nome = Console.ReadLine();
                        Pessoa pessoa1 = contexto.Pessoas
                            .Include(p => p.Emails)
                            .FirstOrDefault(x => x.nome == nome);
                        if (pessoa1.Emails != null)
                        {
                            foreach (Email item in pessoa1.Emails)
                            {
                                Console.WriteLine("\t" + item.email);
                            }
                        }
                        break;
                        
                }
            }
            
        }
    }
}