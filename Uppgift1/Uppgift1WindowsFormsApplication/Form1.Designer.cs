namespace Uppgift1WindowsFormsApplication
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.fileNametextBox = new System.Windows.Forms.TextBox();
            this.openFilebutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(622, 513);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uppgift1";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.richTextBox);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 104);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(598, 373);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(6, 6);
            this.richTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(588, 364);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.fileNametextBox);
            this.flowLayoutPanel1.Controls.Add(this.openFilebutton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 37);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(374, 71);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // fileNametextBox
            // 
            this.fileNametextBox.Location = new System.Drawing.Point(6, 6);
            this.fileNametextBox.Margin = new System.Windows.Forms.Padding(6);
            this.fileNametextBox.Name = "fileNametextBox";
            this.fileNametextBox.Size = new System.Drawing.Size(196, 31);
            this.fileNametextBox.TabIndex = 1;
            this.fileNametextBox.Text = "Skriv filnamn";
            // 
            // openFilebutton
            // 
            this.openFilebutton.Location = new System.Drawing.Point(214, 6);
            this.openFilebutton.Margin = new System.Windows.Forms.Padding(6);
            this.openFilebutton.Name = "openFilebutton";
            this.openFilebutton.Size = new System.Drawing.Size(150, 44);
            this.openFilebutton.TabIndex = 0;
            this.openFilebutton.Text = "Öppna";
            this.openFilebutton.UseVisualStyleBackColor = true;
            this.openFilebutton.Click += new System.EventHandler(this.openFilebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 560);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox fileNametextBox;
        private System.Windows.Forms.Button openFilebutton;
    }
}

