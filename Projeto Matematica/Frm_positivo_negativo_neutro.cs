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
    public partial class Frm_positivo_negativo_neutro : Form
    {
        int numero;
        public Frm_positivo_negativo_neutro()
        {
            InitializeComponent();
        }

        private void Btn_par_impar_Click(object sender, EventArgs e)
        {
            var Frm_inicio = new Frm_inicio();
            this.Hide();
            Frm_inicio.Show();  //Voltando para tela de abertura
        }

        private void Txt_positivo_negativo_neutro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar=='-'))
            {
                e.Handled = true;

                MessageBox.Show("Caractere invalido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (e.KeyChar==13)
            {
                if (Txt_positivo_negativo_neutro.Text !="") //se ela digitar um numero
                {
                    numero = int.Parse(Txt_positivo_negativo_neutro.Text);

                    if (numero==0) //Condição se o número é neutro
                    {
                        MessageBox.Show("Esse número é neutro", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (numero>0) //Condição para verificar se um número é positiovo
                    {
                        MessageBox.Show("O numero digitado é positivo", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else //Condição para verificar se o numero é negativo
                    {
                        MessageBox.Show("O número digitado é negativo", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Txt_positivo_negativo_neutro.Clear();
                    Txt_positivo_negativo_neutro.Focus();
                }
                else //Se o numero não for digitado
                {
                    MessageBox.Show("Digite um número", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
