using Autorizacion.Abstracciones.DA;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace Autorizacion.DA.Repositorios
{
    public class RepositorioDapper : IRepositorioDapper
    {
        private readonly IConfiguration _configutarion;
        private SqlConnection _connection;

        public RepositorioDapper(IConfiguration configutarion, SqlConnection connection)
        {
            _configutarion = configutarion;
            _connection = new SqlConnection(_configutarion.GetConnectionString("BDPokemon"));
        }

        public SqlConnection ObtenerRepositorioDapper()
        {
            return _connection;
        }
    }
}
