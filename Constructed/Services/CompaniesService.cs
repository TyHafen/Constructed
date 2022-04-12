
using System.Collections.Generic;
using Constructed.Models;
using Constructed.Repositories;

namespace Constructed.Services
{
    public class CompaniesService
    {
        private readonly CompaniesRepository _companiesRepo;
        public CompaniesService(CompaniesRepository companiesRepo)
        {
            _companiesRepo = companiesRepo;
        }

        internal Company GetById(int id)
        {
            return _companiesRepo.GetById(id);
        }

        internal List<Company> GetAll()
        {
            return _companiesRepo.GetAll();
        }

        internal string Delete(int id)
        {
            return _companiesRepo.Delete(id);
        }

        internal Company Create(Company companyData)
        {
            return _companiesRepo.Create(companyData);
        }
    }
}