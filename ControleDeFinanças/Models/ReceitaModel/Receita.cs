using ControleDeFinanças.Enums;
using System.Globalization;

namespace ControleDeFinanças.Models.ReceitaModel
{
    public class Receita
    {
        public double ReceitaMensal {  get; private set; }
        public MesEnum MesDeRegistro {  get; private set; }
        public int AnoDeRegistro { get; private set; }
     
        public Receita(double receitaMensal, MesEnum mesDeRegistro, int anoDeRegistro) 
        {
            ReceitaMensal = receitaMensal;
            MesDeRegistro = mesDeRegistro;
            AnoDeRegistro = anoDeRegistro;
        }
    }
}
