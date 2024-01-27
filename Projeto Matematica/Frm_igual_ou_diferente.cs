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
    public partial class Frm_igual_ou_diferente : Form
    {
        int numero1, numero2;
        public Frm_igual_ou_diferente()
        {
            InitializeComponent();
        }

        private void Btn_antecessor_sucessor_Click(object sender, EventArgs e)
        {
            var Frm_inicio = new Frm_inicio();
            this.Hide();
            Frm_inicio.Show();  //Voltando para tela de abertura
        }

        private void Btn_limpar_igual_diferente_Click(object sender, EventArgs e)
        {
            Txt_numero1_igual_diferente.Clear();
            Txt_numero2_igual_diferente.Clear();
        }

        private void Txt_numero1_igual_diferente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Caractere invalido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 13)
            {
                if (Txt_numero1_igual_diferente.Text !="")
                {
                    numero1 = int.Parse(Txt_numero1_igual_diferente.Text);
                }
                else
                {
                    MessageBox.Show("Digite um número", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Txt_numero2_igual_diferente_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_numero2_igual_diferente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show("Caractere invalido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 13)
            {
                if (Txt_numero2_igual_diferente && Txt_numero1_igual_diferente.Text != "")
                {
                    numero2 = int.Parse(Txt_numero2_igual_diferente.Text);
                    numero1 = int.Parse(Txt_numero1_igual_diferente.Text);
                }

                else
                {
                    MessageBox.Show("Digite um número", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
