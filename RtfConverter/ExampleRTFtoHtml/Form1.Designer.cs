namespace ExampleRTFtoHtml
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
            this.rtf = new System.Windows.Forms.TextBox();
            this.convert = new System.Windows.Forms.Button();
            this.html = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtf
            // 
            this.rtf.Location = new System.Drawing.Point(60, 28);
            this.rtf.Multiline = true;
            this.rtf.Name = "rtf";
            this.rtf.Size = new System.Drawing.Size(420, 97);
            this.rtf.TabIndex = 0;
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(405, 131);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(75, 23);
            this.convert.TabIndex = 1;
            this.convert.Text = "Convert";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // html
            // 
            this.html.Location = new System.Drawing.Point(60, 178);
            this.html.Multiline = true;
            this.html.Name = "html";
            this.html.Size = new System.Drawing.Size(420, 97);
            this.html.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "RTF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "HTML";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 287);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.html);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.rtf);
            this.Name = "Form1";
            this.Text = "Conversión RFT A HTML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rtf;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.TextBox html;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

