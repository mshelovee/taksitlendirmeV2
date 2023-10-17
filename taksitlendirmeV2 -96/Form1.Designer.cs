namespace taksitlendirmeV2__96
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.rbTaksit0 = new System.Windows.Forms.RadioButton();
            this.rbTaksit5 = new System.Windows.Forms.RadioButton();
            this.rbTaksit4 = new System.Windows.Forms.RadioButton();
            this.rbTaksit2 = new System.Windows.Forms.RadioButton();
            this.rbTaksit3 = new System.Windows.Forms.RadioButton();
            this.btnOde = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.rbTaksit5);
            this.groupBox1.Controls.Add(this.rbTaksit0);
            this.groupBox1.Controls.Add(this.rbTaksit4);
            this.groupBox1.Controls.Add(this.rbTaksit2);
            this.groupBox1.Controls.Add(this.rbTaksit3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(16, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 291);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme Şekli";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Tutar:";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(137, 34);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(121, 20);
            this.txtTutar.TabIndex = 1;
            // 
            // rbTaksit0
            // 
            this.rbTaksit0.AutoSize = true;
            this.rbTaksit0.Location = new System.Drawing.Point(15, 56);
            this.rbTaksit0.Name = "rbTaksit0";
            this.rbTaksit0.Size = new System.Drawing.Size(99, 20);
            this.rbTaksit0.TabIndex = 0;
            this.rbTaksit0.TabStop = true;
            this.rbTaksit0.Text = "Tek Çekim";
            this.rbTaksit0.UseVisualStyleBackColor = true;
            // 
            // rbTaksit5
            // 
            this.rbTaksit5.AutoSize = true;
            this.rbTaksit5.Location = new System.Drawing.Point(15, 226);
            this.rbTaksit5.Name = "rbTaksit5";
            this.rbTaksit5.Size = new System.Drawing.Size(183, 20);
            this.rbTaksit5.TabIndex = 1;
            this.rbTaksit5.TabStop = true;
            this.rbTaksit5.Text = "5 Taksit (%10 Ek Fiyat)";
            this.rbTaksit5.UseVisualStyleBackColor = true;
            // 
            // rbTaksit4
            // 
            this.rbTaksit4.AutoSize = true;
            this.rbTaksit4.Location = new System.Drawing.Point(15, 184);
            this.rbTaksit4.Name = "rbTaksit4";
            this.rbTaksit4.Size = new System.Drawing.Size(183, 20);
            this.rbTaksit4.TabIndex = 2;
            this.rbTaksit4.TabStop = true;
            this.rbTaksit4.Text = "4 Taksit (%10 Ek Fiyat)";
            this.rbTaksit4.UseVisualStyleBackColor = true;
            // 
            // rbTaksit2
            // 
            this.rbTaksit2.AutoSize = true;
            this.rbTaksit2.Location = new System.Drawing.Point(15, 97);
            this.rbTaksit2.Name = "rbTaksit2";
            this.rbTaksit2.Size = new System.Drawing.Size(179, 20);
            this.rbTaksit2.TabIndex = 3;
            this.rbTaksit2.TabStop = true;
            this.rbTaksit2.Text = "2 Taksit (% 5 Ek Fiyat)";
            this.rbTaksit2.UseVisualStyleBackColor = true;
            // 
            // rbTaksit3
            // 
            this.rbTaksit3.AutoSize = true;
            this.rbTaksit3.Location = new System.Drawing.Point(15, 141);
            this.rbTaksit3.Name = "rbTaksit3";
            this.rbTaksit3.Size = new System.Drawing.Size(179, 20);
            this.rbTaksit3.TabIndex = 4;
            this.rbTaksit3.TabStop = true;
            this.rbTaksit3.Text = "3 Taksit (% 5 Ek Fiyat)";
            this.rbTaksit3.UseVisualStyleBackColor = true;
            // 
            // btnOde
            // 
            this.btnOde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOde.Location = new System.Drawing.Point(16, 435);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(242, 38);
            this.btnOde.TabIndex = 5;
            this.btnOde.Text = "Ödeme Yap";
            this.btnOde.UseVisualStyleBackColor = true;
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 501);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rbTaksit5;
        private System.Windows.Forms.RadioButton rbTaksit0;
        private System.Windows.Forms.RadioButton rbTaksit4;
        private System.Windows.Forms.RadioButton rbTaksit2;
        private System.Windows.Forms.RadioButton rbTaksit3;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Button btnOde;
    }
}

