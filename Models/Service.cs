using System.ComponentModel.DataAnnotations;

namespace mvcrud.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        [Display(Name = "Duracion Estimada")]
        public TimeSpan DuracionEstimada { get; set; }
    }
}
