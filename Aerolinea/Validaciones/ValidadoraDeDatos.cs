using System;
namespace Validaciones
{
    public static class ValidadoraDeDatos
    {
        public static bool ConvertirDatosAerolinea(string dni, string edad, out int dniConvertido, out int edadConvertida)
        {

            bool sePudoConvertirDni = int.TryParse(dni, out dniConvertido);
            bool sePudoConvertirEdad = int.TryParse(edad, out edadConvertida);

            if (sePudoConvertirDni && sePudoConvertirEdad)
            {
                return true;
            }
            throw new Exception("Los tipos de datos son incorrectos");

        }
        /// <summary>
        /// Si la palabra completa se convierte, es un numero
        /// Si la letra recorrida se convierte, es alfanumerico
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static bool ValidarString(string cadena)
        {
            int num;

            if (cadena is not null)
            {
                if (int.TryParse(cadena, out num))
                {
                    throw new Exception("Los campos no admiten numeros");
                }
                return true;
            }
            else
            {
                throw new ArgumentNullException();
            }

        }

        public static bool ValidarAlfanumerico(string cadena)
        {
            if (cadena is not null)
            {
                for (int i = 0; i < cadena.Length; i++)
                {
                    if (!char.IsLetter(cadena[i]))
                    {
                        throw new Exception("No se admiten alfanumericos");
                    }
                }
            }
            throw new NullReferenceException();
        }

        public static bool VerificarDni(int dni)
        {
            if (dni > 29999999 && dni < 59999999)
            {
                return true;
            }
            else
            {
                throw new Exception("La edad no es considerada correcta segun su DNI");
            }
        }
    }
}
