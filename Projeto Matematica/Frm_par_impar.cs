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
    public partial class Frm_par_impar : Form
    {
        int numero;
        public Frm_par_impar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_par_impar_Click(object sender, EventArgs e)
        {
            var Frm_inicio = new Frm_inicio();
            Hide();
            Frm_inicio.Show();  //Voltando para tela de abertura
        }

        private void Txt_par_impar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;

                MessageBox.Show("caractere Inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
                if (e.KeyChar ==13)
                {
                    if (Txt_par_impar.Text !="")
                    {
                        numero = int.Parse(Txt_par_impar.Text);

                        if (numero%2==0) //Condição para determinar se o resto=0 é PAR
                        {
                            MessageBox.Show("Esse Número é par.", "resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else  //Senão - O oposto do if, se o resto NÃO for 0
                        {
                            MessageBox.Show("Esse Núero é impar.","Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        Txt_par_impar.Clear();
                        Txt_par_impar.Focus();
                    }
                    else //Se o numero não for digitado
                        {
                          MessageBox.Show("Digite um numero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                          



                }
            
        }
    }
}
