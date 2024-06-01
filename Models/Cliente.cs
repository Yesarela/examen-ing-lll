using System;

namespace MyAgendaApp.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Compania { get; set; }
        public string Nota { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}