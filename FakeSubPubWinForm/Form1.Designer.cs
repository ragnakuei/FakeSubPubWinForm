namespace FakeSubPubWinForm
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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnOpenForm2 = new System.Windows.Forms.Button();
            this.btnOpenForm3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "name";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(106, 38);
            this.tbxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(110, 23);
            this.tbxName.TabIndex = 1;
            this.tbxName.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // btnOpenForm2
            // 
            this.btnOpenForm2.Location = new System.Drawing.Point(313, 36);
            this.btnOpenForm2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenForm2.Name = "btnOpenForm2";
            this.btnOpenForm2.Size = new System.Drawing.Size(87, 29);
            this.btnOpenForm2.TabIndex = 2;
            this.btnOpenForm2.Text = "Open Form2";
            this.btnOpenForm2.UseVisualStyleBackColor = true;
            this.btnOpenForm2.Click += new System.EventHandler(this.BtnOpenForm2_Click);
            // 
            // btnOpenForm3
            // 
            this.btnOpenForm3.Location = new System.Drawing.Point(313, 89);
            this.btnOpenForm3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenForm3.Name = "btnOpenForm3";
            this.btnOpenForm3.Size = new System.Drawing.Size(87, 29);
            this.btnOpenForm3.TabIndex = 3;
            this.btnOpenForm3.Text = "Open Form3";
            this.btnOpenForm3.UseVisualStyleBackColor = true;
            this.btnOpenForm3.Click += new System.EventHandler(this.BtnOpenForm3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 184);
            this.Controls.Add(this.btnOpenForm3);
            this.Controls.Add(this.btnOpenForm2);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnOpenForm2;
        private System.Windows.Forms.Button btnOpenForm3;
    }
}

