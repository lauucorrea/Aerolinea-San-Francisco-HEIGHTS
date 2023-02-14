using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace Sql_Aerolinea
{
    public class Tabla_Aviones
    {

        //SqlCommand sqlCommand;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        public Tabla_Aviones()
        {
            sqlConnection = new SqlConnection(@"Server=.;Database=BDaerolinea;Trusted_Connection=True;");
        }

        public void SubirAvionBD(Avion unAvion)
        {
            try
            {
                int ofreceComida = unAvion.OfreceComida ? 1 : 0;

                if (!ExisteAvionBD(unAvion))
                {
                    sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandText = $"INSERT INTO Tabla_Aviones VALUES ('{ofreceComida}','{unAvion.CantidadDeToilets}',{unAvion.CapacidadBodega},0,'{unAvion.TotalAsientos}','0','{unAvion.MatriculaAvion}')";
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandType = CommandType.Text;

                    if (sqlConnection is not null && sqlConnection.State != ConnectionState.Open)
                    {
                        sqlConnection.Open();

                        int rows = sqlCommand.ExecuteNonQuery();

                        if (rows <= 0)
                        {
                            throw new Exception("Error al insertar datos a la base");
                        }
                    }
                    else
                    {
                        throw new Exception("No se pudo establecer conexion");
                    }
                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (sqlConnection != null && sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }

            }
        }

        public bool ExisteAvionBD(Avion unAvion)
        {
            try
            {
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = $"SELECT * FROM Tabla_Aviones WHERE Matricula ='{unAvion.MatriculaAvion}'";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;

                bool existe = false;
                if (unAvion is not null)
                {
                    if (sqlConnection != null && sqlConnection.State != ConnectionState.Open)
                    {
                        sqlConnection.Open();
                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        while (reader.Read())
                        {
                            string matricula = reader["Matricula"].ToString();

                            if (matricula == unAvion.MatriculaAvion)
                            {
                                existe = true;
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("No se pudo establecer conexion");
                    }
                }
                else
                {
                    throw new NullReferenceException("La persona buscada no es valida");
                }
                return existe;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (sqlConnection != null && sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }

            }

        }
        /*public bool ActualizarPersonasBD(List<Persona> personasCargadas)
       {
           using (sqlConnection)
           {

           }
       }*/
        public List<Avion> ObtenerAvionesBD()
        {
            try
            {
                List<Avion> avionesObtenidos = new();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "SELECT * FROM Tabla_Aviones";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;

                if (sqlConnection != null && sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        bool ofreceComida = reader.GetBoolean("Ofrece_Comida");
                        int cantidadToilets = Convert.ToInt32(reader["Cantidad_Toilets"]);
                        decimal capacidadBodega = Convert.ToDecimal(reader["Capacidad_Bodega"]);
                        decimal cargaActualBodega = Convert.ToDecimal(reader["Carga_Actual_Bodega"]);
                        int totalAsientos = Convert.ToInt32(reader["Total_Asientos"]);
                        int horasVuelo = Convert.ToInt32(reader["Horas_Vuelo"]);
                        string matricula = reader["Matricula"].ToString();

                        Avion avion = new(ofreceComida,cantidadToilets,capacidadBodega,totalAsientos,matricula);
                        if(avion is not null)
                        {
                            avionesObtenidos.Add(avion);
                        }
                    }
                }

                return avionesObtenidos;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (sqlConnection != null && sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

        }
       
    }
}
