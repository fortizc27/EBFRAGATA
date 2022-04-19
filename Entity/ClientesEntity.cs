using System;

namespace Entity
{
    public class ClientesEntity : BDEntity
    {
        public int? IdCliente { get; set; }

        public DateTime Fecha { get; set; }

        public string Categoria { get; set; }
        public int? Peso { get; set; }

        public string Nombre { get; set; }

        public string Genero { get; set; }

        public DateTime FechaNac { get; set; }

        public string Nacionalidad { get; set; }

        public string Correo { get; set; }

        public int Celular { get; set; }

        public int Particular { get; set; }

        public string Sangre { get; set; }

        public string Direccion { get; set; }

        public string NombreCE { get; set; }

        public Int64 IdCE { get; set; }

        public string GeneroCE { get; set; }

        public DateTime FechaNacCE { get; set; }

        public string NacionalidadCE { get; set; }

        public string CorreoCE { get; set; }

        public int CelularCE { get; set; }

        public int ParticularCE { get; set; }
    }
}
