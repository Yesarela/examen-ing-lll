using System;

namespace MyAgendaApp.Models
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Departamento { get; set; }
        public string Municipio { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Profesion { get; set; }
        public string Puesto { get; set; }
        public double Salario { get; set; }
    }
}