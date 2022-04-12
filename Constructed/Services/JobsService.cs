using System.Collections.Generic;
using Constructed.Models;
using Constructed.Repositories;

namespace Constructed.Services
{
    public class JobsService
    {
        private readonly JobsRepository _jobsRepo;
        public JobsService(JobsRepository jobsRepo)
        {
            _jobsRepo = jobsRepo;
        }

        internal List<Job> GetAllCompanyJobs(int id)
        {
            return _jobsRepo.GetAllCompanyJobs(id);
        }

        internal Job Create(Job jobData)
        {
            return _jobsRepo.Create(jobData);
        }
    }
}