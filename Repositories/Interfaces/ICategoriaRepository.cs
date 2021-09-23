using System.Collections.Generic;
using TalionLanches.Models;

namespace TalionLanches.Repositories.Interfaces {
  public interface ICategoriaRepository {
    IEnumerable<CategoriaModel> Categorias { get; }
  }
}
