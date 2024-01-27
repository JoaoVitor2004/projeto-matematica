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
    public partial class Frm_dobro : Form
    {
        double numero;
        public Frm_dobro()
        {
            InitializeComponent();
        }

        private void Btn_par_impar_Click(object sender, EventArgs e)
        {
            var Frm_inicio = new Frm_inicio();
            this.Hide();
            Frm_inicio.Show();  //Voltando para tela de abertura
        }

        private void Txt_dobro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == ',')) //Usando condição if para permitir digitação de números
            {
                e.Handled = true;   //Confirmando se foi número

                MessageBox.Show("Caractere inválido!" , "Aviso" , MessageBoxButtons.OK,MessageBoxIcon.Error);  //Mensagem de erro 
            }
            if (e.KeyChar == 13)
            {
                if (Txt_dobro.Text != "")
                {
                    numero = double.Parse(Txt_dobro.Text);

                    numero = numero * 2;

                    MessageBox.Show("O dobro Desse Número é! " + numero, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Txt_dobro.Clear();
                    Txt_dobro.Focus();
                }
                else
                {
                    MessageBox.Show("digite um numero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
            }
                
        }

        private void Txt_dobro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
