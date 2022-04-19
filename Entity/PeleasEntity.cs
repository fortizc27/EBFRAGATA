using System;

namespace Entity
{
    public class PeleasEntity : BDEntity
    {
        public int? IdPelea { get; set; }

        public int? IdAtleta { get; set; }

        public string Nombre { get; set; }

        public DateTime Fecha { get; set; }

        public string Descripcion { get; set; }

        public string Contrincante { get; set; }

        public string Decision { get; set; }

        public string Observaciones { get; set; }

    }
}
