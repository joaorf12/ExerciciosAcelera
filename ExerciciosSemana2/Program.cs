namespace vetorMatrizArquivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op=0;
            while( op != 9)
            {
                Console.Clear();
                Console.WriteLine("Digite: \n" +
                    "1- Para vetores \n" +
                    "2- Para matriz \n" +
                    "3- Para arquivo \n" +
                    "4- Para sair");
                int op2 = int.Parse(Console.ReadLine());
                switch (op2)
                {
                    case 1:
                        menuVetor();
                        break;
                    case 2:
                        menuMatrix();
                        break;
                    case 3:
                        menuArquivo();
                        break;
                    case 4:
                        op = 9;
                        break;
                }
            }
        }

        static void menuVetor()
        {
            Console.Clear();
            Vetor v = new Vetor();
            Console.WriteLine("Digite: \n" +
                "1- Para o exercicio 1 \n" +
                "2- Para o exercicio 2");
            int op3 = int.Parse(Console.ReadLine());
            switch (op3)
            {
                case 1:
                    v.exercicio1();
                    break;
                case 2:
                    v.exercicio2();
                    break;
            }
        }

        static void menuMatrix()
        {
            Console.Clear();
            Matriz m = new Matriz();
            Console.WriteLine("Digite: \n" +
                "1- Para o exercicio 1 \n" +
                "2- Para o exercicio 2");
            int op3 = int.Parse(Console.ReadLine());
            switch (op3)
            {
                case 1:
                    m.exercicio1();
                    break;

                case 2:
                    m.exercicio2();
                    break;

            }
        }

        static void menuArquivo()
        {
            Console.Clear();
            Console.WriteLine("Digite: \n" +
                "1- Para o exemplo de arquivo \n" +
                "2- Para o exercicio do email \n" +
                "3- Para o exercicio das figurinhas");
            int op3 = int.Parse(Console.ReadLine());
            switch (op3)
            {
                case 1:
                    chamadaArquivoEx();
                    break;
                case 2:
                    chamadaEmail();
                    break;
                case 3:
                    chamadaFigurinha();
                    break;
            }
            
        }

        //EX ARQUIVO
        static void chamadaArquivoEx()
        {
            string nome, mensagem;
            Console.WriteLine("Digite um nome para o arquivo: ");
            nome = Console.ReadLine();
            Arquivo a = new Arquivo(nome);
            int op4;
            while (true)
            {
                Console.WriteLine("Digite: \n" +
                    "1- Para escrever no arquivo\n" +
                    "2- Para ler o arquivo\n" +
                    "3- Para sair");
                op4 = int.Parse(Console.ReadLine());
                if (op4 == 1)
                {
                    a.criarAbrirArquivo();
                    Console.WriteLine("Digite uma mensagem para ser armazenada: \n" +
                        "Para sair digite SAIR");
                    while (true)
                    {
                        mensagem = Console.ReadLine();
                        if (mensagem.Equals("SAIR"))
                        {
                            a.fecharArquivo();
                            break;
                        }
                        else
                        {
                            a.gravaMensagem(mensagem);
                        }
                    }
                }
                else if (op4 == 2)
                {
                    a.lerArquivo();
                }
                else
                {
                    break;
                }
            }
        }

        //EMAIL
        static void chamadaEmail()
        {
            Console.WriteLine("Digite um nome para o arquivo: ");
            string nome = Console.ReadLine();
            ExercicioArquivo e = new ExercicioArquivo(nome);
            int op = 0;
            while (op != 3)
            {
                Console.Clear();
                Console.WriteLine("Menu \n" +
                "1 - Cadastrar email \n" +
                "2 - Listar \n" +
                "3 - Sair ");
                op = int.Parse(Console.ReadLine());
                Console.Clear();
                if (op == 1)
                {
                    e.criarAbrirArquivo();
                    string email;
                    Console.WriteLine("Digite um email para ser armazenado: \n" +
                        "Para sair digite SAIR");
                    while (true)
                    {
                        email = Console.ReadLine();
                        if (email.Equals("SAIR"))
                        {
                            e.fecharArquivo();
                            break;
                        }
                        else
                        {
                            e.gravaMensagem(email);
                        }
                    }
                }
                else if (op == 2)
                {
                    e.lerArquivo();
                }
                else
                {
                    break;
                }
            }
        }

        static void chamadaFigurinha()
        {
            int op = 0;
            while ( op != 3)
            {
                Console.Clear();
                Console.WriteLine("Menu: \n" +
                "1- Figurinhas faltantes \n" +
                "2- Figurinhas repetidas \n" +
                "3- Para sair");
                op = int.Parse(Console.ReadLine());
                //Figurinha faltante
                if (op == 1)
                {
                    int op2 = 0;
                    ExercicioArquivo e = new ExercicioArquivo("faltantes");
                    while (op2 != 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Menu figurinhas faltantes: \n" +
                        "1 - Cadastrar figurinha \n" +
                        "2 - Para Listar \n" +
                        "3 - Para Sair ");

                        op2 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (op2 == 1)
                        {
                            e.criarAbrirArquivoFigurinha();
                            string figurinha;
                            Console.WriteLine("Digite uma figurinha faltante para ser armazenada: \n" +
                                "Para sair digite SAIR");
                            while (true)
                            {
                                figurinha = Console.ReadLine();
                                if (figurinha.Equals("SAIR"))
                                {
                                    e.fecharArquivo();
                                    break;
                                }
                                else
                                {
                                    e.gravaFigurinha(figurinha);
                                }
                            }
                        }
                        else if (op2 == 2)
                        {
                            e.lerArquivoFigurinha();
                            Console.WriteLine("Digite qualquer letra para continuar");
                            string x = Console.ReadLine();
                        }
                        else
                        {
                            break;
                        }

                    }
                }
                else if(op == 2)
                {
                    int op2 = 0;
                    ExercicioArquivo e = new ExercicioArquivo("repetidas");
                    while (op2 != 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Menu figurinhas repetidas: \n" +
                        "1 - Cadastrar figurinha \n" +
                        "2 - Para Listar \n" +
                        "3 - Para Sair ");

                        op2 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (op2 == 1)
                        {
                            e.criarAbrirArquivoFigurinha();
                            string figurinha;
                            Console.WriteLine("Digite uma figurinha repetida para ser armazenada: \n" +
                                "Para sair digite SAIR");
                            while (true)
                            {
                                figurinha = Console.ReadLine();
                                if (figurinha.Equals("SAIR"))
                                {
                                    e.fecharArquivo();
                                    break;
                                }
                                else
                                {
                                    e.gravaFigurinha(figurinha);
                                }
                            }
                        }
                        else if (op2 == 2)
                        {
                            e.lerArquivoFigurinha();
                            Console.WriteLine("Digite qualquer letra para continuar");
                            string x= Console.ReadLine();
                        }
                        else
                        {
                            break;
                        }

                    }
                }
            }
            

        }
    }
}