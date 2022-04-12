using System;
using Constructed.Models;
using Constructed.Services;
using Microsoft.AspNetCore.Mvc;

namespace Constructed.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobsController
    {
        private readonly JobsService _jobsService;
        public JobsController(JobsService jobsService)
        {
            _jobsService = jobsService;
        }
        [HttpPost]
        public ActionResult<Job> Create([FromBody] Job jobData)
        {
            try
            {
                Job job = _jobsService.Create(jobData);
                return Ok(jobData);
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }

        }

        private ActionResult<Job> BadRequest(string message)
        {
            throw new NotImplementedException();
        }
    }
}