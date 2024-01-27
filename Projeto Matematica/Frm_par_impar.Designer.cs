
namespace Projeto_Matematica
{
    partial class Frm_par_impar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_par_impar));
            this.Lbl_par_impar = new System.Windows.Forms.Label();
            this.Txt_par_impar = new System.Windows.Forms.TextBox();
            this.Btn_par_impar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_par_impar
            // 
            this.Lbl_par_impar.AutoSize = true;
            this.Lbl_par_impar.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_par_impar.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_par_impar.ForeColor = System.Drawing.Color.White;
            this.Lbl_par_impar.Location = new System.Drawing.Point(141, 277);
            this.Lbl_par_impar.Name = "Lbl_par_impar";
            this.Lbl_par_impar.Size = new System.Drawing.Size(415, 45);
            this.Lbl_par_impar.TabIndex = 3;
            this.Lbl_par_impar.Text = "Digite um Número:";
            // 
            // Txt_par_impar
            // 
            this.Txt_par_impar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Txt_par_impar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_par_impar.ForeColor = System.Drawing.Color.White;
            this.Txt_par_impar.Location = new System.Drawing.Point(260, 353);
            this.Txt_par_impar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_par_impar.MaxLength = 9;
            this.Txt_par_impar.Name = "Txt_par_impar";
            this.Txt_par_impar.Size = new System.Drawing.Size(147, 37);
            this.Txt_par_impar.TabIndex = 4;
            this.Txt_par_impar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Txt_par_impar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_par_impar_KeyPress);
            // 
            // Btn_par_impar
            // 
            this.Btn_par_impar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_par_impar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_par_impar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Btn_par_impar.FlatAppearance.BorderSize = 2;
            this.Btn_par_impar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Btn_par_impar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Btn_par_impar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_par_impar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_par_impar.ForeColor = System.Drawing.Color.White;
            this.Btn_par_impar.Location = new System.Drawing.Point(972, 30);
            this.Btn_par_impar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_par_impar.Name = "Btn_par_impar";
            this.Btn_par_impar.Size = new System.Drawing.Size(137, 50);
            this.Btn_par_impar.TabIndex = 5;
            this.Btn_par_impar.Text = "Voltar";
            this.Btn_par_impar.UseVisualStyleBackColor = false;
            this.Btn_par_impar.Click += new System.EventHandler(this.Btn_par_impar_Click);
            // 
            // Frm_par_impar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1133, 607);
            this.Controls.Add(this.Btn_par_impar);
            this.Controls.Add(this.Txt_par_impar);
            this.Controls.Add(this.Lbl_par_impar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_par_impar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_par_impar;
        private System.Windows.Forms.TextBox Txt_par_impar;
        private System.Windows.Forms.Button Btn_par_impar;
    }
}