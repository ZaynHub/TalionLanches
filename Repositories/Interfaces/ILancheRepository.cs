using System.Collections.Generic;
using TalionLanches.Models;

namespace TalionLanches.Repositories.Interfaces {
  public interface ILancheRepository {
    IEnumerable<LancheModel> Lanches { get; }
    IEnumerable<LancheModel> LanchesPreferidos { get; }
    LancheModel GetLancheById(int id);
  }
}
