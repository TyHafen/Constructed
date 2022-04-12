using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Constructed.Interface;
using Constructed.Models;
using Dapper;

namespace Constructed.Repositories
{
    public class ContractorsRepository : IRepo<Contractor, int>
    {
        private readonly IDbConnection _db;
        public ContractorsRepository(IDbConnection db)
        {
            _db = db;
        }
        public Contractor Create(Contractor data)
        {
            string sql = "INSERT INTO contractors (name) VALUES (@Name); SELECT LAST_INSERT_ID();";
            int id = _db.ExecuteScalar<int>(sql, data);
            data.Id = id;
            return data;
        }

        public List<Contractor> GetAll()
        {
            string sql = "SELECT * FROM contractors";
            return _db.Query<Contractor>(sql).ToList();
        }

        internal string Delete(int id)
        {
            string sql = @"DELETE FROM contractors WHERe id = @id";
            int rowsAffected = _db.Execute(sql, new { id });
            if (rowsAffected > 0)
            {

                return "deleted";
            }
            throw new System.Exception("couldnt delete contractor");
        }

        internal Contractor GetById(int id)
        {
            string sql = @"Select * FROM contractors WHERE id = @id";
            return _db.Query<Contractor>(sql, new { id }).FirstOrDefault();
        }

        public Contractor GetViewModelById(int id)
        {
            throw new NotImplementedException();
        }

        public Contractor Update(Contractor data, int id, string userId)
        {
            throw new NotImplementedException();
        }
    }
}