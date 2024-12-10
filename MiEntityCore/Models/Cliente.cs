namespace MiEntityCore.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; }
    }
}
