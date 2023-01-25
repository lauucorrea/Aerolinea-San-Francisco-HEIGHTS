using Entidades;
using System.Text.Json;
using System.Xml.Serialization;
namespace Serializacion
{
    public class Clase_serializadora
    {
        string rutaBase = String.Empty;
        string rutaArchivo = String.Empty;
        public Clase_serializadora()
        {
            rutaBase = "C:/Users/Lauta/source/repos/Aerolinea/Serializacion/";

        }
        public string RutaPersonas
        {
            get { return Path.Combine(rutaBase, "ArchivosXml/Personas.json"); }
        }
        public void GuardarPersonasJSON()
        {
            try
            {
                JsonSerializerOptions opciones = new();
                opciones.WriteIndented = true;
                rutaArchivo = Path.Combine(rutaBase, "ArchivosJson/Personas.json");
                string jsonString = JsonSerializer.Serialize(Registro.Personas, opciones);

                File.WriteAllText(rutaArchivo, jsonString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void GuardarPersonasXML()
        {
            try
            {
                rutaArchivo = Path.Combine(rutaBase, "ArchivosXml/Personas.xml");
                StreamWriter sw = new StreamWriter(rutaArchivo);

                using (sw)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Persona>));
                    serializer.Serialize(sw, Registro.Personas);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void GuardarVuelosXML()
        {
            try
            {
                rutaArchivo = Path.Combine(rutaBase, "ArchivosXml/Vuelos.xml");
                StreamWriter sw = new StreamWriter(rutaArchivo);

                using (sw)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Vuelo>));
                    serializer.Serialize(sw, Registro.Vuelos);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void GuardarPasajesXML()
        {
            try
            {
                rutaArchivo = Path.Combine(rutaBase, "ArchivosXml/Pasajes.xml");
                StreamWriter sw = new StreamWriter(rutaArchivo);

                using (sw)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Pasaje>));
                    serializer.Serialize(sw, Registro.Pasajes);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void LevantarPersonasXML()
        {
            try
            {
                rutaArchivo = Path.Combine(rutaBase, "ArchivosXml/Personas.xml");
                StreamReader sr = new StreamReader(rutaArchivo);

                XmlSerializer serializer = new XmlSerializer(typeof(List<Persona>));

                using (sr)
                {
                    Registro.Personas = serializer.Deserialize(sr) as List<Persona>;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void LevantarVuelosXML()
        {
            try
            {
                rutaArchivo = Path.Combine(rutaBase, "ArchivosXml/Vuelos.xml");
                StreamReader sr = new StreamReader(rutaArchivo);

                XmlSerializer serializer = new XmlSerializer(typeof(List<Vuelo>));

                using (sr)
                {
                    Registro.Vuelos = serializer.Deserialize(sr) as List<Vuelo>;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void LevantarPasajesXML()
        {
            try
            {
                rutaArchivo = Path.Combine(rutaBase, "ArchivosXml/Pasajes.xml");
                StreamReader sr = new StreamReader(rutaArchivo);

                XmlSerializer serializer = new XmlSerializer(typeof(List<Pasaje>));

                using (sr)
                {
                    Registro.Pasajes = serializer.Deserialize(sr) as List<Pasaje>;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        /* public void LevantarPersonasJSON()
         {
             rutaArchivo = Path.Combine(rutaBase, "ArchivosJson/Personas.json");
             string jsonString = File.ReadAllText(rutaArchivo);

             Persona? ListaPersonas = new();
             Persona persona = JsonSerializer.Deserialize<Persona>(jsonString);

             if (ListaPersonas is not null)
             {
                 foreach (Persona persona in ListaPersonas)
                 {
                     if (persona.GetType() == typeof(Cliente))
                     {
                         Registro.Personas.Add((Cliente)persona);
                     }
                     else if (persona.GetType() == typeof(Vendedor))
                     {
                         Registro.Personas.Add((Vendedor)persona);

                     }

                 }
             }
             else
             {
                 throw new Exception("No se pudo desearlizar la lista de personas");
             }
         }*/

    }
}
