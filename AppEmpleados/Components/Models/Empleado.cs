﻿namespace AppEmpleados.Components.Models
{
    public class Empleado
    {

        public Empleado() { }


        public int id { get; set; }
        public string Nombre { get; set; }
        public string Apellido {  get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public int EstadoId { get; set; }
    }

    

}
