using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DABhandin3Del2.Interfaces;
using DABhandin3Del2.Models;
using DABhandin3Del2.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;
using todo;

namespace DABhandin3Del2.Controllers
{
    [Produces("application/json")]
    [Route("api/Person")]

    public class PersonController : Controller
    {
        private IDocumentDBRepository<Person> iprep;

        public PersonController(IDocumentDBRepository<Person> personRepo)
        {
            this.iprep.GetAllItemsAsync();
        }

        // GET: api/Person
        [HttpGet]
        public virtual async Task<IQueryable<Person>> GetAllPersons()
        {
            return await iprep.GetAllItemsAsync();
        }

        // GET: api/Person/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPerson([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var person = await iprep.GetItemAsync(id.ToString());

            if (person == null)
            {
                return NotFound();
            }

            return Ok(person);
        }

        // PUT: api/Person/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPerson(string id, [FromBody] Person person)
        {
            var per = iprep.GetItemsAsync(p => p.id == id);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != null)
            {
                return NotFound();
            }

            await iprep.UpdateItemAsync(id.ToString(), person);
            return Ok(per);
        }

        // POST: api/Person
        [HttpPost]
        public async Task<IActionResult> PostPerson([FromBody] Person person)
        {
            await iprep.CreateItemAsync(person);
            return Ok(person);
        }

        // DELETE: api/Person/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerson([FromRoute] string id)
        {
            await iprep.DeleteItemAsync(id);
            return Ok();
        }

        //private bool PersonExists(int id)
        //{
        //    return _context.Persons.Any(e => e.PersonID == id);
        //}
    }

}
