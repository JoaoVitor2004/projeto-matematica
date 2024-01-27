
namespace Projeto_Matematica
{
    partial class Frm_inicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_inicio));
            this.Rad_dobro = new System.Windows.Forms.RadioButton();
            this.Rad_antecessor_sucessor = new System.Windows.Forms.RadioButton();
            this.Rad_par_impar = new System.Windows.Forms.RadioButton();
            this.Rad_positivo_negativo_neutro = new System.Windows.Forms.RadioButton();
            this.Btn_sair = new System.Windows.Forms.Button();
            this.Rad_igual_ou_diferente = new System.Windows.Forms.RadioButton();
            this.Rad_operacoes_aritmeticas = new System.Windows.Forms.RadioButton();
            this.Rad_maior_ou_menor = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Rad_dobro
            // 
            this.Rad_dobro.AutoSize = true;
            this.Rad_dobro.BackColor = System.Drawing.Color.Transparent;
            this.Rad_dobro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rad_dobro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Rad_dobro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Rad_dobro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Rad_dobro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rad_dobro.Font = new System.Drawing.Font("Verdana", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_dobro.ForeColor = System.Drawing.Color.White;
            this.Rad_dobro.Location = new System.Drawing.Point(97, 169);
            this.Rad_dobro.Margin = new System.Windows.Forms.Padding(2);
            this.Rad_dobro.Name = "Rad_dobro";
            this.Rad_dobro.Size = new System.Drawing.Size(88, 26);
            this.Rad_dobro.TabIndex = 0;
            this.Rad_dobro.Text = "Dobro";
            this.Rad_dobro.UseVisualStyleBackColor = false;
            this.Rad_dobro.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Rad_antecessor_sucessor
            // 
            this.Rad_antecessor_sucessor.AutoSize = true;
            this.Rad_antecessor_sucessor.BackColor = System.Drawing.Color.Transparent;
            this.Rad_antecessor_sucessor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rad_antecessor_sucessor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Rad_antecessor_sucessor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Rad_antecessor_sucessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rad_antecessor_sucessor.Font = new System.Drawing.Font("Verdana", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_antecessor_sucessor.ForeColor = System.Drawing.Color.White;
            this.Rad_antecessor_sucessor.Location = new System.Drawing.Point(22, 212);
            this.Rad_antecessor_sucessor.Margin = new System.Windows.Forms.Padding(2);
            this.Rad_antecessor_sucessor.Name = "Rad_antecessor_sucessor";
            this.Rad_antecessor_sucessor.Size = new System.Drawing.Size(269, 26);
            this.Rad_antecessor_sucessor.TabIndex = 1;
            this.Rad_antecessor_sucessor.Text = "Antecessor ou Sucessor";
            this.Rad_antecessor_sucessor.UseVisualStyleBackColor = false;
            this.Rad_antecessor_sucessor.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // Rad_par_impar
            // 
            this.Rad_par_impar.AutoSize = true;
            this.Rad_par_impar.BackColor = System.Drawing.Color.Transparent;
            this.Rad_par_impar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rad_par_impar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Rad_par_impar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Rad_par_impar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rad_par_impar.Font = new System.Drawing.Font("Verdana", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_par_impar.ForeColor = System.Drawing.Color.White;
            this.Rad_par_impar.Location = new System.Drawing.Point(68, 262);
            this.Rad_par_impar.Margin = new System.Windows.Forms.Padding(2);
            this.Rad_par_impar.Name = "Rad_par_impar";
            this.Rad_par_impar.Size = new System.Drawing.Size(161, 26);
            this.Rad_par_impar.TabIndex = 2;
            this.Rad_par_impar.Text = "Par ou Ímpar";
            this.Rad_par_impar.UseVisualStyleBackColor = false;
            this.Rad_par_impar.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Rad_positivo_negativo_neutro
            // 
            this.Rad_positivo_negativo_neutro.AutoSize = true;
            this.Rad_positivo_negativo_neutro.BackColor = System.Drawing.Color.Transparent;
            this.Rad_positivo_negativo_neutro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rad_positivo_negativo_neutro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Rad_positivo_negativo_neutro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Rad_positivo_negativo_neutro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rad_positivo_negativo_neutro.Font = new System.Drawing.Font("Verdana", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_positivo_negativo_neutro.ForeColor = System.Drawing.Color.White;
            this.Rad_positivo_negativo_neutro.Location = new System.Drawing.Point(22, 312);
            this.Rad_positivo_negativo_neutro.Margin = new System.Windows.Forms.Padding(2);
            this.Rad_positivo_negativo_neutro.Name = "Rad_positivo_negativo_neutro";
            this.Rad_positivo_negativo_neutro.Size = new System.Drawing.Size(305, 26);
            this.Rad_positivo_negativo_neutro.TabIndex = 3;
            this.Rad_positivo_negativo_neutro.Text = "Positivo negativo ou neutro";
            this.Rad_positivo_negativo_neutro.UseVisualStyleBackColor = false;
            this.Rad_positivo_negativo_neutro.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // Btn_sair
            // 
            this.Btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_sair.FlatAppearance.BorderSize = 2;
            this.Btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_sair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_sair.Location = new System.Drawing.Point(778, 1);
            this.Btn_sair.Name = "Btn_sair";
            this.Btn_sair.Size = new System.Drawing.Size(61, 31);
            this.Btn_sair.TabIndex = 4;
            this.Btn_sair.Text = "X";
            this.Btn_sair.UseVisualStyleBackColor = false;
            this.Btn_sair.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rad_igual_ou_diferente
            // 
            this.Rad_igual_ou_diferente.AutoSize = true;
            this.Rad_igual_ou_diferente.BackColor = System.Drawing.Color.Transparent;
            this.Rad_igual_ou_diferente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rad_igual_ou_diferente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Rad_igual_ou_diferente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Rad_igual_ou_diferente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rad_igual_ou_diferente.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_igual_ou_diferente.ForeColor = System.Drawing.Color.White;
            this.Rad_igual_ou_diferente.Location = new System.Drawing.Point(33, 384);
            this.Rad_igual_ou_diferente.Name = "Rad_igual_ou_diferente";
            this.Rad_igual_ou_diferente.Size = new System.Drawing.Size(152, 20);
            this.Rad_igual_ou_diferente.TabIndex = 5;
            this.Rad_igual_ou_diferente.TabStop = true;
            this.Rad_igual_ou_diferente.Text = "igual ou diferente";
            this.Rad_igual_ou_diferente.UseVisualStyleBackColor = false;
            this.Rad_igual_ou_diferente.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // Rad_operacoes_aritmeticas
            // 
            this.Rad_operacoes_aritmeticas.AutoSize = true;
            this.Rad_operacoes_aritmeticas.BackColor = System.Drawing.Color.Transparent;
            this.Rad_operacoes_aritmeticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rad_operacoes_aritmeticas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Rad_operacoes_aritmeticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Rad_operacoes_aritmeticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rad_operacoes_aritmeticas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_operacoes_aritmeticas.ForeColor = System.Drawing.Color.White;
            this.Rad_operacoes_aritmeticas.Location = new System.Drawing.Point(28, 436);
            this.Rad_operacoes_aritmeticas.Name = "Rad_operacoes_aritmeticas";
            this.Rad_operacoes_aritmeticas.Size = new System.Drawing.Size(191, 20);
            this.Rad_operacoes_aritmeticas.TabIndex = 6;
            this.Rad_operacoes_aritmeticas.TabStop = true;
            this.Rad_operacoes_aritmeticas.Text = "Operações Aritmeticas";
            this.Rad_operacoes_aritmeticas.UseVisualStyleBackColor = false;
            this.Rad_operacoes_aritmeticas.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_2);
            // 
            // Rad_maior_ou_menor
            // 
            this.Rad_maior_ou_menor.AutoSize = true;
            this.Rad_maior_ou_menor.BackColor = System.Drawing.Color.Transparent;
            this.Rad_maior_ou_menor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rad_maior_ou_menor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Rad_maior_ou_menor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Rad_maior_ou_menor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rad_maior_ou_menor.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_maior_ou_menor.ForeColor = System.Drawing.Color.White;
            this.Rad_maior_ou_menor.Location = new System.Drawing.Point(33, 410);
            this.Rad_maior_ou_menor.Name = "Rad_maior_ou_menor";
            this.Rad_maior_ou_menor.Size = new System.Drawing.Size(136, 20);
            this.Rad_maior_ou_menor.TabIndex = 7;
            this.Rad_maior_ou_menor.TabStop = true;
            this.Rad_maior_ou_menor.Text = "Maior ou Menor";
            this.Rad_maior_ou_menor.UseVisualStyleBackColor = false;
            this.Rad_maior_ou_menor.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged_1);
            // 
            // Frm_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(842, 484);
            this.Controls.Add(this.Rad_maior_ou_menor);
            this.Controls.Add(this.Rad_operacoes_aritmeticas);
            this.Controls.Add(this.Rad_igual_ou_diferente);
            this.Controls.Add(this.Btn_sair);
            this.Controls.Add(this.Rad_positivo_negativo_neutro);
            this.Controls.Add(this.Rad_par_impar);
            this.Controls.Add(this.Rad_antecessor_sucessor);
            this.Controls.Add(this.Rad_dobro);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Rad_dobro;
        private System.Windows.Forms.RadioButton Rad_antecessor_sucessor;
        private System.Windows.Forms.RadioButton Rad_par_impar;
        private System.Windows.Forms.RadioButton Rad_positivo_negativo_neutro;
        private System.Windows.Forms.Button Btn_sair;
        private System.Windows.Forms.RadioButton Rad_igual_ou_diferente;
        private System.Windows.Forms.RadioButton Rad_operacoes_aritmeticas;
        private System.Windows.Forms.RadioButton Rad_maior_ou_menor;
    }
}

