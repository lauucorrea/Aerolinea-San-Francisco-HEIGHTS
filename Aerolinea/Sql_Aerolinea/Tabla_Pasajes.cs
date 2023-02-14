using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace Sql_Aerolinea
{
    public class Tabla_Pasajes
    {

        //SqlCommand sqlCommand;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        public Tabla_Pasajes()
        {
            sqlConnection = new SqlConnection(@"Server=.;Database=BDaerolinea;Trusted_Connection=True;");
        }

        public void SubirPasajeBD(Pasaje unPasaje)
        {
            try
            {

                if (!ExistePasajeBD(unPasaje))
                {
                    sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandText = $"INSERT INTO Tabla_Pasajes (Nombre_Pasajero,Dni_Pasajero,Destino,Valor_Pasaje,Categoria_Pasaje,Alcance_Pasaje,Matricula_Avion,Alcance_Pasaje,Matricula_Avion,Trae_Bolso,Cantidad_Valijas) VALUES ('{unPasaje.NombrePasajero}','{unPasaje.DniPasajero}',{unPasaje.Destino},{unPasaje.ValorPasaje},'{unPasaje.EsPremium}','{unPasaje.EsInternacional}','{unPasaje.MatriculaAvion}','{unPasaje.TraeBolso}','{unPasaje.CantidadValijas}')";
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

        public bool ExistePasajeBD(Pasaje unPasaje)
        {
            try
            {
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = $"SELECT Dni FROM Tabla_Pasajes WHERE Dni_Pasajero ={unPasaje.DniPasajero} AND Matricula_Avion = {unPasaje.MatriculaAvion}";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;

                bool existe = false;
                if (unPasaje is not null)
                {
                    if (sqlConnection != null && sqlConnection.State != ConnectionState.Open)
                    {
                        sqlConnection.Open();
                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        while (reader.Read())
                        {
                            int dni = Convert.ToInt32(reader["Dni_Pasajero"]);
                            string matricula = reader["Matricula_Avion"].ToString();
                            if (dni == unPasaje.DniPasajero && matricula == unPasaje.MatriculaAvion)
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
        public List<Pasaje> ObtenerPasajesBD()
        {
            try
            {
                List<Pasaje> pasajesObtenidos = new();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "SELECT * FROM Tabla_Pasajes";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;

                if (sqlConnection != null && sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        string nombre = reader["Nombre_Pasajero"].ToString();
                        int dni = Convert.ToInt32(reader["Dni_Pasajero"]);
                        Destinos edad = (Destinos)reader["Destino"];
                        float valorPasaje = float.Parse(reader["Valor_Pasaje"].ToString());
                        bool esPremium = (bool)reader["EsPremium"];
                        bool esInternacional = (bool)reader["EsInternacional"];
                        string matricula = reader["Matricula_Avion"].ToString();
                        bool traeBolso = (bool)reader["Trae_Bolso"];
                        int cantidadValijas = Convert.ToInt32(reader["Cantidad_Valijas"]);
                        int idVuelo = Convert.ToInt32(reader["IdVuelo"]);
                        Pasaje pasaje = new(nombre, dni, edad, valorPasaje, esPremium, esInternacional, matricula, traeBolso, cantidadValijas, idVuelo);
                        if(pasaje is not null)
                        {
                            pasajesObtenidos.Add(pasaje);
                        }
                    }
                }

                return pasajesObtenidos;

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
