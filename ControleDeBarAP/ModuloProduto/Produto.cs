using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBarAP.ModuloProduto
{
    internal class Produto : EntidadeBase<Produto>
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public override void AtualizarRegistro(Produto registroAtualizado)
        {
            throw new NotImplementedException();
        }

        public override string Validar()
        {
            throw new NotImplementedException();
        }
    }
}
