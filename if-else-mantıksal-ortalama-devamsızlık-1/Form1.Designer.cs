namespace if_else_mantıksal_ortalama_devamsızlık_1
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
            this.txtDevamsizlik = new System.Windows.Forms.TextBox();
            this.btnOrtalama = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.lblDevamsizlik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDevamsizlik
            // 
            this.txtDevamsizlik.Location = new System.Drawing.Point(65, 64);
            this.txtDevamsizlik.Name = "txtDevamsizlik";
            this.txtDevamsizlik.Size = new System.Drawing.Size(100, 20);
            this.txtDevamsizlik.TabIndex = 3;
            // 
            // btnOrtalama
            // 
            this.btnOrtalama.Location = new System.Drawing.Point(65, 110);
            this.btnOrtalama.Name = "btnOrtalama";
            this.btnOrtalama.Size = new System.Drawing.Size(100, 36);
            this.btnOrtalama.TabIndex = 4;
            this.btnOrtalama.Text = "Ortalama";
            this.btnOrtalama.UseVisualStyleBackColor = true;
            this.btnOrtalama.Click += new System.EventHandler(this.btnOrtalama_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(62, 170);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(38, 13);
            this.lblSonuc.TabIndex = 5;
            this.lblSonuc.Text = "Sonuç";
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(65, 27);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(100, 20);
            this.txtOrtalama.TabIndex = 6;
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Location = new System.Drawing.Point(10, 30);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(49, 13);
            this.lblOrtalama.TabIndex = 7;
            this.lblOrtalama.Text = "Ortalama";
            // 
            // lblDevamsizlik
            // 
            this.lblDevamsizlik.AutoSize = true;
            this.lblDevamsizlik.Location = new System.Drawing.Point(-4, 67);
            this.lblDevamsizlik.Name = "lblDevamsizlik";
            this.lblDevamsizlik.Size = new System.Drawing.Size(63, 13);
            this.lblDevamsizlik.TabIndex = 8;
            this.lblDevamsizlik.Text = "Devamsızlık";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 208);
            this.Controls.Add(this.lblDevamsizlik);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnOrtalama);
            this.Controls.Add(this.txtDevamsizlik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.Label lblDevamsizlik;
        private System.Windows.Forms.TextBox txtDevamsizlik;
        private System.Windows.Forms.Button btnOrtalama;
        private System.Windows.Forms.Label lblSonuc;
        
    }
}

