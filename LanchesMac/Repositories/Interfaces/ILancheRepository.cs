using LanchesMac.Models;

namespace LanchesMac.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanche { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }
        Lanche GetLanchesById(int lancheId);
    }
}
