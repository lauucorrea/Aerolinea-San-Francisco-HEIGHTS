using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace Sql_Aerolinea
{
    public class Tabla_Vuelos
    {

        //SqlCommand sqlCommand;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        public Tabla_Vuelos()
        {
            sqlConnection = new SqlConnection(@"Server=.;Database=BDaerolinea;Trusted_Connection=True;");
        }

        public void SubirVueloBD(Vuelo unVuelo)
        {
            try
            {

                if (!ExisteVueloBD(unVuelo))
                {
                    sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandText = $"INSERT INTO Tabla_Vuelos (MatriculaAvion,Origen,HoraPartida,HoraLlegada,Destino,EsInternacional,Costo,AsientosPremium,AsientosTurista,FechaVuelo) VALUES ('{unVuelo.AvionVuelo.MatriculaAvion}','{unVuelo.Origen}','{unVuelo.HoraPartida}','{unVuelo.HoraLlegada}','{unVuelo.Destino}','{unVuelo.EsInternacional}','{unVuelo.Costo}','{unVuelo.AsientosPremium}','{unVuelo.AsientosTurista}','{unVuelo.FechaVuelo}')";
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

        public bool ExisteVueloBD(Vuelo unVuelo)
        {
            try
            {
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = $"SELECT MatriculaAvion FROM Tabla_Vuelos WHERE FechaVuelo ={unVuelo.FechaVuelo}";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;

                bool existe = false;
                if (unVuelo is not null)
                {
                    if (sqlConnection != null && sqlConnection.State != ConnectionState.Open)
                    {
                        sqlConnection.Open();
                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        while (reader.Read())
                        {
                            string matricula = reader["MatriculaAvion"].ToString();

                            if (matricula == unVuelo.AvionVuelo.MatriculaAvion)
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
      /*  public List<Vuelo> ObtenerVuelosBD()
        {
            try
            {
                List<Vuelo> vuelosObtenidos = new();

                SqlCommand cmdObtenerVuelos = sqlConnection.CreateCommand();
                cmdObtenerVuelos.CommandText = "SELECT * FROM Tabla_Vuelos";
                cmdObtenerVuelos.Connection = sqlConnection;
                cmdObtenerVuelos.CommandType = CommandType.Text;

                SqlCommand cmdObtenerAvionVuelo = sqlConnection.CreateCommand();

                if (sqlConnection != null && sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();

                    SqlDataReader readerVuelos = cmdObtenerVuelos.ExecuteReader();

                    while (readerVuelos.Read())
                    {
                        int idVuelo = Convert.ToInt32(readerVuelos["IDVuelo"]);
                        string matricula = readerVuelos["MatriculaAvion"].ToString();
                        string origen = readerVuelos["Origen"].ToString();
                        string partida = readerVuelos["HoraPartida"].ToString();
                        string llegada = readerVuelos["HoraLlegada"].ToString();
                        string destino = readerVuelos["Destino"].ToString();
                        bool esInternacional = Convert.ToInt32(readerVuelos["EsInternacional"]) == 1 ? true : false;
                        float costo = float.Parse(readerVuelos["Costo"].ToString());
                        int cantidadPremium = Convert.ToInt32(readerVuelos["AsientosPremium"]);
                        int cantidadTurista = Convert.ToInt32(readerVuelos["AsientosTurista"]);
                        string fechaVuelo = readerVuelos["FechaVuelo"].ToString();

                        cmdObtenerAvionVuelo.CommandText = $"SELECT Matricula FROM Tabla_Aviones WHERE Matricula = {matricula}";
                        cmdObtenerAvionVuelo.Connection = sqlConnection;
                        cmdObtenerAvionVuelo.CommandType = CommandType.Text;

                        SqlDataReader readerAvion = cmdObtenerAvionVuelo.ExecuteReader();

                        while (readerAvion.Read())
                        {
                            bool ofreceComida = Convert.ToInt32(readerAvion["Ofrece_Comida"]) == 1 ? true : false;
                            int cantidadToilets = Convert.ToInt32(readerAvion["Cantidad_Toilets"]);
                            decimal capacidadBodega = Convert.ToDecimal(readerAvion["Capacidad_Bodega"]);
                            decimal cargaActualBodega = Convert.ToDecimal(readerAvion["Carga_Actual_Bodega"]);
                            int totalAsientos = Convert.ToInt32(readerAvion["Total_Asientos"]);
                            int horasDeVuelo = Convert.ToInt32(readerAvion["Horas_Vuelo"]);
                            Avion avion = new(ofreceComida, cantidadToilets, capacidadBodega, totalAsientos, matricula);
                            if (avion is not null)
                            {

                                Vuelo vuelo = new(avion,origen,partida,llegada,destino,);
                                if (vuelo is not null)
                                {
                                    if (!Administracion.CheckearSiPersonaExiste(dni))
                                    {
                                        personasObtenidas.Add(cliente);
                                    }
                                }
                            }
                        }


                    }
                }

                return personasObtenidas;

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

        }*/

    }
}
