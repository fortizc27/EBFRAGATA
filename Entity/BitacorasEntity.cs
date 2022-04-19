using System;

namespace Entity
{
    public class BitacorasEntity : BDEntity
    {
        public int? IdBitacora { get; set; }

        public string Usuario { get; set; }

        public DateTime Registro { get; set; }

        public string Accion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
