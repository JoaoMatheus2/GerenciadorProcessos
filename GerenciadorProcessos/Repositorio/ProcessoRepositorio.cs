using GerenciadorProcessos.Data;
using GerenciadorProcessos.Models;
using System.Diagnostics;

namespace GerenciadorProcessos.Repositorio
{
  public class ProcessoRepositorio : IProcessoRepositorio
  {
    private readonly BancoContext _bancoContext;
    public ProcessoRepositorio(BancoContext bancoContext)
    {
      _bancoContext = bancoContext;
    }

    public ProcessoModel Adicionar(ProcessoModel processo)
    {
      _bancoContext.Processos.Add(processo);
      _bancoContext.SaveChanges();

      return processo;
    }

    public ProcessoModel Atualizar(ProcessoModel processo)
    {
      ProcessoModel objNoBanco = BuscarPorCodigo(processo.Codigo);

      if (objNoBanco == null) throw new Exception("Houve um erro na atualização do processo!");

      objNoBanco.NomeProcesso = processo.NomeProcesso;
      objNoBanco.UF = processo.UF;
      objNoBanco.NPU = processo.NPU;
      objNoBanco.Municipio = processo.Municipio;

      _bancoContext.Processos.Update(objNoBanco);
      _bancoContext.SaveChanges();

      return objNoBanco;
    }

    public ProcessoModel ConfirmarVisualizacao(int codigo) 
    {
      ProcessoModel objNoBanco = BuscarPorCodigo(codigo);

      if (objNoBanco == null) throw new Exception("Houve um erro na atualização do processo!");

      objNoBanco.DataVisualizacao = DateTime.Now;

      _bancoContext.Processos.Update(objNoBanco);
      _bancoContext.SaveChanges();
      return objNoBanco;
    }

    public ProcessoModel BuscarPorCodigo(int codigo)
    {
      return _bancoContext.Processos.FirstOrDefault(x => x.Codigo == codigo);
    }

    public List<ProcessoModel> BuscarTodos()
    {
      return _bancoContext.Processos.ToList();

    }

    public bool Apagar(int codigo)
    {
      ProcessoModel objNoBanco = BuscarPorCodigo(codigo);

      if (objNoBanco == null) throw new Exception("Houve um erro na exclusão do processo!");

      _bancoContext.Processos.Remove(objNoBanco);
      _bancoContext.SaveChanges();

      return true;
    }
  }
}
