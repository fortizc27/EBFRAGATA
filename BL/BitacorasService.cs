using System;
using System.Data;
using System.Collections.Generic;
using BD;
using Entity;

namespace BL
{
    public interface IBitacorasService
    {
        IDataAccess sql { get; set; }
        BDEntity Create(BitacorasEntity entity);
        IEnumerable<BitacorasEntity> Get();
        BitacorasEntity GetById(BitacorasEntity entity);
        IEnumerable<BitacorasEntity> GetByUser(BitacorasEntity entity);
        IEnumerable<BitacorasEntity> GetLista();
    }

    public class BitacorasService : IBitacorasService
    {

        public IDataAccess sql { get; set; }

        public BitacorasService()
        {
            sql = new DataAccess();
        }

        public IEnumerable<BitacorasEntity> Get()
        {
            try
            {
                var result = sql.Query<BitacorasEntity>("BitacoraObtener");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public BitacorasEntity GetById(BitacorasEntity entity)
        {
            try
            {
                var result = sql.QueryFirst<BitacorasEntity>("BitacoraObtener", new
                {
                    entity.IdBitacora
                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<BitacorasEntity> GetByUser(BitacorasEntity entity)
        {
            try
            {
                var result = sql.Query<BitacorasEntity>("BitacoraObtenerUsuario", new
                {
                    entity.Usuario,
                    entity.FechaInicio,
                    entity.FechaFin
                });

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<BitacorasEntity> GetLista()
        {
            try
            {
                var result = sql.Query<BitacorasEntity>("BitacoraObtener");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public BDEntity Create(BitacorasEntity entity)
        {
            try
            {
                var result = sql.Execute("BitacoraInsertar", new
                {
                    entity.Usuario,
                    entity.Registro,
                    entity.Accion
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
