using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProffyApi.Interfaces;
using ProffyApi.Model;
using ProffyApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProffyApi.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class ProffyController : ControllerBase
    {
        IProffyService _proffyService;

        public ProffyController( IProffyService proffyService)
        {
            _proffyService = proffyService;
        }

        [HttpGet]
        public IEnumerable<Proffy> GetProffys()
        {
            return _proffyService.GetProffys();
        }

        [HttpGet]
        [Route("/{id}")]
        public IActionResult GetProffyId(int id)
        {
            _proffyService.GetProffyId(id);

            return Ok();
        }

        [HttpPost]
        public IActionResult InsertProffy(Proffy proffy)
        {
            _proffyService.AddProffy(proffy);
            return Created("Proffy adicionado com sucesso", proffy);
        }

        [HttpPatch]
        public IActionResult UpdateProffy(Proffy proffy)
        {
            _proffyService.UpdateProffy(proffy);
            return Ok(proffy);
        }

        [HttpDelete]
        public IActionResult DeleteProffy(int id)
        {
            _proffyService.DeleteProffy(id);
            return Ok("Proffy deletado com sucesso.");
        }
    }
}
