using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Matematica
{
    public partial class Frm_inicio : Form
    {
        public Frm_inicio()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Rad_dobro_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            var Frm_dobro = new Frm_dobro();
            this.Hide();
            Frm_dobro.Show();
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            var Frm_antecessor_sucessor = new Frm_antecessor_sucessor();
            this.Hide();
            Frm_antecessor_sucessor.Show();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            var Frm_par_impar = new Frm_par_impar();
            this.Hide();
            Frm_par_impar.Show();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            var Frm_positivo_negativo_neutro = new Frm_positivo_negativo_neutro();
            this.Hide();
            Frm_positivo_negativo_neutro.Show();
        }
    }
}
