namespace Sayıbulma
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
            this.btesit = new System.Windows.Forms.Button();
            this.lbtut = new System.Windows.Forms.Label();
            this.tbsayi1 = new System.Windows.Forms.TextBox();
            this.lbsayilar = new System.Windows.Forms.ListBox();
            this.tbsayi2 = new System.Windows.Forms.TextBox();
            this.lbislem = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btesit
            // 
            this.btesit.Location = new System.Drawing.Point(146, 179);
            this.btesit.Name = "btesit";
            this.btesit.Size = new System.Drawing.Size(75, 23);
            this.btesit.TabIndex = 0;
            this.btesit.Text = "=";
            this.btesit.UseVisualStyleBackColor = true;
            this.btesit.Click += new System.EventHandler(this.btesit_Click);
            // 
            // lbtut
            // 
            this.lbtut.AutoSize = true;
            this.lbtut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbtut.ForeColor = System.Drawing.Color.DarkRed;
            this.lbtut.Location = new System.Drawing.Point(155, 26);
            this.lbtut.Name = "lbtut";
            this.lbtut.Size = new System.Drawing.Size(52, 29);
            this.lbtut.TabIndex = 1;
            this.lbtut.Text = "000";
            this.lbtut.Click += new System.EventHandler(this.lbtut_Click);
            // 
            // tbsayi1
            // 
            this.tbsayi1.Location = new System.Drawing.Point(24, 72);
            this.tbsayi1.Name = "tbsayi1";
            this.tbsayi1.Size = new System.Drawing.Size(100, 20);
            this.tbsayi1.TabIndex = 2;
            this.tbsayi1.TextChanged += new System.EventHandler(this.tbsayi1_TextChanged);
            // 
            // lbsayilar
            // 
            this.lbsayilar.FormattingEnabled = true;
            this.lbsayilar.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.lbsayilar.Location = new System.Drawing.Point(146, 225);
            this.lbsayilar.Name = "lbsayilar";
            this.lbsayilar.Size = new System.Drawing.Size(70, 121);
            this.lbsayilar.TabIndex = 3;
            this.lbsayilar.SelectedIndexChanged += new System.EventHandler(this.lbsayilar_SelectedIndexChanged);
            this.lbsayilar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbsayilar_MouseDoubleClick);
            // 
            // tbsayi2
            // 
            this.tbsayi2.Location = new System.Drawing.Point(238, 72);
            this.tbsayi2.Name = "tbsayi2";
            this.tbsayi2.Size = new System.Drawing.Size(100, 20);
            this.tbsayi2.TabIndex = 4;
            this.tbsayi2.TextChanged += new System.EventHandler(this.tbsayi2_TextChanged);
            // 
            // lbislem
            // 
            this.lbislem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbislem.FormattingEnabled = true;
            this.lbislem.ItemHeight = 20;
            this.lbislem.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            "/"});
            this.lbislem.Location = new System.Drawing.Point(170, 72);
            this.lbislem.Name = "lbislem";
            this.lbislem.Size = new System.Drawing.Size(17, 84);
            this.lbislem.TabIndex = 5;
            this.lbislem.SelectedIndexChanged += new System.EventHandler(this.lbislem_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "2.Sayi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "1.Sayi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 392);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbislem);
            this.Controls.Add(this.tbsayi2);
            this.Controls.Add(this.lbsayilar);
            this.Controls.Add(this.tbsayi1);
            this.Controls.Add(this.lbtut);
            this.Controls.Add(this.btesit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btesit;
        private System.Windows.Forms.Label lbtut;
        private System.Windows.Forms.TextBox tbsayi1;
        private System.Windows.Forms.ListBox lbsayilar;
        private System.Windows.Forms.TextBox tbsayi2;
        private System.Windows.Forms.ListBox lbislem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

