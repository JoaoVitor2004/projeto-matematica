
namespace Projeto_Matematica
{
    partial class Frm_positivo_negativo_neutro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_positivo_negativo_neutro));
            this.Lbl_positivo_negativo_neutro = new System.Windows.Forms.Label();
            this.Txt_positivo_negativo_neutro = new System.Windows.Forms.TextBox();
            this.Btn_positivo_negativo_neutro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_positivo_negativo_neutro
            // 
            this.Lbl_positivo_negativo_neutro.AutoSize = true;
            this.Lbl_positivo_negativo_neutro.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_positivo_negativo_neutro.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_positivo_negativo_neutro.ForeColor = System.Drawing.Color.White;
            this.Lbl_positivo_negativo_neutro.Location = new System.Drawing.Point(130, 249);
            this.Lbl_positivo_negativo_neutro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_positivo_negativo_neutro.Name = "Lbl_positivo_negativo_neutro";
            this.Lbl_positivo_negativo_neutro.Size = new System.Drawing.Size(282, 32);
            this.Lbl_positivo_negativo_neutro.TabIndex = 4;
            this.Lbl_positivo_negativo_neutro.Text = "Digiite o Número:";
            // 
            // Txt_positivo_negativo_neutro
            // 
            this.Txt_positivo_negativo_neutro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Txt_positivo_negativo_neutro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_positivo_negativo_neutro.ForeColor = System.Drawing.Color.White;
            this.Txt_positivo_negativo_neutro.Location = new System.Drawing.Point(211, 309);
            this.Txt_positivo_negativo_neutro.Name = "Txt_positivo_negativo_neutro";
            this.Txt_positivo_negativo_neutro.Size = new System.Drawing.Size(100, 29);
            this.Txt_positivo_negativo_neutro.TabIndex = 5;
            this.Txt_positivo_negativo_neutro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_positivo_negativo_neutro_KeyPress);
            // 
            // Btn_positivo_negativo_neutro
            // 
            this.Btn_positivo_negativo_neutro.BackColor = System.Drawing.Color.Transparent;
            this.Btn_positivo_negativo_neutro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_positivo_negativo_neutro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Btn_positivo_negativo_neutro.FlatAppearance.BorderSize = 2;
            this.Btn_positivo_negativo_neutro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Btn_positivo_negativo_neutro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Btn_positivo_negativo_neutro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_positivo_negativo_neutro.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_positivo_negativo_neutro.ForeColor = System.Drawing.Color.White;
            this.Btn_positivo_negativo_neutro.Location = new System.Drawing.Point(731, 27);
            this.Btn_positivo_negativo_neutro.Name = "Btn_positivo_negativo_neutro";
            this.Btn_positivo_negativo_neutro.Size = new System.Drawing.Size(103, 44);
            this.Btn_positivo_negativo_neutro.TabIndex = 6;
            this.Btn_positivo_negativo_neutro.Text = "Voltar";
            this.Btn_positivo_negativo_neutro.UseVisualStyleBackColor = false;
            this.Btn_positivo_negativo_neutro.Click += new System.EventHandler(this.Btn_par_impar_Click);
            // 
            // Frm_positivo_negativo_neutro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(860, 478);
            this.Controls.Add(this.Btn_positivo_negativo_neutro);
            this.Controls.Add(this.Txt_positivo_negativo_neutro);
            this.Controls.Add(this.Lbl_positivo_negativo_neutro);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_positivo_negativo_neutro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_positivo_negativo_neutro;
        private System.Windows.Forms.TextBox Txt_positivo_negativo_neutro;
        private System.Windows.Forms.Button Btn_positivo_negativo_neutro;
    }
}