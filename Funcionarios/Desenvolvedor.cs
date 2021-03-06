using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(double salario, string cpf) : base(salario, cpf)
        {
            Console.WriteLine("CRIANDO Desenvolvedor");
        }

        public override void AumentarSalario()
        {
            Salario = Salario * 1.2;
        }

        public override double GetBonificacao()
        {
            return Salario*0.2;
        }
    }
}
