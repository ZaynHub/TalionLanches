using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TalionLanches.Models {
  public class LancheModel {
    public int Id { get; set; }
    public string Nome { get; set; }
    public string DescricaoCurta { get; set; }
    public string DescricaoDetalhada { get; set; }
    public Decimal Preco { get; set; }
    public string ImagemUrl { get; set; }
    public string ImagemThumbnailUrl { get; set; }
    public bool IsLanchePreferido { get; set; }
    public bool EmEstoque { get; set; }
    public int CategoriaId { get; set; }
    public virtual CategoriaModel Categoria { get; set; }
  }
}
