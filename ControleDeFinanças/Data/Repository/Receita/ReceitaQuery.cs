using ControleDeFinanças.Enums.Receita;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Globalization;

namespace ControleDeFinanças.Data.Repository.Receita
{
    public class ReceitaQuery
    {

        private readonly IConfiguration _configuration;

        public ReceitaQuery(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void QueryAdicionarReceita(double valorReceita, MesEnum mesDeRegistro, int anoDeRegistro)
        {
            var connectionString = _configuration.GetConnectionString("DefaultConnection");

            var postReceita = @"INSERT INTO Receitas (RECEITAMENSAL, MESDEREGISTRO,ANODEREGISTRO) values (@valorReceita, @mesDeRegistro, @anoDeRegistro);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                try
                {
                    connection.Open();
                    Console.WriteLine("Conexão bem-sucedida!");

                    using (SqlCommand command = new SqlCommand(postReceita, connection)) 
                    {
                        CultureInfo cultureInfo = new CultureInfo("pt-BR");
                        string valorReceitaFormatado = valorReceita.ToString("F2", cultureInfo);

                        command.Parameters.AddWithValue("@valorReceita", valorReceitaFormatado);
                        command.Parameters.AddWithValue("@mesDeRegistro", mesDeRegistro.ToString());
                        command.Parameters.AddWithValue("@anoDeRegistro", anoDeRegistro);

                        int linhasAfetadas = command.ExecuteNonQuery();

                        Console.WriteLine($"Número de linhas afetadas: {linhasAfetadas}");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
            }
        }

    }
}
