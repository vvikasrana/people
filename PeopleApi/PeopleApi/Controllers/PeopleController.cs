using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PeopleApi.Repository;
using PeopleApi.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PeopleApi.Controllers
{
    [Route("api/[controller]")]
    public class PeopleController : Controller
    {
        IPeopleRepository peopleRepository;
        public PeopleController(IPeopleRepository _peopleRepository)
        {
            peopleRepository = _peopleRepository;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(peopleRepository.GetList());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(peopleRepository.Find(id));
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]People people)
        {
            peopleRepository.Add(people);
            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]People people)
        {
            peopleRepository.Update(id, people);
            return Ok();
        }
    }
}
