using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TalionLanches.Models {
  public class CategoriaModel {
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public List<LancheModel> Lanches { get; set; }
  }
}
