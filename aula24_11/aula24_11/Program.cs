namespace aula24_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Agora, partiu testar a classe lampada!");
            Lampada l1= new Lampada("Azul", 200);

            l1.potencia = 200;
            l1.ligar();
            l1.ligar();
            l1.desligar();
            l1.desligar();

            Pessoa p= new Pessoa();
            p.Nome = "joao";
            p.Email = "joao@gmail.com";
            p.Data_nasc = "26/11/2001";
            p.Cpf = "111.111.111-11";
            Console.WriteLine(p.imprimir());

            Porta porta;
            int tipo;
            Console.WriteLine("Digite 1 para criar uma porta normal ou 2 para porta de correr: ");
            tipo= int.Parse(Console.ReadLine());

            if (tipo == 2)
            {
                porta = new PortaCorrer();
            }
            else
            {
                porta = new PortaNormal();
            }

            porta.abrir();
        }
    }
}