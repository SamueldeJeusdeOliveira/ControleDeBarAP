using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBarAP.ModuloProduto;

namespace ControleDeBar.ConsoleApp.ModuloMesa;

public class TelaProduto : TelaBase<Produto>, ITela
{
    public override void VisualizarRegistros(bool exibirCabecalho)
    {
        throw new NotImplementedException();
    }

    protected override Produto ObterDados()
    {
        throw new NotImplementedException();
    }
}