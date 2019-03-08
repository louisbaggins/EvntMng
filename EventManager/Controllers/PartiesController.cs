using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventManager.Models;
using EventManager.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartiesController : ControllerBase
    {
        private readonly static List<Parties> _parties = new List<Parties>();
        private readonly PartyHelper _partyHelper = new PartyHelper();
        private readonly PartyService _partyRequest = new PartyService();
        // GET: api/Parties
        [HttpPost("resgister-parties")]
        public void RegisterParties(string name, string course, string university, int day, int month, int time, string description, int price = 0)
        {
            try
            {
                _parties.Add(new Parties
                {
                    course = course,
                    name = name,
                    //date = new Date(day,time),
                    price = price,
                    description = description,
                    university = university

                });
            }

            catch
            {
                _parties.Add(new Parties
                {
                    course = "Erro ao cadastrar",
                    name = "Nome",
                    //date = new Date(25, 2),
                    price = 0,
                    description = "description",
                    university = "university"

                });
            }
        }

        // GET: api/Parties
        [HttpGet("get-parties")]
        public async Task<List<Parties>> GetParties()
        {
            return _parties;
        }

        // GET: api/Parties/byUniversity
        [HttpGet("get-parties-university")]
        public async Task<List<Parties>> GetPartiesByUniversityAsync(string university)
        {
            return await _partyHelper.FilterPartieByUniversityAsync(_parties, university);
        }

        // GET: api/Parties/byCourse
        [HttpGet("get-parties-course")]
        public async Task<List<Parties>> GetPartiesByCourseAsync(string course)
        {
            return await _partyHelper.FilterPartieByCourseAsync(_parties, course);
        }

        // GET: api/Parties
        [HttpGet("get-parties-api")]
        public async Task<List<Parties>> GetPartiesApiAsync()
        {

            return await _partyRequest.GetPartiesAsync(); 
        }
        // POST: api/Parties
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Parties/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
