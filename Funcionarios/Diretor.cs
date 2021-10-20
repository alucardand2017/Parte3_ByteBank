using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        public override double GetBonificacao() //sobrescreve a da classe pai
        {
            return (Salario + base.GetBonificacao()); //o base nesse caso faz referenca a funcao da classe base funcionário, impedindo assim que haja um stackoverflow por erro de codigo que iria chamar indefinidamente o método getbonificação.
        }
    }
}
