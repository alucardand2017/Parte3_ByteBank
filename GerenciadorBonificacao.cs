using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class GerenciadorBonificacao
    {
        private double _totalBonificacao;

        public double Registrar(Funcionario funcionario)
        {
            return _totalBonificacao  += funcionario.GetBonificacao();
        }
        public double Registrar(Diretor diretor)
        {
            return _totalBonificacao += diretor.GetBonificacao();
        }
        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
