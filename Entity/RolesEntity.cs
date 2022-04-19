namespace Entity
{
    public class RolesEntity : BDEntity
    {
        public int? IdRol { get; set; }

        public string NombreRol { get; set; }

        public bool Usuarios { get; set; }

        public bool Roles { get; set; }

        public bool Clientes { get; set; }

        public bool FichasTecnicas { get; set; }

        public bool Peleas { get; set; }

        public bool Reportes { get; set; }

        public bool Bitacoras { get; set; }

        public bool Estado { get; set; }

    }
}
