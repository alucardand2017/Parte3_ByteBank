using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        private string _nome;
        private string _cpf;
        private double _salario;
        
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }
    
    public virtual double GetBonificacao() // pode ser sobreescrito por um método override
        {
            return (Salario * 0.10);
        }


    }
}
