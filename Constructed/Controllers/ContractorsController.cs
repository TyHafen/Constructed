
using Microsoft.AspNetCore.Mvc;

using Constructed.Services;
using System.Collections.Generic;
using Constructed.Models;

namespace Constructed.Controllers
{

    [ApiController]
    [Route("api/[Controller]")]
    public class ContractorsController : ControllerBase
    {
        private readonly ContractorsService _contractorsService;
        public ContractorsController(ContractorsService contractorsService)
        {
            _contractorsService = contractorsService;
        }

        [HttpGet]
        public ActionResult<List<Contractor>> GetAll()
        {
            try
            {
                List<Contractor> contractors = _contractorsService.GetAll();
                return Ok(contractors);
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }

        }


        [HttpGet("{id}")]
        public ActionResult<Contractor> GetById(int id)
        {
            try
            {
                Contractor contractor = _contractorsService.GetById(id);
                return Ok(contractor);

            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }


        }
        [HttpPost]
        public ActionResult<Contractor> Create([FromBody] Contractor contractorData)
        {
            try
            {
                Contractor contractor = _contractorsService.Create(contractorData);
                return Ok(contractor);
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
                _contractorsService.Delete(id);
                return "deleted";
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }
        }


    }
}