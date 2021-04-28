using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using react1.Infrastructure;
using react1.Models;

namespace react1.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MediaController : ControllerBase
  {
    private readonly IMediaStore m_Store;

    public MediaController(IMediaStore store) { m_Store = store; }

    [HttpGet]
    [ProducesResponseType((int) HttpStatusCode.NoContent)]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public IEnumerable<MediaListing> Get()
      => m_Store.GetAll().Listings.AsEnumerable();

    // TODO: Add Model Validation Logic

    [HttpPost]
    [ProducesResponseType((int)HttpStatusCode.Created)]
    [ProducesResponseType((int)HttpStatusCode.Conflict)]
    public IActionResult Add(MediaListing listing)
      => m_Store.Add(listing) ? StatusCode((int)HttpStatusCode.Created) : Conflict();
  }
}
