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
    public partial class Frm_antecessor_sucessor : Form
    {
        double numero, antecessor, sucessor; //Declarando variáveis de cassa decimais que armazena o numero digitado e as demais para os cálculos

        public Frm_antecessor_sucessor()
        {
            InitializeComponent();
        }

        private void Btn_par_impar_Click(object sender, EventArgs e)
        {
            var Frm_inicio = new Frm_inicio();
            Hide();
            Frm_inicio.Show();  //Voltando para tela de abertura
        }

        private void Frm_antecessor_sucessor_Load(object sender, EventArgs e)
        {

        }

        private void Txt_antecessor_sucessor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber (e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar==','))
            {
                e.Handled = true; //Verifiacando se foi o número

                MessageBox.Show("Caractere Inválido!!!","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(e.KeyChar==13)
            {
                if (Txt_antecessor_sucessor.Text !="")
                {
                    numero = double.Parse(Txt_antecessor_sucessor.Text);

                    antecessor = numero - 1;

                    sucessor = numero + 1; //Calculo do Sucessor

                    Lbl_antecessor.Text = antecessor.ToString();  //Recebendo o valor convertido para string

                    Lbl_sucessor.Text = sucessor.ToString();  //Recebendo o valor convertido para string
                }
            }
        }

        private void Txt_antecessor_sucessor_TextChanged(object sender, EventArgs e)
        {
            if (Txt_antecessor_sucessor.Text == "")
            {
                Lbl_antecessor.Text = "?"; //Voltando para o estado inicial
                Lbl_sucessor.Text = "?"; //Voltando para o estado inicial
            }
        }
    }
}
