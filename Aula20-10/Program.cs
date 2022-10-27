using System;

namespace aulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new aula2010().oi();
            aula2010.oi2();
            int op= 0;
            while (op != 10)
            {
                Console.Clear();
                Console.WriteLine("Digite uma opção: ");
                Console.WriteLine("1- Para exercicio soma media \n" +
                    "2- Para exercicio maior \n" +
                    "3- Para exemplo matrix \n" +
                    "4- Escrever arquivo \n" +
                    "5- Ler arquivo \n" +
                    "6- Arquivo \n" +
                    "10- Para sair");
                op= int.Parse(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1:
                        new aula2010().somaMedia();
                        break;
                    case 2:
                        new aula2010().maior();
                        break;
                    case 3:
                        new aula2010().matrixEx();
                        break;
                    case 4:
                        new aula2010().arquivoEscrever();
                        break;
                    case 5:
                        new aula2010().arquivoLer();
                        break;
                    case 6:
                        Console.WriteLine("Digite o nome do arquivo: ");
                        string nomeArquivo = Console.ReadLine();
                        Arquivo a = new Arquivo(nomeArquivo);
                        bool x = true;
                        while ( x )
                        {
                            Console.WriteLine("Digite: \n1 - Para criar/abrir um arquivo\n" +
                                "2 - Para gravar no arquivo\n"+
                                "3 - Para ler o arquivo\n" +
                                "0 - Para sair");
                            int op2= int.Parse(Console.ReadLine());
                            Console.Clear();
                            switch (op2)
                            {
                                case 0:
                                    x = false;
                                    break;
                                case 1:
                                    a.criaAbreArquivo();
                                    a.fecharArquivo();
                                    break;
                                case 2:
                                    a.criaAbreArquivo();
                                    Console.WriteLine("Digite uma mensagem para adicionar no arquivo: ");
                                    string msg= Console.ReadLine();
                                    a.gravaMensagem(msg);
                                    a.fecharArquivo();
                                    break;
                                case 3:
                                    a.lerArquivo();
                                    break;

                            }
                            
                        }
                        /*a.criaAbreArquivo();
                        a.gravaMensagem("oi");
                        //a.fecharArquivo();

                        //a.criaAbreArquivo();
                        a.gravaMensagem("oi");
                        a.gravaMensagem("oi boa noite");
                        //a.fecharArquivo();*/
                        break;
                default:
                        op = 10;
                        break;
                }
            }



        }
    }
}