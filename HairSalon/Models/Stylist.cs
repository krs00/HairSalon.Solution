using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int StylistId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Specialty { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public List <Client> Clients { get; set; } // NAVIGATION PROPERTY
  }
}