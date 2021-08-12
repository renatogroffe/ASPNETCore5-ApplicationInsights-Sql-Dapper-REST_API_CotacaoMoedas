using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Dapper;
using APIMoedas.Models;

namespace APIMoedas.Data
{
    public class CotacoesRepository
    {
        private readonly IConfiguration _configuration;

        public CotacoesRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IEnumerable<Cotacao> GetAll()
        {
            using (var conexao = new SqlConnection(
                _configuration.GetConnectionString("BaseMoedas")))
            {
                return conexao.Query<Cotacao>(
                    "SELECT * FROM dbo.Cotacoes");
            }
        }
    }
}