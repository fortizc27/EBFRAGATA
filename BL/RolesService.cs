using System;
using System.Collections.Generic;
using BD;
using Entity;

namespace BL
{
    public interface IRolesService
    {
        IDataAccess sql { get; set; }
        BDEntity Create(RolesEntity entity);
        BDEntity Delete(RolesEntity entity);
        IEnumerable<RolesEntity> Get();
        RolesEntity GetById(RolesEntity entity);
        IEnumerable<RolesEntity> GetLista();
        BDEntity Update(RolesEntity entity);
    }

    public class RolesService : IRolesService
    {
        public IDataAccess sql { get; set; }

        public RolesService()
        {
            sql = new DataAccess();
        }

        public IEnumerable<RolesEntity> Get()
        {
            try
            {
                var result = sql.Query<RolesEntity>("RolesObtener");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<RolesEntity> GetLista()
        {
            try
            {
                var result = sql.Query<RolesEntity>("RolesObtener");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public RolesEntity GetById(RolesEntity entity)
        {
            try
            {
                var result = sql.QueryFirst<RolesEntity>("RolesObtener", new
                {
                    entity.IdRol
                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public BDEntity Create(RolesEntity entity)
        {
            try
            {
                var result = sql.Execute("RolesInsertar", new
                {
                    entity.NombreRol,
                    entity.Usuarios,
                    entity.Roles,
                    entity.Clientes,
                    entity.FichasTecnicas,
                    entity.Peleas,
                    entity.Reportes,
                    entity.Bitacoras,
                    entity.Estado
                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public BDEntity Update(RolesEntity entity)
        {
            try
            {
                var result = sql.Execute("RolesActualizar", new
                {
                    entity.IdRol,
                    entity.NombreRol,
                    entity.Usuarios,
                    entity.Roles,
                    entity.Clientes,
                    entity.FichasTecnicas,
                    entity.Peleas,
                    entity.Reportes,
                    entity.Bitacoras,
                    entity.Estado
                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public BDEntity Delete(RolesEntity entity)
        {
            try
            {
                var result = sql.Execute("RolesEliminar", new
                {
                    entity.IdRol
                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}
