using System;
using System.Collections.Generic;
using System.Text;

namespace Listado_Archivo_Plano.Arreglo
{
    class ClSArreglos
    {
        private int[] ArregloTemporalCadena;
        private int[] datos;
        private int i, j, datotemporalCadena;
        private int tamanoArreglo = 0;

        public int[] Arreglo { get; }

        public int GETTamañoArreglo()
        {
            return datos.Length;

        }
        public ClSArreglos(int[] arreglo)
        {
            datos = Arreglo;
            tamanoArreglo = datos.Length; //numero de datos
        }
        public string] private ClSArreglos()
        {
            ArregloTemporalCadena = datos;

            for (i = 0; i < tamanoArreglo - 1; i++)
            {
                for (j = i + 1; j < tamanoArreglo; j++)
                {
                    if (ArregloTemporalCadena[i] < ArregloTemporalCadena[j])
                    {
                        datotemporalCadena = ArregloTemporalCadena[i];
                        ArregloTemporalCadena[i] = ArregloTemporalCadena[j];
                        ArregloTemporalCadena[j] = datotemporalCadena;

                    }
                }
            }
            return ArregloTemporalCadena;
        
        }
        public ClSArreglos(int[] arreglo)

    } 
}
