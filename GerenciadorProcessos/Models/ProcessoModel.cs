using System.ComponentModel.DataAnnotations;

namespace GerenciadorProcessos.Models
{
  public class ProcessoModel
  {
    [Key]
    public int Codigo { get; set; }
    [Required(ErrorMessage = "Digite o Nome do Processo")]
    public string NomeProcesso { get; set; }
    [Required(ErrorMessage = "Digite o NPU")]
    [RegularExpression(@"^\d{7}-\d{2}\.\d{4}\.\d{1}\.\d{2}\.\d{4}$", ErrorMessage = "O NPU deve estar no formato correto: 1111111-11.1111.1.11.1111")]
    public string NPU { get; set; }
    public DateTime DataCadastro { get; set; }
    public DateTime? DataVisualizacao { get; set; }
    [Required(ErrorMessage = "Selecione o UF")]
    public string UF { get; set; }
    [Required(ErrorMessage = "Selecione o Município")]
    public string Municipio { get; set; }
  }
}
