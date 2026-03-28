using Microsoft.Extensions.Options;

namespace BibliotecaAPI
{
    public class PagosProcesamiento
    {
        private TarifaOpciones _tarifaOpciones;

        public PagosProcesamiento(IOptionsMonitor<TarifaOpciones> optionsMonitor)
        {
            _tarifaOpciones = optionsMonitor.CurrentValue;

            optionsMonitor.OnChange(nuevaTarifa =>
            {
                Console.WriteLine("Tarifa actualizada");
                _tarifaOpciones = nuevaTarifa;
            });
        }

        public void ProcesarPago()
        {
            //Aqui Procesamos las tarifas
        }

        public TarifaOpciones ObtenerTarifas()
        {
            return _tarifaOpciones;
        }
    }
}
