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
  public class AnimalsController : ControllerBase
  {
    [HttpGet]
    public ActionResult<IEnumerable<APIAnimals>> GetAction()
    {
      var db = new APIAnimalsContext();
      var Animals = db.APIAnimals.OrderBy(animal => animal.Species);
      return Animals.ToList();
    }
    [HttpPost]
    public ActionResult<APIAnimals> AddAnimal([FromBody] APIAnimals AddedAnimal)
    {
      var db = new APIAnimalsContext();
      db.APIAnimals.Add(AddedAnimal);
      db.SaveChanges();
      return AddedAnimal;
    }
    // [HttpGet]
    // public ActionResult<APIAnimals> GetLocation([FromRoute] APIAnimals Location)
    // {
    //   var db = new APIAnimalsContext();
    //   var result = db.APIAnimals.Where(animal => animal.LocationOfLastSeen == Location.ToString());
    //   return result.ToList();
    // }
    [HttpPut]
    public ActionResult<APIAnimals> AddSighting([FromRoute] APIAnimals animal)
    {
      var db = new APIAnimalsContext();
      var SelectedAnimal = db.APIAnimals.Where(animals => animals.Species == animal.ToString());

      db.SaveChanges();
    }
    [HttpDelete]
    pu
  }
}