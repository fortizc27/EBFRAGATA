namespace Entity
{
    public class UsuariosEntity : BDEntity
    {
        public UsuariosEntity()
        {
            Roles = Roles ?? new RolesEntity();
        }
        public int? IdUsuario { get; set; }

        public string Usuario { get; set; }

        public string Clave { get; set; }

        public int Rol { get; set; }
        public virtual RolesEntity Roles { get; set; }
        public string NombreRolColumn => Roles?.NombreRol;

        public bool Estado { get; set; }

    }
}
