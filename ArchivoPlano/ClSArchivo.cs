using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace Listado_Archivo_Plano.ArchivoPlano
{
    class ClSArchivo
    {
        public string [] LeerArchivo(string archivo)
        {
            string[] lineas = File.ReadAllLines(archivo);
            return lineas;
        }
        public string LeerTodoArchivo(string archivo)
        {
            string ContenidoArchivo;
            using (StreamReader reader = new StreamReader(archivo))
            {
                ContenidoArchivo = reader.ReadToEnd();
            }
            return ContenidoArchivo;

        }
    }
}
