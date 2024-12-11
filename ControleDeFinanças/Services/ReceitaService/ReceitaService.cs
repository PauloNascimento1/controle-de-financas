using ControleDeFinanças.Data.Repository.Receita;
using ControleDeFinanças.Enums;
using ControleDeFinanças.Models.ReceitaModel;



namespace ControleDeFinanças.Services.ReceitaService
{
    public class ReceitaService : IReceitaService
    {

        private readonly ReceitaQuery _receitaQuery;

        public ReceitaService(ReceitaQuery receitaQuery)
        {
            _receitaQuery = receitaQuery;
        }

        public void AdicionarReceita(double valorReceita, MesEnum mesDeRegistro, int anoDeRegistro)
        {
            //Receita receita = new Receita(valorReceita, mesDeRegistro, anoDeRegistro);

            _receitaQuery.QueryAdicionarReceita(valorReceita, mesDeRegistro, anoDeRegistro);

        }

        public string BuscarReceitaMensal(MesEnum mesDeRegistro, int anoDeRegistro)
        {
            var retornoGetReceita = _receitaQuery.BuscarReceitaMensal( mesDeRegistro, anoDeRegistro);

            return retornoGetReceita;
        }



    }
}
