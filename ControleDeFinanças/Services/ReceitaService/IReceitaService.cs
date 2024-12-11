using ControleDeFinanças.Enums;
using ControleDeFinanças.Models.ReceitaModel;

namespace ControleDeFinanças.Services.ReceitaService
{
    public interface IReceitaService
    {
        void AdicionarReceita(double valorReceita, MesEnum mesDeRegistro, int anoDeRegistro);
        string BuscarReceitaMensal(MesEnum mesDeRegistro, int anoDeRegistro);
    }
}
