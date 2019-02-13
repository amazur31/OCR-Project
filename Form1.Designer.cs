namespace OCR_Project
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
            this.button1 = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputText = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Capture_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(89, 12);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(232, 20);
            this.inputBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Photo URL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(15, 132);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(309, 120);
            this.outputText.TabIndex = 4;
            this.outputText.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(246, 67);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 23);
            this.Load.TabIndex = 6;
            this.Load.Text = "Capture";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 264);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "OCR Test";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox outputText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Load;
    }
}

