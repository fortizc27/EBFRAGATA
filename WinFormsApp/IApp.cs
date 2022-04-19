using BL;

namespace WinFormsApp
{
    public struct IApp
    {
        public static IBitacorasService bitacorasService => new BitacorasService();

        public static IClientesService clientesService => new ClientesService();

        public static IFichasTecService fichasTecService => new FichasTecService();

        public static IPeleasService peleasService => new PeleasService();

        public static IRolesService rolesService => new RolesService();

        public static IUsuariosService usuariosService => new UsuariosService();
    }
}
