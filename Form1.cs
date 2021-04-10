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
        public Form1()
        {
            InitializeComponent();
        }
        public string[] ArregloNotas { get; private set; }
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

        private void buttonNombre_Click(object sender, EventArgs e)
        {
            foreach(string linea in ArregloNotas)
            {
                string[] datos = linea.Split(';');
                int v = listBoxResultadoN.Items.Add(datos[1]);
            }
        }

        private void buttonPrimero_Click(object sender, EventArgs e)
        {
            foreach (string linea in ArregloNotas)
            {
                string[] datos = linea.Split(';');
                int v = listBoxPrimerP.Items.Add(datos[2]);
            }
        }

        private void button1Segundo_Click(object sender, EventArgs e)
        {
            foreach (string linea in ArregloNotas)
            {
                string[] datos = linea.Split(';');
                int v = listBoxParcialS.Items.Add(datos[3]);
            }
        }

        private void buttonTercero_Click(object sender, EventArgs e)
        {
            foreach (string linea in ArregloNotas)
            {
                string[] datos = linea.Split(';');
                int v = listBoxPacialT.Items.Add(datos[4]);
            }
        }
    }
    
}
