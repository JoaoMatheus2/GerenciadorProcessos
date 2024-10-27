using GerenciadorProcessos.Models;
using GerenciadorProcessos.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorProcessos.Controllers
{
  public class ProcessosController : Controller
  {
    private readonly IProcessoRepositorio _processoRepositorio;
    public ProcessosController(IProcessoRepositorio processoRepositorio)
    {
      _processoRepositorio = processoRepositorio;
    }
    public IActionResult Index()
    {
       var processos = _processoRepositorio.BuscarTodos();

      return View(processos);
    }

    public IActionResult Criar()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Criar(ProcessoModel processo)
    {
      // Remove a validação para `Codigo` e `DataCadastro`
      ModelState.Remove("Codigo");
      ModelState.Remove("DataCadastro");

      if (ModelState.IsValid) 
      {
        processo.DataCadastro = DateTime.Now;
        _processoRepositorio.Adicionar(processo);
        return RedirectToAction("Index");
      }

      return View(processo);
    }

    [HttpPost]
    public IActionResult ConfirmarVisualizacao(int codigo) 
    {
      _processoRepositorio.ConfirmarVisualizacao(codigo);
      return RedirectToAction("Editar", new { codigo = codigo }); 
    }

    public IActionResult Editar(int codigo)
    {
      var processo = _processoRepositorio.BuscarPorCodigo(codigo);
      return View(processo);
    }

    public IActionResult Detalhar(int codigo) 
    {
      var processo = _processoRepositorio.BuscarPorCodigo(codigo);
      return View(processo);
    }

    public IActionResult ApagarConfirmacao()
    {
      return View();
    }

    public IActionResult Excluir(int id) 
    {
      _processoRepositorio.Apagar(id);
      return RedirectToAction("Index");
    }


    [HttpPost]
    public IActionResult Alterar(ProcessoModel processo)
    {
      if (ModelState.IsValid) 
      {
        _processoRepositorio.Atualizar(processo);
        return RedirectToAction("Index");
      }

      return View("Editar",processo);
    }
  }
}
