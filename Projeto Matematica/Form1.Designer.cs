
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
            this.SuspendLayout();
            // 
            // Rad_dobro
            // 
            this.Rad_dobro.AutoSize = true;
            this.Rad_dobro.BackColor = System.Drawing.Color.Transparent;
            this.Rad_dobro.Font = new System.Drawing.Font("Verdana", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_dobro.ForeColor = System.Drawing.Color.Black;
            this.Rad_dobro.Location = new System.Drawing.Point(27, 260);
            this.Rad_dobro.Name = "Rad_dobro";
            this.Rad_dobro.Size = new System.Drawing.Size(111, 32);
            this.Rad_dobro.TabIndex = 0;
            this.Rad_dobro.TabStop = true;
            this.Rad_dobro.Text = "Dobro";
            this.Rad_dobro.UseVisualStyleBackColor = false;
            this.Rad_dobro.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Rad_antecessor_sucessor
            // 
            this.Rad_antecessor_sucessor.AutoSize = true;
            this.Rad_antecessor_sucessor.BackColor = System.Drawing.Color.Transparent;
            this.Rad_antecessor_sucessor.Font = new System.Drawing.Font("Verdana", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_antecessor_sucessor.ForeColor = System.Drawing.Color.Black;
            this.Rad_antecessor_sucessor.Location = new System.Drawing.Point(27, 327);
            this.Rad_antecessor_sucessor.Name = "Rad_antecessor_sucessor";
            this.Rad_antecessor_sucessor.Size = new System.Drawing.Size(340, 32);
            this.Rad_antecessor_sucessor.TabIndex = 1;
            this.Rad_antecessor_sucessor.TabStop = true;
            this.Rad_antecessor_sucessor.Text = "Antecessor ou Sucessor";
            this.Rad_antecessor_sucessor.UseVisualStyleBackColor = false;
            this.Rad_antecessor_sucessor.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // Rad_par_impar
            // 
            this.Rad_par_impar.AutoSize = true;
            this.Rad_par_impar.BackColor = System.Drawing.Color.Transparent;
            this.Rad_par_impar.Font = new System.Drawing.Font("Verdana", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_par_impar.ForeColor = System.Drawing.Color.Black;
            this.Rad_par_impar.Location = new System.Drawing.Point(27, 397);
            this.Rad_par_impar.Name = "Rad_par_impar";
            this.Rad_par_impar.Size = new System.Drawing.Size(203, 32);
            this.Rad_par_impar.TabIndex = 2;
            this.Rad_par_impar.TabStop = true;
            this.Rad_par_impar.Text = "Par ou Ímpar";
            this.Rad_par_impar.UseVisualStyleBackColor = false;
            this.Rad_par_impar.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Rad_positivo_negativo_neutro
            // 
            this.Rad_positivo_negativo_neutro.AutoSize = true;
            this.Rad_positivo_negativo_neutro.BackColor = System.Drawing.Color.Transparent;
            this.Rad_positivo_negativo_neutro.Font = new System.Drawing.Font("Verdana", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_positivo_negativo_neutro.ForeColor = System.Drawing.Color.Black;
            this.Rad_positivo_negativo_neutro.Location = new System.Drawing.Point(27, 467);
            this.Rad_positivo_negativo_neutro.Name = "Rad_positivo_negativo_neutro";
            this.Rad_positivo_negativo_neutro.Size = new System.Drawing.Size(388, 32);
            this.Rad_positivo_negativo_neutro.TabIndex = 3;
            this.Rad_positivo_negativo_neutro.TabStop = true;
            this.Rad_positivo_negativo_neutro.Text = "Positivo negativo ou neutro";
            this.Rad_positivo_negativo_neutro.UseVisualStyleBackColor = false;
            this.Rad_positivo_negativo_neutro.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // Frm_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 589);
            this.Controls.Add(this.Rad_positivo_negativo_neutro);
            this.Controls.Add(this.Rad_par_impar);
            this.Controls.Add(this.Rad_antecessor_sucessor);
            this.Controls.Add(this.Rad_dobro);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Name = "Frm_inicio";
            this.Text = "Positivo Negativo ou Neutro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Rad_dobro;
        private System.Windows.Forms.RadioButton Rad_antecessor_sucessor;
        private System.Windows.Forms.RadioButton Rad_par_impar;
        private System.Windows.Forms.RadioButton Rad_positivo_negativo_neutro;
    }
}

