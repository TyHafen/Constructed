using System.Collections.Generic;
using System.Data;
using System.Linq;
using Constructed.Models;
using Dapper;

namespace Constructed.Repositories
{
    public class CompaniesRepository
    {
        private readonly IDbConnection _db;
        public CompaniesRepository(IDbConnection db)
        {
            _db = db;
        }

        internal Company GetById(int id)
        {
            string sql = @"SELECT * FROM companies WHERE companies.id = @id;";
            return _db.Query<Company>(sql, new { id }).FirstOrDefault();
        }

        internal List<Company> GetAll()
        {
            string sql = @"SELECT * FROM companies;";
            return _db.Query<Company>(sql).ToList();
        }

        internal string Delete(int id)
        {
            string sql = @"DELETE FROM companies WHERE id = @id LIMIT 1;";
            int rowsAffected = _db.Execute(sql, new { id });
            if (rowsAffected > 0)
            {
                return "deleted";
            }
            throw new System.Exception("couldnt delete");
        }

        internal Company Create(Company companyData)
        {
            string sql = @"INSERT INTO companies (name, location)
            VALUES (@Name, @Location); 
             SELECT LAST_INSERT_ID();";
            int id = _db.ExecuteScalar<int>(sql, companyData);
            companyData.Id = id;
            return companyData;
        }
    }
}