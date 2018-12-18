using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using safariapi.Models;

namespace safariapi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class SearchController : ControllerBase
  {

    [HttpGet]
    public ActionResult<IEnumerable<APIAnimals>> Search([FromQuery]string species)
    {
      var db = new APIAnimalsContext();
      var result = db.APIAnimals.Where(animals => animals.Species.ToLower().Contains(species.ToLower()));
      return result.ToList();
    }
  }
}