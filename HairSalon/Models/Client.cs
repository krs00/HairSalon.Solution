using System.ComponentModel.DataAnnotations;

namespace HairSalon.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "You must add a stylist before you add any clients!")]
        public int StylistId { get; set; } // FOREIGN KEY PROPERTY!!

        public Stylist Stylist { get; set; } // REFERENCE NAVIGATION PROPERTY!!
    }
}
