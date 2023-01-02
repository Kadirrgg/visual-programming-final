namespace Manav
{
    partial class kasiyergiris
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(169, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ürün Ekleme";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(296, 75);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(329, 184);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LawnGreen;
            this.button2.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(42, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ürün Güncelle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(44, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 55);
            this.button3.TabIndex = 3;
            this.button3.Text = "Ürün Silme";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(12, 256);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 39);
            this.button4.TabIndex = 5;
            this.button4.Text = "Çıkış Yap";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Güncel değerleri görmek için lütfen çıkış yapıp yeniden girmelisiniz.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(364, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Depodaki Ürünler :";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button5.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(169, 157);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 55);
            this.button5.TabIndex = 9;
            this.button5.Text = "Çalışanı Ekle/Sil";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // kasiyergiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(646, 307);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "kasiyergiris";
            this.Text = "kasiyergiris";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.kasiyergiris_FormClosed);
            this.Load += new System.EventHandler(this.kasiyergiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Button button5;
    }
}