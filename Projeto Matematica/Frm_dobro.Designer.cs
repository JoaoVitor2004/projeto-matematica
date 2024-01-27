
namespace Projeto_Matematica
{
    partial class Frm_dobro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_dobro));
            this.Lbl_dobro = new System.Windows.Forms.Label();
            this.Txt_dobro = new System.Windows.Forms.TextBox();
            this.Btn_dobro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_dobro
            // 
            this.Lbl_dobro.AutoSize = true;
            this.Lbl_dobro.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_dobro.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_dobro.ForeColor = System.Drawing.Color.White;
            this.Lbl_dobro.Location = new System.Drawing.Point(93, 205);
            this.Lbl_dobro.Name = "Lbl_dobro";
            this.Lbl_dobro.Size = new System.Drawing.Size(302, 32);
            this.Lbl_dobro.TabIndex = 0;
            this.Lbl_dobro.Text = "Digite um Número:";
            // 
            // Txt_dobro
            // 
            this.Txt_dobro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Txt_dobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_dobro.ForeColor = System.Drawing.Color.White;
            this.Txt_dobro.Location = new System.Drawing.Point(192, 262);
            this.Txt_dobro.Name = "Txt_dobro";
            this.Txt_dobro.Size = new System.Drawing.Size(81, 31);
            this.Txt_dobro.TabIndex = 1;
            this.Txt_dobro.TextChanged += new System.EventHandler(this.Txt_dobro_TextChanged);
            this.Txt_dobro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_dobro_KeyPress);
            // 
            // Btn_dobro
            // 
            this.Btn_dobro.BackColor = System.Drawing.Color.Transparent;
            this.Btn_dobro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_dobro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Btn_dobro.FlatAppearance.BorderSize = 2;
            this.Btn_dobro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Btn_dobro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Btn_dobro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_dobro.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_dobro.ForeColor = System.Drawing.Color.White;
            this.Btn_dobro.Location = new System.Drawing.Point(674, 25);
            this.Btn_dobro.Name = "Btn_dobro";
            this.Btn_dobro.Size = new System.Drawing.Size(103, 40);
            this.Btn_dobro.TabIndex = 2;
            this.Btn_dobro.Text = "Voltar";
            this.Btn_dobro.UseVisualStyleBackColor = false;
            this.Btn_dobro.Click += new System.EventHandler(this.Btn_par_impar_Click);
            // 
            // Frm_dobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_dobro);
            this.Controls.Add(this.Txt_dobro);
            this.Controls.Add(this.Lbl_dobro);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_dobro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_dobro;
        private System.Windows.Forms.TextBox Txt_dobro;
        private System.Windows.Forms.Button Btn_dobro;
    }
}