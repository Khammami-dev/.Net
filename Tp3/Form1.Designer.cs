
namespace Tp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.lst2 = new System.Windows.Forms.ListBox();
            this.btnEffacer1 = new System.Windows.Forms.Button();
            this.btnEffacer2 = new System.Windows.Forms.Button();
            this.btnChangeLst2 = new System.Windows.Forms.Button();
            this.btnChangeLst1 = new System.Windows.Forms.Button();
            this.btnToutEffacer1 = new System.Windows.Forms.Button();
            this.btnToutEffacer2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Saisie";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Enabled = false;
            this.btnAjouter.Location = new System.Drawing.Point(251, 25);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(92, 24);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.ItemHeight = 15;
            this.lst1.Location = new System.Drawing.Point(23, 105);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(236, 184);
            this.lst1.TabIndex = 3;
            this.lst1.SelectedIndexChanged += new System.EventHandler(this.lst1_SelectedIndexChanged);
            // 
            // lst2
            // 
            this.lst2.FormattingEnabled = true;
            this.lst2.ItemHeight = 15;
            this.lst2.Location = new System.Drawing.Point(414, 105);
            this.lst2.Name = "lst2";
            this.lst2.Size = new System.Drawing.Size(226, 184);
            this.lst2.TabIndex = 4;
            this.lst2.SelectedIndexChanged += new System.EventHandler(this.lst2_SelectedIndexChanged);
            // 
            // btnEffacer1
            // 
            this.btnEffacer1.Enabled = false;
            this.btnEffacer1.Location = new System.Drawing.Point(23, 295);
            this.btnEffacer1.Name = "btnEffacer1";
            this.btnEffacer1.Size = new System.Drawing.Size(106, 33);
            this.btnEffacer1.TabIndex = 5;
            this.btnEffacer1.Text = "Effacer";
            this.btnEffacer1.UseVisualStyleBackColor = true;
            this.btnEffacer1.Click += new System.EventHandler(this.btnEffacer1_Click);
            // 
            // btnEffacer2
            // 
            this.btnEffacer2.Enabled = false;
            this.btnEffacer2.Location = new System.Drawing.Point(414, 295);
            this.btnEffacer2.Name = "btnEffacer2";
            this.btnEffacer2.Size = new System.Drawing.Size(94, 33);
            this.btnEffacer2.TabIndex = 6;
            this.btnEffacer2.Text = "Effacer";
            this.btnEffacer2.UseVisualStyleBackColor = true;
            this.btnEffacer2.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnChangeLst2
            // 
            this.btnChangeLst2.Enabled = false;
            this.btnChangeLst2.Location = new System.Drawing.Point(287, 154);
            this.btnChangeLst2.Name = "btnChangeLst2";
            this.btnChangeLst2.Size = new System.Drawing.Size(83, 26);
            this.btnChangeLst2.TabIndex = 7;
            this.btnChangeLst2.Text = "-->";
            this.btnChangeLst2.UseVisualStyleBackColor = true;
            this.btnChangeLst2.Click += new System.EventHandler(this.btnChangeLst2_Click);
            // 
            // btnChangeLst1
            // 
            this.btnChangeLst1.Enabled = false;
            this.btnChangeLst1.Location = new System.Drawing.Point(287, 219);
            this.btnChangeLst1.Name = "btnChangeLst1";
            this.btnChangeLst1.Size = new System.Drawing.Size(83, 26);
            this.btnChangeLst1.TabIndex = 8;
            this.btnChangeLst1.Text = "<--";
            this.btnChangeLst1.UseVisualStyleBackColor = true;
            this.btnChangeLst1.Click += new System.EventHandler(this.btnChangeLst1_Click);
            // 
            // btnToutEffacer1
            // 
            this.btnToutEffacer1.Enabled = false;
            this.btnToutEffacer1.Location = new System.Drawing.Point(150, 295);
            this.btnToutEffacer1.Name = "btnToutEffacer1";
            this.btnToutEffacer1.Size = new System.Drawing.Size(109, 33);
            this.btnToutEffacer1.TabIndex = 9;
            this.btnToutEffacer1.Text = "Tout Effacer";
            this.btnToutEffacer1.UseVisualStyleBackColor = true;
            this.btnToutEffacer1.Click += new System.EventHandler(this.btnToutEffacer1_Click);
            // 
            // btnToutEffacer2
            // 
            this.btnToutEffacer2.Enabled = false;
            this.btnToutEffacer2.Location = new System.Drawing.Point(530, 295);
            this.btnToutEffacer2.Name = "btnToutEffacer2";
            this.btnToutEffacer2.Size = new System.Drawing.Size(110, 33);
            this.btnToutEffacer2.TabIndex = 10;
            this.btnToutEffacer2.Text = "Tout Effacer";
            this.btnToutEffacer2.UseVisualStyleBackColor = true;
            this.btnToutEffacer2.Click += new System.EventHandler(this.btnToutEffacer2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 379);
            this.Controls.Add(this.btnToutEffacer2);
            this.Controls.Add(this.btnToutEffacer1);
            this.Controls.Add(this.btnChangeLst1);
            this.Controls.Add(this.btnChangeLst2);
            this.Controls.Add(this.btnEffacer2);
            this.Controls.Add(this.btnEffacer1);
            this.Controls.Add(this.lst2);
            this.Controls.Add(this.lst1);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.ListBox lst2;
        private System.Windows.Forms.Button btnEffacer1;
        private System.Windows.Forms.Button btnEffacer2;
        private System.Windows.Forms.Button btnChangeLst2;
        private System.Windows.Forms.Button btnChangeLst1;
        private System.Windows.Forms.Button btnToutEffacer1;
        private System.Windows.Forms.Button btnToutEffacer2;
    }
}

