using BibliotecaAPI.Enitities;

namespace BibliotecaAPI.Repositories
{
    public interface IValoresRepositories
    {
        void InsertarValor(Valor valor);
        IEnumerable<Valor> ObtenerValores();
    }
}
