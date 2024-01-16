namespace LanchesMac.Models
{
    public class Categoria
    {
        public int CategotiaId { get; set; }
        public string CategoriaNome { get; set; }
        public string CategoriaDescricao { get; set; }

        public List<Lanche> Lanches{ get; set; }
    }
}
