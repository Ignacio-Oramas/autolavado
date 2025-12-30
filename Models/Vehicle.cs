using System.ComponentModel.DataAnnotations;

namespace mvcrud.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Placa { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;

        // Foreign Key
        public int ClientId { get; set; }
        // Navigation Property
        [Display(Name = "Cliente")]
        public Client? Client { get; set; }
    }
}
