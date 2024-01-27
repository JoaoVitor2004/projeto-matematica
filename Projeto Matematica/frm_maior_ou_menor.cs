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
    public partial class frm_maior_ou_menor : Form
    {
        public frm_maior_ou_menor()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            var Frm_inicio = new Frm_inicio();
            this.Hide();
            Frm_inicio.Show();  //Voltando para tela de abertura
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Txt_numero1_maior_menor.Clear();
            Txt_numero1_maior_menor.Clear();
        }

        private void Txt_numero1_maior_menor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
