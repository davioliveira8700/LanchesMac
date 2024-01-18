using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;
        public LancheRepository(AppDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Lanche> Lanche => _context.Lanches.Include(c=> c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(l=>l.IsLanchesPreferido).Include(c => c.Categoria);

        public Lanche GetLanchesById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(l=>l.LancheId == lancheId) ;
        }
    }
}
