namespace Manav
{
    partial class urunsil
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
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RosyBrown;
            this.button2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(503, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 45);
            this.button2.TabIndex = 21;
            this.button2.Text = "Geri Dön -->";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(352, 214);
            this.listBox1.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(519, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(381, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ürün Barkodu :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(519, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ürünü Sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(608, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "NOT = Lütfen silmek istediğiniz ürünün SADECE barkodunu giriniz.";
            // 
            // urunsil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(646, 298);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "urunsil";
            this.Text = "urunsil";
            this.Load += new System.EventHandler(this.urunsil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button2;
        private ListBox listBox1;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Label label2;
    }
}