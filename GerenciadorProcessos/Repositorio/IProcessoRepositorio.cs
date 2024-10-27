using GerenciadorProcessos.Models;

namespace GerenciadorProcessos.Repositorio
{
  public interface IProcessoRepositorio
  {
    List<ProcessoModel> BuscarTodos();
    ProcessoModel BuscarPorCodigo(int codigo);
    ProcessoModel Adicionar(ProcessoModel processo);
    ProcessoModel Atualizar(ProcessoModel processo);
    ProcessoModel ConfirmarVisualizacao(int codigo);
    bool Apagar(int codigo);
  }
}
