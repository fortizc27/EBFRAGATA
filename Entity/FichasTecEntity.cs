using System;

namespace Entity
{
    public class FichasTecEntity : BDEntity
    {
        public int? IdFicha { get; set; }
        public DateTime Fecha { get; set; }

        public int? IdAtleta { get; set; }

        public string Nombre { get; set; }

        public string Padecimientos { get; set; }

        public decimal Peso { get; set; }

        public decimal Altura { get; set; }

        public string Lateralidad { get; set; }

        public decimal Alcance { get; set; }

        public string Talla { get; set; }

        public decimal Pecho { get; set; }

        public decimal Abdomen { get; set; }

        public decimal Gluteo { get; set; }

        public decimal BicepD { get; set; }

        public decimal BicepI { get; set; }

        public decimal MusloD { get; set; }

        public decimal MusloI { get; set; }

        public decimal PantorrillaD { get; set; }

        public decimal PantorrillaI { get; set; }
    }
}
