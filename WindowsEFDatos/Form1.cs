using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFDatos.Dac;
using WindowsEFDatos.Data;
using WindowsEFDatos.Models;

namespace WindowsEFDatos
{
    public partial class Form1 : Form
    {

        private void GridRefresh()
        {

            dataGridView1.DataSource = AbmAvion.Listar();

        }

        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            GridRefresh();

        }

        private void btnAgregarAvion_Click(object sender, EventArgs e)
        {
            LineaAerea lineaAerea = new LineaAerea() { FechaInicioActividades = new DateTime(1999, 10, 10), Nombre = "Aerolineas Argentinas" };

            AbmLineaAerea.Insertar(lineaAerea);

            Avion Avion = new Avion() { Capacidad = Convert.ToDouble( textBoxCapacidad.Text ), Denominacion = textBoxDenominacion.Text, LineaAerea_Id = lineaAerea.IdLinea };

            MessageBox.Show(AbmAvion.Insertar(Avion) > 0 ? "Avión insertado correctamente" : "Ocurrio un error");

            GridRefresh();

        }
    }
}
