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
        public IEnumerable<Proffy> Get()
        {
            return _proffyService.Get();
        }

        [HttpGet]
        [Route("/{id}")]
        public IActionResult GetId(int id)
        {
            _proffyService.GetId(id);

            return Ok();
        }

        [HttpPost]
        public IActionResult Insert(Proffy proffy)
        {
            _proffyService.Add(proffy);
            return Created("Proffy adicionado com sucesso", proffy);
        }

        [HttpPatch]
        public IActionResult Update(Proffy proffy)
        {
            _proffyService.Update(proffy);
            return Ok(proffy);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _proffyService.Delete(id);
            return Ok("Proffy deletado com sucesso.");
        }
    }
}
