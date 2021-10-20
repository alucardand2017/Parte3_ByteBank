using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario // a classe é abstrata porque não é necessário ter ele  e poder acessa-lo como as outras classes. A diferença que ele não é diretamente instanciado como as demais classes.
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; protected set; }
        public static  int TotalDeFuncionarios {get; private set;}  //1
        
        //esse construtor obriga os membros da classe filha a seguirem esse padrão para instanciamento de objetos, obringando a informar os itens obrigatorios pelas regras do negocio.
        public Funcionario(double salario , string cpf)
        {
            CPF = cpf;
            TotalDeFuncionarios++;
            Salario = salario;
        }
        //esses codigos obrigam os metodos das classes filhas a informar um método GetBonificação, assim diminuindo a probabilidades de erros de esquecimento no codigo
        public abstract double GetBonificacao();  // membro abstrato que é sobrescrito por um metodo overrida nas classes filhas
        public abstract void AumentarSalario(); // membro abstrato que é sobrescrito por um método override nas classes filhas.
 

    }
}
