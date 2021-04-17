
namespace Listado_Archivo_Plano
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCarga = new System.Windows.Forms.Button();
            this.buttonNombre = new System.Windows.Forms.Button();
            this.buttonPrimero = new System.Windows.Forms.Button();
            this.button1Segundo = new System.Windows.Forms.Button();
            this.buttonTercero = new System.Windows.Forms.Button();
            this.textBoxContenido = new System.Windows.Forms.TextBox();
            this.listBoxResultadoN = new System.Windows.Forms.ListBox();
            this.listBoxPrimerP = new System.Windows.Forms.ListBox();
            this.listBoxParcialS = new System.Windows.Forms.ListBox();
            this.listBoxPacialT = new System.Windows.Forms.ListBox();
            this.buttonArreglo = new System.Windows.Forms.Button();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonCarga
            // 
            this.buttonCarga.Location = new System.Drawing.Point(56, 73);
            this.buttonCarga.Name = "buttonCarga";
            this.buttonCarga.Size = new System.Drawing.Size(94, 61);
            this.buttonCarga.TabIndex = 0;
            this.buttonCarga.Text = "Cargar Archivo";
            this.buttonCarga.UseVisualStyleBackColor = true;
            this.buttonCarga.Click += new System.EventHandler(this.buttonCarga_Click);
            // 
            // buttonNombre
            // 
            this.buttonNombre.Location = new System.Drawing.Point(56, 186);
            this.buttonNombre.Name = "buttonNombre";
            this.buttonNombre.Size = new System.Drawing.Size(94, 29);
            this.buttonNombre.TabIndex = 1;
            this.buttonNombre.Text = "Nombres";
            this.buttonNombre.UseVisualStyleBackColor = true;
            this.buttonNombre.Click += new System.EventHandler(this.buttonNombre_Click);
            // 
            // buttonPrimero
            // 
            this.buttonPrimero.Location = new System.Drawing.Point(12, 332);
            this.buttonPrimero.Name = "buttonPrimero";
            this.buttonPrimero.Size = new System.Drawing.Size(75, 23);
            this.buttonPrimero.TabIndex = 13;
            // 
            // button1Segundo
            // 
            this.button1Segundo.Location = new System.Drawing.Point(12, 394);
            this.button1Segundo.Name = "button1Segundo";
            this.button1Segundo.Size = new System.Drawing.Size(75, 23);
            this.button1Segundo.TabIndex = 12;
            // 
            // buttonTercero
            // 
            this.buttonTercero.Location = new System.Drawing.Point(12, 290);
            this.buttonTercero.Name = "buttonTercero";
            this.buttonTercero.Size = new System.Drawing.Size(75, 23);
            this.buttonTercero.TabIndex = 11;
            // 
            // textBoxContenido
            // 
            this.textBoxContenido.Location = new System.Drawing.Point(189, 10);
            this.textBoxContenido.Multiline = true;
            this.textBoxContenido.Name = "textBoxContenido";
            this.textBoxContenido.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxContenido.Size = new System.Drawing.Size(349, 238);
            this.textBoxContenido.TabIndex = 5;
            // 
            // listBoxResultadoN
            // 
            this.listBoxResultadoN.FormattingEnabled = true;
            this.listBoxResultadoN.ItemHeight = 20;
            this.listBoxResultadoN.Location = new System.Drawing.Point(189, 290);
            this.listBoxResultadoN.Name = "listBoxResultadoN";
            this.listBoxResultadoN.Size = new System.Drawing.Size(349, 164);
            this.listBoxResultadoN.TabIndex = 6;
            // 
            // listBoxPrimerP
            // 
            this.listBoxPrimerP.FormattingEnabled = true;
            this.listBoxPrimerP.ItemHeight = 20;
            this.listBoxPrimerP.Location = new System.Drawing.Point(578, 14);
            this.listBoxPrimerP.Name = "listBoxPrimerP";
            this.listBoxPrimerP.Size = new System.Drawing.Size(421, 144);
            this.listBoxPrimerP.TabIndex = 7;
            // 
            // listBoxParcialS
            // 
            this.listBoxParcialS.FormattingEnabled = true;
            this.listBoxParcialS.ItemHeight = 20;
            this.listBoxParcialS.Location = new System.Drawing.Point(582, 180);
            this.listBoxParcialS.Name = "listBoxParcialS";
            this.listBoxParcialS.Size = new System.Drawing.Size(417, 124);
            this.listBoxParcialS.TabIndex = 8;
            // 
            // listBoxPacialT
            // 
            this.listBoxPacialT.FormattingEnabled = true;
            this.listBoxPacialT.ItemHeight = 20;
            this.listBoxPacialT.Location = new System.Drawing.Point(578, 332);
            this.listBoxPacialT.Name = "listBoxPacialT";
            this.listBoxPacialT.Size = new System.Drawing.Size(421, 144);
            this.listBoxPacialT.TabIndex = 9;
            // 
            // buttonArreglo
            // 
            this.buttonArreglo.Location = new System.Drawing.Point(578, 505);
            this.buttonArreglo.Name = "buttonArreglo";
            this.buttonArreglo.Size = new System.Drawing.Size(185, 35);
            this.buttonArreglo.TabIndex = 10;
            this.buttonArreglo.Text = "button1";
            this.buttonArreglo.UseVisualStyleBackColor = true;
            this.buttonArreglo.Click += new System.EventHandler(this.buttonArreglo_Click);
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.ItemHeight = 20;
            this.listBoxResultado.Location = new System.Drawing.Point(1039, 450);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(120, 84);
            this.listBoxResultado.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 698);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.buttonArreglo);
            this.Controls.Add(this.listBoxPacialT);
            this.Controls.Add(this.listBoxParcialS);
            this.Controls.Add(this.listBoxPrimerP);
            this.Controls.Add(this.listBoxResultadoN);
            this.Controls.Add(this.textBoxContenido);
            this.Controls.Add(this.buttonTercero);
            this.Controls.Add(this.button1Segundo);
            this.Controls.Add(this.buttonPrimero);
            this.Controls.Add(this.buttonNombre);
            this.Controls.Add(this.buttonCarga);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCarga;
        private System.Windows.Forms.Button buttonNombre;
        private System.Windows.Forms.Button buttonPrimero;
        private System.Windows.Forms.Button button1Segundo;
        private System.Windows.Forms.Button buttonTercero;
        private System.Windows.Forms.TextBox textBoxContenido;
        private System.Windows.Forms.ListBox listBoxResultadoN;
        private System.Windows.Forms.ListBox listBoxPrimerP;
        private System.Windows.Forms.ListBox listBoxParcialS;
        private System.Windows.Forms.ListBox listBoxPacialT;
        private System.Windows.Forms.Button buttonArreglo;
        private System.Windows.Forms.ListBox listBoxResultado;
    }
}

