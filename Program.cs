using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program //Programa para exemplificar a utilização do construtor 
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciadorBn = new GerenciadorBonificacao();

            Funcionario Carlos = new Funcionario();
            Diretor Ana = new Diretor();

            Carlos.Salario = 10000;
            Carlos.CPF = "338 189 988 82";
            Carlos.Nome = "Carlos Alberto de Nóbrega";

            Ana.Salario = 10000;
            Ana.CPF = "339 189 988 83";
            Ana.Nome = "Ana Carolinha da Musica";

            gerenciadorBn.Registrar(Carlos);
            gerenciadorBn.Registrar(Ana);

            Console.WriteLine("Bonus do Carlos = " + Carlos.GetBonificacao());
            Console.WriteLine("Bonus do Ana = " + Ana.GetBonificacao());
            Console.WriteLine("Bonus total aplicado = " + gerenciadorBn.GetTotalBonificacao());





        }
    }
}
