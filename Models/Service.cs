using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvcrud.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        [Display(Name = "Duracion Estimada")]
        public TimeSpan DuracionEstimada { get; set; }

        [NotMapped]
        [Range(0, 23, ErrorMessage = "Las horas deben estar entre 0 y 23")]
        public int DuracionHoras { get; set; }

        [NotMapped]
        [Range(0, 59, ErrorMessage = "Los minutos deben estar entre 0 y 59")]
        public int DuracionMinutos { get; set; }
    }
}
