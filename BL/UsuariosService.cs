using System;
using System.Collections.Generic;
using BD;
using Entity;

namespace BL
{
    public interface IUsuariosService
    {
        IDataAccess sql { get; set; }
        BDEntity Create(UsuariosEntity entity);
        BDEntity Delete(UsuariosEntity entity);
        IEnumerable<UsuariosEntity> Get();
        UsuariosEntity GetById(UsuariosEntity entity);
        IEnumerable<UsuariosEntity> GetLista();
        UsuariosEntity Login(UsuariosEntity entity);
        BDEntity Update(UsuariosEntity entity);
        bool Connection(string conn);
    }

    public class UsuariosService : IUsuariosService
    {
        public IDataAccess sql { get; set; }
        public IDataAccessConnection sqlconn { get; set; }

        public UsuariosService()
        {
            sql = new DataAccess();
            sqlconn = new DataAccess();
        }

        public IEnumerable<UsuariosEntity> Get()
        {
            try
            {
                var result = sql.Query<UsuariosEntity, RolesEntity>
                    ("UsuarioObtener", "IdUsuario, Rol");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<UsuariosEntity> GetLista()
        {
            try
            {
                var result = sql.Query<UsuariosEntity>("UsuarioObtener");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public UsuariosEntity GetById(UsuariosEntity entity)
        {
            try
            {
                var result = sql.QueryFirst<UsuariosEntity>("UsuarioObtener", new
                {
                    entity.IdUsuario
                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public BDEntity Create(UsuariosEntity entity)
        {
            try
            {
                var result = sql.Execute("UsuarioInsertar", new
                {
                    entity.Usuario,
                    entity.Clave,
                    entity.Rol,
                    entity.Estado
                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public BDEntity Update(UsuariosEntity entity)
        {
            try
            {
                var result = sql.Execute("UsuarioActualizar", new
                {
                    entity.IdUsuario,
                    entity.Usuario,
                    entity.Clave,
                    entity.Rol,
                    entity.Estado
                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public BDEntity Delete(UsuariosEntity entity)
        {
            try
            {
                var result = sql.Execute("UsuarioEliminar", new
                {
                    entity.IdUsuario
                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public UsuariosEntity Login(UsuariosEntity entity)
        {
            try
            {
                var result = sql.QueryFirst<UsuariosEntity>("UsuarioLogin", new
                {
                    entity.Usuario,
                    entity.Clave
                });

                return result;
            }
            catch (System.Data.SqlClient.SqlException)
            {
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Connection (string conn)
        {
            try
            {
                return sqlconn.TestConnection(conn);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}

