using System;
using System.Collections.Generic;
using BD;
using Entity;

namespace BL
{
    public interface IPeleasService
    {
        IDataAccess sql { get; set; }
        BDEntity Create(PeleasEntity entity);
        IEnumerable<PeleasEntity> Get();
        PeleasEntity GetById(PeleasEntity entity);
        IEnumerable<PeleasEntity> GetLista();
    }

    public class PeleasService : IPeleasService
    {
        public IDataAccess sql { get; set; }

        public PeleasService()
        {
            sql = new DataAccess();
        }

        public IEnumerable<PeleasEntity> Get()
        {
            try
            {
                var result = sql.Query<PeleasEntity>("PeleaObtener");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public PeleasEntity GetById(PeleasEntity entity)
        {
            try
            {
                var result = sql.QueryFirst<PeleasEntity>("PeleaObtener", new
                {
                    entity.IdAtleta
                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<PeleasEntity> GetLista()
        {
            try
            {
                var result = sql.Query<PeleasEntity>("PeleaObtener");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public BDEntity Create(PeleasEntity entity)
        {
            try
            {
                var result = sql.Execute("PeleaInsertar", new
                {
                    entity.IdAtleta,
                    entity.Nombre,
                    entity.Fecha,
                    entity.Contrincante,
                    entity.Descripcion,
                    entity.Decision,
                    entity.Observaciones
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

