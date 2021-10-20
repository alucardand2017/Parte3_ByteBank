using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(double salario, string cpf) : base(salario, cpf) // construtor do diretor deve ter os mesma construção da classe base. Os : dizem que o construtor da classe base será executado primeiro, passando o argumento entre parenteses pra ele.
        {
            Console.WriteLine("CRIANDO Designer");
        }
        public override void AumentarSalario()
        {
            Salario *= 1.11f;
        }
        public override double GetBonificacao() //sobrescreve a da classe pai
        {
            return (Salario*0.17); //o base nesse caso faz referenca a funcao da classe base funcionário, impedindo assim que haja um stackoverflow por erro de codigo que iria chamar indefinidamente o método getbonificação.
        }
    }
}
