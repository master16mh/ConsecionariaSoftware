using ConsecionariaSoftware.BA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ConsecionariaSoftware.FE
{
    public partial class Form1 : Form
    {
        private Vehículos Vehículos = new Vehículos();
        public Form1()
        {
            InitializeComponent();
            dataGridAutos.DataSource = Vehículos.Tabla;
            dataGridCamionetas.DataSource = Vehículos.TablaCamion;
        }


        private void botonAgregar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString().Equals("Auto"))
            {
                Vehículos.ultimoid++;
                Auto aAuto = new Auto(Vehículos.ultimoid,
                                          textBoxMarca.Text,
                                          textBoxModelo.Text,
                                          textBoxTraccion.Text,
                                          textBoxCilindrada.Text,
                                          textBoxCondicion.Text,
                                          textBoxVersion.Text,
                                          textBoxPrecio.Text);

                this.Vehículos.Insert(aAuto);
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Camioneta"))
            {
                Vehículos.ultimoidcamion++;
                Camioneta cCamioneta = new Camioneta(Vehículos.ultimoidcamion,
                                                         textBoxMarca.Text,
                                                         textBoxModelo.Text,
                                                         textBoxTraccion.Text,
                                                         textBoxCilindrada.Text,
                                                         textBoxCondicion.Text,
                                                         textBoxVersion.Text,
                                                         textBoxPrecio.Text);
                this.Vehículos.Insert(cCamioneta);
            }
        }
 
        private void botonEliminarAutos_Click(object sender, EventArgs e)
        {
            Vehículos.Delete(Convert.ToInt32(dataGridAutos.CurrentRow.Cells[0].Value));

        }

        private void botonEliminarCamioneta_Click(object sender, EventArgs e)
        {
            Vehículos.Deletecamion(Convert.ToInt32(dataGridCamionetas.CurrentRow.Cells[0].Value));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridAutos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

    }   
}
