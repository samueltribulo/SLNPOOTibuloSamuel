using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibTransportes;

namespace PresentacionVehiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearCamion_Click(object sender, EventArgs e)
        {

            Remolque remolque = new Remolque();

            Camion camion = new Camion("Volkswagen", remolque, "Meteor", "13 litros", 27500);

            MessageBox.Show(camion.MostrarProps());


        }
    }
}
