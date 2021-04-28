using Microsoft.AspNetCore.Mvc;
using react1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace react1.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class SkillController : ControllerBase
  {
    // GET: api/<Skill>
    [HttpGet]
    public IEnumerable<Skill> Get()
    {
      return new Skill[] {
        new Skill("SQL",SkillStrength.Expert),
        new Skill("C#",SkillStrength.Expert),
        new Skill("HTML",SkillStrength.Proficient),
        new Skill("React.js",SkillStrength.Basic)
      };
    }

    // GET api/<Skill>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return "value";
    }

    // POST api/<Skill>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<Skill>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<Skill>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
