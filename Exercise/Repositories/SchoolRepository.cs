using DapperDemo.Context;
using DapperDemo.Models;

namespace DapperDemo.Repositories
{
    internal class SchoolRepository : ISchoolRepository
    {
        DapperContext _context;
        public SchoolRepository()
        {
            // TODO : Change database connection string 
            // how to get connection string: https://www.c-sharpcorner.com/UploadFile/d40a40/get-sql-server-database-connection-string-easily-from-visual
            _context = new DapperContext("YOUR_DATABASE_CONNECTION_STRING");
        }

        // TODO: Implement me
        public int AddSchool(School school)
        {
            throw new NotImplementedException();
        }

        // TODO: Implement me
        public bool DeleteSchool(int id)
        {
            throw new NotImplementedException();
        }

        // TODO: Implement me
        public IEnumerable<School> GetAllSchools()
        {
            throw new NotImplementedException();
        }

        // TODO: Implement me
        public School GetSchool(int id)
        {
            throw new NotImplementedException();
        }

        // TODO: Implement me
        public bool UpdateSchool(School school)
        {
            throw new NotImplementedException();
        }
    }
}
