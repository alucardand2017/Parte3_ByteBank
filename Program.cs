using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program //Programa para exemplificar a utilização do construtor 
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciadorBn = new GerenciadorBonificacao();

            Auxiliar Carlos = new Auxiliar(5000 , "338 189 988 82");
            Diretor Ana = new Diretor(10000 , "339 189 988 83");

            //Carlos.Salario = 5000f;
            Carlos.Nome = "Carlos Alberto de Nóbrega";

            //Ana.Salario = 10000f;
            Ana.Nome = "Ana Carolinha da Musica";

            gerenciadorBn.Registrar(Carlos);
            gerenciadorBn.Registrar(Ana);

            Console.WriteLine("Salário do Carlos = " + Carlos.Salario);
            Console.WriteLine("Salário do Ana = " + Ana.Salario);
            Carlos.AumentarSalario();
            Ana.AumentarSalario();
            Console.WriteLine("Salário do Carlos após aumento = " + Carlos.Salario);
            Console.WriteLine("Salário do Ana após o aumento = " + Ana.Salario);

            Console.WriteLine("Bonus do Carlos = " + Carlos.GetBonificacao());
            Console.WriteLine("Bonus do Ana = " + Ana.GetBonificacao());
            Console.WriteLine("Bonus total aplicado = " + gerenciadorBn.GetTotalBonificacao());

        }
        public void CalcularBonificacao()
        {

        }
    }
}
