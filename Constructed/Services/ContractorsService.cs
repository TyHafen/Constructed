using System;
using System.Collections.Generic;
using Constructed.Models;
using Constructed.Repositories;

namespace Constructed.Services
{
    public class ContractorsService
    {
        private readonly ContractorsRepository _contractorsRepo;
        public ContractorsService(ContractorsRepository contractorsRepo)
        {
            _contractorsRepo = contractorsRepo;
        }

        internal List<Contractor> GetAll()
        {
            return _contractorsRepo.GetAll();
        }

        internal Contractor GetById(int id)
        {
            return _contractorsRepo.GetById(id);
        }

        internal Contractor Create(Contractor contractorData)
        {
            return _contractorsRepo.Create(contractorData);
        }

        internal string Delete(int id)
        {
            return _contractorsRepo.Delete(id);

        }
    }



}