﻿namespace MiEntityCore.Models
{
    public class Persona
    {
        public int PersonaId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Documento { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
