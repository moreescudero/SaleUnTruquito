using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades.Modelo
{
    public static class Serializador<T>
    {
        static string ruta;

        static Serializador()
        {
            ruta = @"./Archivos-Serializador";
        }

        /// <summary>
        /// serializa un tipo de dato genértico en un archivo
        /// </summary>
        /// <param name="dato"></param>
        /// <param name="archivo"></param>
        public static void EscribirJSon(T dato, string archivo)
        {
            string completa = ruta + @"/" + archivo;

            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }
            JsonSerializerOptions opcion = new JsonSerializerOptions()
            {
                Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) },
            };
            string objetoJSon = JsonSerializer.Serialize(dato, opcion);

            File.WriteAllText(completa, objetoJSon);
        }

        /// <summary>
        /// deserealiza un archivo en un tipo de dato genérico
        /// </summary>
        /// <param name="archivo"></param>
        /// <returns></returns>
        public static T LeerJSon(string archivo)
        {
            T datos = default;

            string completo = ruta + @"/" + archivo;

            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta); // no tiene sentido que lo cree si lo tiene que leer
            }

            JsonSerializerOptions opcion = new JsonSerializerOptions()
            {
                Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) },
            };

            string archivoJSon = File.ReadAllText(completo);
            datos = JsonSerializer.Deserialize<T>(archivoJSon, opcion);

            return datos;
        }
    }
}
