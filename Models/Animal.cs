using System;

namespace safariapi.Models
{
  public class APIAnimals
  {
    public int ID { get; set; }
    public string Species { get; set; }
    public int CountOfTimesSeen { get; set; }
    public string LocationOfLastSeen { get; set; }
  }
}