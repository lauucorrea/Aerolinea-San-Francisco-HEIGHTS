using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace Sql_Aerolinea
{
    public class Tabla_Personas
    {

        //SqlCommand sqlCommand;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        public Tabla_Personas()
        {
            sqlConnection = new SqlConnection(@"Server=.;Database=BDaerolinea;Trusted_Connection=True;");
        }

        public void SubirPersonaBD(Persona unaPersona)
        {
            try
            {

                if (!ExistePersonaBD(unaPersona))
                {
                    sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandText = $"INSERT INTO Tabla_Personas (Nombre,Apellido,Dni,Edad,Rol,Categoria,Usuario,Password) VALUES ('{unaPersona.Nombre}','{unaPersona.Apellido}',{unaPersona.Dni},{unaPersona.Edad},'{unaPersona.Rol}','{unaPersona.Categoria}','{unaPersona.Usuario}','{unaPersona.Password}')";
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

        public bool ExistePersonaBD(Persona unaPersona)
        {
            try
            {
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = $"SELECT Dni FROM Tabla_Personas WHERE dni ={unaPersona.Dni}";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;

                bool existe = false;
                if (unaPersona is not null)
                {
                    if (sqlConnection != null && sqlConnection.State != ConnectionState.Open)
                    {
                        sqlConnection.Open();
                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        while (reader.Read())
                        {
                            int dni = Convert.ToInt32(reader["Dni"]);

                            if (dni == unaPersona.Dni)
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
        public List<Persona> ObtenerPersonasBD()
        {
            try
            {
                List<Persona> personasObtenidas = new();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "SELECT * FROM Tabla_Personas";
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.Text;

                if (sqlConnection != null && sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        string nombre = reader["Nombre"].ToString();
                        string apellido = reader["Apellido"].ToString();
                        int dni = Convert.ToInt32(reader["Dni"]);
                        int edad = Convert.ToInt32(reader["Edad"]);
                        string usuario = reader["Usuario"].ToString();
                        string password = reader["Password"].ToString();

                        switch (reader["Rol"].ToString())
                        {
                            case "Cliente":
                                Cliente cliente = new(nombre, apellido, dni, edad, usuario, password);
                                if (cliente is not null)
                                {
                                    if (!Administracion.CheckearSiPersonaExiste(dni))
                                    {
                                        personasObtenidas.Add(cliente);
                                    }
                                }
                                break;
                            case "Vendedor":
                                Vendedor vendedor = new(nombre, apellido, dni, edad, usuario, password);
                                if (vendedor is not null)
                                {
                                    if (!Administracion.CheckearSiPersonaExiste(dni))
                                    {
                                        personasObtenidas.Add(vendedor);
                                    }
                                }
                                break;
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

        }
       
    }
}
