using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MensajeEspecial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lo unico imposible es aquello que no intentas... para todo el equipo de CAHSA"
                            + Environment.NewLine + "Equipo IT CAHSA"
                            + Environment.NewLine + "Alejandrina Contreras Zavala"
                            + Environment.NewLine + Environment.NewLine + "Pdt. Vamos a comer hoy");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos al curso de GitHub con VS2019. Impartido por Ing. Alejandrina Contreras");
        }
    }
}