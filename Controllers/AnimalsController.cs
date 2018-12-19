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
    [HttpPost("{AddedAnimal}")]
    public ActionResult<APIAnimals> AddAnimal([FromBody] APIAnimals AddedAnimal)
    {
      var db = new APIAnimalsContext();
      db.APIAnimals.Add(AddedAnimal);
      db.SaveChanges();
      return AddedAnimal;
    }
    [HttpGet("{Location}")]
    public ActionResult<IEnumerable<APIAnimals>> GetLocation([FromRoute] string Location)
    {
      var db = new APIAnimalsContext();
      var result = db.APIAnimals.Where(animal => animal.LocationOfLastSeen.Contains(Location.ToString()));
      return result.ToList();
    }
    [HttpPut("{animal}")]
    public ActionResult<APIAnimals> AddSighting([FromRoute] string animal)
    {
      var db = new APIAnimalsContext();
      var SelectedAnimal = db.APIAnimals.FirstOrDefault(animals => animals.Species == animal.ToString());
      if (SelectedAnimal == null)
      {
        return NotFound();
      }
      else
      {
        SelectedAnimal.CountOfTimesSeen++;
        db.SaveChanges();
        return SelectedAnimal;
      }
    }
    [HttpDelete("{id}")]
    public ActionResult<APIAnimals> DeleteAction([FromRoute] int id)
    {
      var db = new APIAnimalsContext();
      var AnimalToDelete = db.APIAnimals.FirstOrDefault(animals => animals.ID == id);
      db.APIAnimals.Remove(AnimalToDelete);
      db.SaveChanges();
      return AnimalToDelete;
    }
  }
}