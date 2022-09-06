using Dapper;
using DapperDemo.Context;
using DapperDemo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo.Repositories
{
    internal class AgentRepository : IAgentRepository
    {
        private readonly DapperContext _context;

        public AgentRepository()
        {
            // replace with your db server connection string
            _context = new DapperContext("Data Source=JCA-PC;Initial Catalog=ValoDb;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;");
        }

        public int Add(Agent agent)
        {
            var sql = "INSERT INTO AGENT (Name, Country, Role) VALUES (@Name, @Country, @Role);" +
                "SELECT CAST(SCOPE_IDENTITY() as int);";

            using (var connection = _context.CreateConnection())
            {
                return connection.ExecuteScalar<int>(sql, new { agent.Name, agent.Country, agent.Role });
            }
        }

        public IEnumerable<Agent> GetAll()
        {
            var sql = "SELECT * FROM Agent";

            using (var connection = _context.CreateConnection())
            {
                return connection.Query<Agent>(sql);
            }
        }
    }
}
