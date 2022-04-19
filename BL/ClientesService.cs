using System;
using System.Collections.Generic;
using BD;
using Entity;

namespace BL
{
    public interface IClientesService
    {
        IDataAccess sql { get; set; }
        BDEntity Create(ClientesEntity entity);
        BDEntity Delete(ClientesEntity entity);
        IEnumerable<ClientesEntity> Get();
        ClientesEntity GetById(ClientesEntity entity);
        IEnumerable<ClientesEntity> GetLista();
        IEnumerable<ClientesEntity> GetCategoria(ClientesEntity entity);
        BDEntity Update(ClientesEntity entity);
    }

    public class ClientesService : IClientesService
    {
        public IDataAccess sql { get; set; }

        public ClientesService()
        {
            sql = new DataAccess();
        }

        public IEnumerable<ClientesEntity> Get()
        {
            try
            {
                var result = sql.Query<ClientesEntity>("ClienteObtener");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<ClientesEntity> GetLista()
        {
            try
            {
                var result = sql.Query<ClientesEntity>("ClienteObtener");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<ClientesEntity> GetCategoria(ClientesEntity entity)
        {
            try
            {
                var result = sql.Query<ClientesEntity>("ClienteObtenerCategoria", new 
                {
                    entity.Categoria
                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ClientesEntity GetById(ClientesEntity entity)
        {
            try
            {
                var result = sql.QueryFirst<ClientesEntity>("ClienteObtener", new
                {
                    entity.IdCliente
                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public BDEntity Create(ClientesEntity entity)
        {
            try
            {
                var result = sql.Execute("ClienteInsertar", new
                {
                    entity.IdCliente,
                    entity.Fecha,
                    entity.Categoria,
                    entity.Nombre,
                    entity.Genero,
                    entity.FechaNac,
                    entity.Nacionalidad,
                    entity.Correo,
                    entity.Celular,
                    entity.Particular,
                    entity.Sangre,
                    entity.Direccion,
                    entity.NombreCE,
                    entity.IdCE,
                    entity.GeneroCE,
                    entity.FechaNacCE,
                    entity.NacionalidadCE,
                    entity.CorreoCE,
                    entity.CelularCE,
                    entity.ParticularCE
                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public BDEntity Update(ClientesEntity entity)
        {
            try
            {
                var result = sql.Execute("ClienteActualizar", new
                {
                    entity.IdCliente,
                    entity.Fecha,
                    entity.Categoria,
                    entity.Nombre,
                    entity.Genero,
                    entity.FechaNac,
                    entity.Nacionalidad,
                    entity.Correo,
                    entity.Celular,
                    entity.Particular,
                    entity.Sangre,
                    entity.Direccion,
                    entity.NombreCE,
                    entity.IdCE,
                    entity.GeneroCE,
                    entity.FechaNacCE,
                    entity.NacionalidadCE,
                    entity.CorreoCE,
                    entity.CelularCE,
                    entity.ParticularCE
                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public BDEntity Delete(ClientesEntity entity)
        {
            try
            {
                var result = sql.Execute("ClienteEliminar", new
                {
                    entity.IdCliente
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

