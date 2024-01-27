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
            var Frm_dobro = new Frm_dobro();   //Instanciando um novo objeto para abrir o formulario dobro
            Hide();    //Ocultar a tela de abertura
            Frm_dobro.Show();   //Abrindo a tela do dobro
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            var Frm_antecessor_sucessor = new Frm_antecessor_sucessor(); ////Instanciando um novo objeto para abrir o formulario antecessor ou sucessor
            Hide(); //Ocultar a tela de abertura
            Frm_antecessor_sucessor.Show(); //Abrindo a tela do antecessor ou sucessor
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            var Frm_par_impar = new Frm_par_impar(); //Instanciando um novo objeto para abrir o formulario par ou imoar
            this.Hide(); //Ocultar a tela de abertura
            Frm_par_impar.Show(); //Abrindo a tela do par ou impar
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            var Frm_positivo_negativo_neutro = new Frm_positivo_negativo_neutro();  //Instanciando um novo objeto para abrir o formulario positivo negativo ou neutro
            this.Hide();  //Ocultar a tela de abertura
            Frm_positivo_negativo_neutro.Show();  //Abrindo a tela do dobro
        }

        private void Frm_inicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do aplicativo", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Application.Exit();  //aplication.exit(); Encerra o aplicativo
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            var Frm_igual_ou_diferente = new Frm_igual_ou_diferente();
            this.Hide();
            Frm_igual_ou_diferente.Show();
        }

        private void radioButton2_CheckedChanged_2(object sender, EventArgs e)
        {
            var Frm_operacoes_aritmeticas = new Frm_operacoes_aritmeticas();
            this.Hide();
            Frm_operacoes_aritmeticas.Show();
            
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            var Frm_maior_ou_menor = new frm_maior_ou_menor();
            this.Hide();
            Frm_maior_ou_menor.Show();
        }
    }
}
