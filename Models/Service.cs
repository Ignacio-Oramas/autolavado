namespace mvcrud.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public TimeSpan DuracionEstimada { get; set; }
    }
}
