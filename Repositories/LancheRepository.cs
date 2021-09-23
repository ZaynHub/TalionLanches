using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TalionLanches.Context;
using TalionLanches.Models;
using TalionLanches.Repositories.Interfaces;

namespace TalionLanches.Repositories {
  public class LancheRepository : ILancheRepository {
    private readonly AppDbContext _context;

    public LancheRepository(AppDbContext contexto) {
      _context = contexto;
    }
    public IEnumerable<LancheModel> Lanches => _context.Lanches.Include(c => c.Categoria);

    public IEnumerable<LancheModel> LanchesPreferidos => _context.Lanches.Where(
      p => p.IsLanchePreferido == true).Include(c => c.Categoria);

    public LancheModel GetLancheById(int id) => _context.Lanches.FirstOrDefault(i => i.Id == id);

  }
}
