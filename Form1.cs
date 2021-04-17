using Listado_Archivo_Plano.ArchivoPlano;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listado_Archivo_Plano
{
    public partial class Form1 : Form
    {
        private string[] ArregloNotas;
        public int contador;
        private bool contado;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonArreglo_Click(object sender, EventArgs e)
        {
            int[] arreglo = new int[5];
            arreglo[0] = 10;
            arreglo[1] = 8;
            arreglo[2] = 16;
            arreglo[3] = 36;
            arreglo[4] = 1;

            string[] nombre = new string[5];
            nombre[3] = "60; DARWIN ADOLFO SOTO PALMA; 9; 18; 34";
            nombre[4] = "56;BRAYAM RAMÖREZ ARANA;3;15;16";
            nombre[1] = "1;SEYDI YARIZA ALVARADO CORDERO;10;12;13";
            nombre[2] = "2;FRANCISCO ALEJANDRO BAILàN LMUS;8;2;15";
            nombre[0] = "3;GUADALUPE DIANA RUBÖ BARAHONA CASIA;5;6;40";
            string todo = "60; DARWIN ADOLFO SOTO PALMA; 9; 18; 34;56;BRAYAM RAMÖREZ ARANA;3;15;16;1;SEYDI YARIZA ALVARADO CORDERO;10;12;13;2;FRANCISCO ALEJANDRO BAILàN LMUS;8;2;15;3;GUADALUPE DIANA RUBÖ BARAHONA CASIA;5;6;40";

            ClsArreglos ObjArreglo = new ClsArreglos(arreglo);
            int[] resultado = ObjArreglo.MetodoBurbuja();

            for (int indice = 0; indice < resultado.Length; indice++)
            {
                //listBoxResultado.Items.Add(arreglo[indice]);
                //listBoxResultado.Items.Add($"valor = {resultado[indice]} Po={indice}");
                listBoxResultado.Items.Add($"{resultado[indice]}");
            }
        }
            public string[] ArregloNota { get; private set; }
        public object ListBoxResultadoN { get; private set; }

        private void buttonCarga_Click(object sender, EventArgs e)
        {
            ClSArchivo ar = new ClSArchivo();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecciona tu Archivo Plano";
            ofd.InitialDirectory = @"C: \Users\Darwin Soto\3D Objects\archivoPlano.csv";
            ofd.Filter = "Archivo Plano (*.csv)|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                string resultado = ar.LeerTodoArchivo(archivo);

                ArregloNotas = ar.LeerArchivo(archivo);

                textBoxContenido.Text = resultado;
            }
        }

        public int promedios(string[,] matriz, int columna)
        {
            int acumulador = 0;
            int promedios;
            int totalfilas = matriz.GetLength(0);
            int totalcolumnas = matriz.GetLength(1);

            for (int fila = 1; fila < matriz.GetLength(0); fila++)
            {
                acumulador = acumulador + Convert.ToInt32(matriz[fila, columna]);
            }
            promedios = acumulador / (matriz.GetLength(0) - 1);
            return promedios;
        }

        private void buttonNombre_Click(object sender, EventArgs e)
        {
            int contador = 0;

            //string datosAlumnos = "3;GUADALUPE DIANA RUBÖ BARAHONA CASIA;5;6;40";
            //string[] datos = datosAlumnos.Split(";");
            //datos[0] = "1";
            //datos[1] = "SEYDI YARIZA ALVARADO CORDERO";
            //datos[2] = "10";
            //datos[3] = "12";
            //datos[4] = "13";
            //int aacumulador = contador + Convert.ToInt32(datos[4]);
            int promedio, acumulador;
            acumulador = 0;

            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 5];

            int[] ordenparcial = new int[ArregloNotas.Length - 1];

            foreach (string linea in ArregloNotas)

            {
                string[] datos = linea.Split(';');
                if (contador = 0)
                {
                    listBoxResultadoN.Items.Add(datos[1]);
                    acumulador = acumulador + Convert.ToInt32(datos[3]);
                    ordenparcial[contador-1] = Convert.ToInt32(datos[3]);
                }
                ArregloDosDimensiones[contador, 0] = datos[0];
                ArregloDosDimensiones[contador, 1] = datos[1];
                ArregloDosDimensiones[contador, 2] = datos[2];
                ArregloDosDimensiones[contador, 3] = datos[3];
                ArregloDosDimensiones[contador, 4] = datos[4];
                contador++;
            }

            ClsArreglos fncArreglos = new ClsArreglos(ordenparcial);
            ordenparcial = fncArreglos.MetodoBurbuja();

            int min = ordenparcial[0];
            int max = ordenparcial[ordenparcial.Length-1;

            promedio = acumulador / contador - 1;
            MessageBox.Show($"Promedio es {promedio}\nmin={min}\nmax={max}");
        }
    }
}
