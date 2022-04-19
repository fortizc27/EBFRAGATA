using System;
using System.Collections.Generic;
using BD;
using Entity;

namespace BL
{
    public interface IFichasTecService
    {
        IDataAccess sql { get; set; }
        BDEntity Create(FichasTecEntity entity);
        IEnumerable<FichasTecEntity> Get();
        FichasTecEntity GetById(FichasTecEntity entity);
        IEnumerable<FichasTecEntity> GetLista(FichasTecEntity entity);
    }

    public class FichasTecService : IFichasTecService
    {
        public IDataAccess sql { get; set; }

        public FichasTecService()
        {
            sql = new DataAccess();
        }

        public IEnumerable<FichasTecEntity> Get()
        {
            try
            {
                var result = sql.Query<FichasTecEntity>("FichaTecObtener");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public FichasTecEntity GetById(FichasTecEntity entity)
        {
            try
            {
                var result = sql.QueryFirst<FichasTecEntity>("FichaTecObtener", new
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

        public IEnumerable<FichasTecEntity> GetLista(FichasTecEntity entity)
        {
            try
            {
                var result = sql.Query<FichasTecEntity>("FichaTecObtener", new
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

        public BDEntity Create(FichasTecEntity entity)
        {
            try
            {
                var result = sql.Execute("FichaTecInsertar", new
                {
                    entity.Fecha,
                    entity.Nombre,
                    entity.IdAtleta,
                    entity.Padecimientos,
                    entity.Peso,
                    entity.Altura,
                    entity.Lateralidad,
                    entity.Alcance,
                    entity.Talla,
                    entity.Pecho,
                    entity.Abdomen,
                    entity.Gluteo,
                    entity.BicepD,
                    entity.BicepI,
                    entity.MusloD,
                    entity.MusloI,
                    entity.PantorrillaD,
                    entity.PantorrillaI
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

