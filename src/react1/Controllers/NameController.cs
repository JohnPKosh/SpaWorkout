using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace react1.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class NameController : ControllerBase
  {

    // POST api/<NameController>
    [HttpPost]
    public void Post(NameModel value)
    {
      var name = value.Name;
    }


  }

  public class NameModel
  {
    public string Name { get; set; }

    public string Nick { get; set; }
  }
}
