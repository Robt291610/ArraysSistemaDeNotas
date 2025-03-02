using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraysSistemaDeNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargarVector_Click(object sender, EventArgs e)
        {
            int[] notas = new int[5];

            notas[0] = 15;
            notas[1] = 13;
            notas[2] = 11;
            notas[3] = 16;
            notas[4] = 18;

            int suma = 0;
            double promedio;

            cbNotas.Items.Clear();
            for (int x = 0; x <= 4; x+=1) 
            {
             cbNotas.Items.Add(notas[x]);
             suma = suma + notas[x];
             
             
            }
            promedio = suma / 5;

            txtPromedio.Text = Convert.ToString(promedio);



        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtPromedio.Clear();
            cbNotas.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
