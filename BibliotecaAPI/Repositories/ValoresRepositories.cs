using BibliotecaAPI.Enitities;

namespace BibliotecaAPI.Repositories
{
    public class ValoresRepositories:IValoresRepositories
    {
        public void InsertarValor(Valor valor)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Valor> ObtenerValores()
        {
            return new List<Valor>
            {
                new Valor{Id = 1, Name="Valor 1"},
                new Valor{Id = 2, Name="Valor 2"}
            };
        }
    }
}
