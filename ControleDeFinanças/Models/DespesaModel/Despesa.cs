using ControleDeFinanças.Enums;

namespace ControleDeFinanças.Models.DespesaModel
{
    public class Despesa
    {
        public double DespesaMensal { get; private set; }
        public MesEnum MesDeRegistro { get; private set; }
        public int AnoDeRegistro { get; private set; }
    }
}
