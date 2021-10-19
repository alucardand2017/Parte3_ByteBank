using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario Carlos = new Funcionario();
            Diretor Ana = new Diretor();

            Carlos.Salario = 2000;
            Carlos.CPF = "338 189 988 82";
            Carlos.Nome = "Carlos Alberto de Nóbrega";

            Ana.Salario = 10000;
            Ana.CPF = "339 189 988 83";
            Ana.Nome = "Ana Carolinha da Musica";

            gerenciador.Registrar(Carlos);
            gerenciador.Registrar(Ana);

            Console.WriteLine("Bonus do Carlos = " + Carlos.GetBonificacao());
            Console.WriteLine("Bonus do Ana = " + Ana.GetBonificacao());
            Console.WriteLine("Bonus total aplicado = " + gerenciador.GetTotalBonificacao());





        }
    }
}
