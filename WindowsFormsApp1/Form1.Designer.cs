
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputan = new System.Windows.Forms.TextBox();
            this.hurufyangmaudiganti = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.digantidengan = new System.Windows.Forms.TextBox();
            this.konversi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.hasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masukkan Kalimat : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Masukkan Huruf : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // inputan
            // 
            this.inputan.Location = new System.Drawing.Point(200, 59);
            this.inputan.Name = "inputan";
            this.inputan.Size = new System.Drawing.Size(450, 26);
            this.inputan.TabIndex = 2;
            // 
            // hurufyangmaudiganti
            // 
            this.hurufyangmaudiganti.Location = new System.Drawing.Point(200, 91);
            this.hurufyangmaudiganti.Name = "hurufyangmaudiganti";
            this.hurufyangmaudiganti.Size = new System.Drawing.Size(175, 26);
            this.hurufyangmaudiganti.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Menjadi : ";
            // 
            // digantidengan
            // 
            this.digantidengan.Location = new System.Drawing.Point(450, 92);
            this.digantidengan.Name = "digantidengan";
            this.digantidengan.Size = new System.Drawing.Size(200, 26);
            this.digantidengan.TabIndex = 5;
            // 
            // konversi
            // 
            this.konversi.Location = new System.Drawing.Point(200, 133);
            this.konversi.Name = "konversi";
            this.konversi.Size = new System.Drawing.Size(450, 38);
            this.konversi.TabIndex = 6;
            this.konversi.Text = "Konversi";
            this.konversi.UseVisualStyleBackColor = true;
            this.konversi.Click += new System.EventHandler(this.konversi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "hasil : ";
            // 
            // hasil
            // 
            this.hasil.AutoSize = true;
            this.hasil.Location = new System.Drawing.Point(117, 209);
            this.hasil.Name = "hasil";
            this.hasil.Size = new System.Drawing.Size(0, 20);
            this.hasil.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hasil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.konversi);
            this.Controls.Add(this.digantidengan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hurufyangmaudiganti);
            this.Controls.Add(this.inputan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "konversi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputan;
        private System.Windows.Forms.TextBox hurufyangmaudiganti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox digantidengan;
        private System.Windows.Forms.Button konversi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label hasil;
    }
}

