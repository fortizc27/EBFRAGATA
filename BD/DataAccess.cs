using System;
using System.Collections.Generic;
using Dapper;
using Dapper.Mapper;
using System.Data.SqlClient;
using System.Configuration;
using Entity;

namespace BD
{
    public class DataAccess : IDataAccess, IDataAccessConnection
    {
        public SqlConnection DbConnection => new SqlConnection(

                new SqlConnectionStringBuilder(ConfigurationManager.AppSettings["Conn"]).ConnectionString);

        //LISTA DE 1 RELACION
        public IEnumerable<T> Query<T>(string sp, object Param = null, int? Timeout = null)
        {
            try
            {
                using (var exec = DbConnection)
                {
                    exec.Open();

                    var result = exec.Query<T>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure,
                        commandTimeout: Timeout);

                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //LISTA DINAMICA
        public IEnumerable<dynamic> Query(string sp, object Param = null, int? Timeout = null)
        {
            try
            {
                using (var exec = DbConnection)
                {
                    exec.Open();

                    var result = exec.Query(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure,
                        commandTimeout: Timeout);

                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //LISTA DE 2 RELACIONES
        public IEnumerable<T> Query<T, A>(string sp, string split, object Param = null, int? Timeout = null)
        {
            try
            {
                using (var exec = DbConnection)
                {
                    exec.Open();

                    var result = exec.Query<T, A>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure,
                        commandTimeout: Timeout, splitOn: split);

                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //LISTA DE 3 RELACIONES
        public IEnumerable<T> Query<T, A, B>(string sp, string split, object Param = null, int? Timeout = null)
        {
            try
            {
                using (var exec = DbConnection)
                {
                    exec.Open();

                    var result = exec.Query<T, A, B>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure,
                        commandTimeout: Timeout, splitOn: split);

                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //LISTO DE 4 RELACIONES
        public IEnumerable<T> Query<T, A, B, C>(string sp, string split, object Param = null, int? Timeout = null)
        {
            try
            {
                using (var exec = DbConnection)
                {
                    exec.Open();

                    var result = exec.Query<T, A, B, C>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure,
                        commandTimeout: Timeout, splitOn: split);

                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //LISTO DE 5 RELACIONES
        public IEnumerable<T> Query<T, A, B, C, D>(string sp, string split, object Param = null, int? Timeout = null)
        {
            try
            {
                using (var exec = DbConnection)
                {
                    exec.Open();

                    var result = exec.Query<T, A, B, C, D>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure,
                        commandTimeout: Timeout, splitOn: split);

                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //LISTA DE 6 RELACIONES
        public IEnumerable<T> Query<T, A, B, C, D, E>(string sp, string split, object Param = null, int? Timeout = null)
        {
            try
            {
                using (var exec = DbConnection)
                {
                    exec.Open();

                    var result = exec.Query<T, A, B, C, D, E>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure,
                        commandTimeout: Timeout, splitOn: split);

                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //LISTA DE 7 RELACIONES
        public IEnumerable<T> Query<T, A, B, C, D, E, F>(string sp, string split, object Param = null, int? Timeout = null)
        {
            try
            {
                using (var exec = DbConnection)
                {
                    exec.Open();

                    var result = exec.Query<T, A, B, C, D, E, F>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure,
                        commandTimeout: Timeout, splitOn: split);

                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //TRAE EL DETALLE DE UN OBJETO
        public T QueryFirst<T>(string sp, object Param = null, int? Timeout = null)
        {
            try
            {
                using (var exec = DbConnection)
                {
                    exec.Open();

                    var result = exec.QueryFirstOrDefault<T>(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure,
                        commandTimeout: Timeout);

                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //EJECUTAR ACCION DE INSERTAR
        public BDEntity Execute(string sp, object Param = null, int? Timeout = null)
        {
            try
            {
                using (var exec = DbConnection)
                {
                    exec.Open();

                    var result = exec.ExecuteReader(sql: sp, param: Param, commandType: System.Data.CommandType.StoredProcedure,
                        commandTimeout: Timeout);

                    result.Read();

                    return new BDEntity()
                    {
                        CodeError = result.GetInt32(0),
                        MsgError = result.GetString(1)
                    };
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //PRUEBA DE CONEXION DE LA BASE DE DATOS
        public bool TestConnection(string conn)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                try
                {
                    bool sqlconnection = false;
                    connection.Open();
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        sqlconnection = true;
                    }

                    return sqlconnection;
                }
                catch (SqlException)
                {

                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}

