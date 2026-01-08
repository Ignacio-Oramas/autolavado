using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mvcrud.Models
{
    public class Empleado
    {
		
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
		public string Apellido { get; set; } = string.Empty;
		public string Puesto { get; set; } = string.Empty;
		[DisplayName ("Fecha de Nacimiento" )]
		[DataType(DataType.Date)]
		public DateTime FechaNacimiento { get; set; } = DateTime.Now;

		public string Pais { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
        public string Dirreccion { get; set; } = string.Empty;
        public string Ciudad { get; set; } = string.Empty;
		[DisplayName ("Numero de Telefono" )]
		public string NumeroTelefono { get; set; } = string.Empty;
		[DisplayName ("Creado por" )]
		public string CreadoPor { get; set; } = string.Empty;
		[DisplayName ("Fecha de creacion" )]
		public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;



	}
}
