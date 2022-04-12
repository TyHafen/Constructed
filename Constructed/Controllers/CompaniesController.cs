using System.Collections.Generic;
using Constructed.Models;
using Constructed.Services;
using Microsoft.AspNetCore.Mvc;

namespace Constructed.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CompaniesController : ControllerBase
    {
        private readonly CompaniesService _companiesService;
        private readonly JobsService _jobsService;


        public CompaniesController(CompaniesService companiesService, JobsService jobsService)
        {
            _companiesService = companiesService;
            _jobsService = jobsService;
        }

        [HttpGet]
        public ActionResult<List<CompaniesController>> GetAll()
        {
            try
            {
                List<Company> companies = _companiesService.GetAll();
                return Ok(companies);
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Company> GetById(int id)
        {
            try
            {
                Company company = _companiesService.GetById(id);
                return Ok(company);
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }

        }
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {


            try
            {
                _companiesService.Delete(id);
                return Ok("The company went under");
            }
            catch (System.Exception e)
            {

                return (e.Message);
            }
        }
        [HttpPost]
        public ActionResult<Company> Create([FromBody] Company companyData)
        {
            try
            {
                Company company = _companiesService.Create(companyData);
                return Ok(company);
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }

        }

        [HttpGet("{id}/jobs")]
        public ActionResult<List<Job>> GetAllCompanyJobs(int id)
        {
            try
            {
                List<Job> companyJobs = _jobsService.GetAllCompanyJobs(id);
                return Ok(companyJobs);
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }
        }



    }
}