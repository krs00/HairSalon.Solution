namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public int StylistId { get; set; } // FOREIGN KEY PROPERTY!!
    public Stylist Stylist { get; set; } // NAVIGATION PROPERTY!!
  }
}