namespace Winform {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.valueipaddr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valuename = new System.Windows.Forms.TextBox();
            this.valuepass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errBox = new System.Windows.Forms.TextBox();
            this.imageBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ip addr";
            // 
            // valueipaddr
            // 
            this.valueipaddr.Location = new System.Drawing.Point(58, 2);
            this.valueipaddr.Name = "valueipaddr";
            this.valueipaddr.Size = new System.Drawing.Size(100, 20);
            this.valueipaddr.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "password";
            // 
            // valuename
            // 
            this.valuename.Location = new System.Drawing.Point(239, 2);
            this.valuename.Name = "valuename";
            this.valuename.Size = new System.Drawing.Size(100, 20);
            this.valuename.TabIndex = 4;
            // 
            // valuepass
            // 
            this.valuepass.Location = new System.Drawing.Point(425, 2);
            this.valuepass.Name = "valuepass";
            this.valuepass.Size = new System.Drawing.Size(100, 20);
            this.valuepass.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errBox
            // 
            this.errBox.Location = new System.Drawing.Point(16, 37);
            this.errBox.Multiline = true;
            this.errBox.Name = "errBox";
            this.errBox.ReadOnly = true;
            this.errBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.errBox.Size = new System.Drawing.Size(603, 174);
            this.errBox.TabIndex = 7;
            // 
            // imageBox
            // 
            this.imageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBox.Location = new System.Drawing.Point(16, 217);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(682, 510);
            this.imageBox.TabIndex = 8;
            this.imageBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 739);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.errBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.valuepass);
            this.Controls.Add(this.valuename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valueipaddr);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valueipaddr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox valuename;
        private System.Windows.Forms.TextBox valuepass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox errBox;
        private System.Windows.Forms.PictureBox imageBox;
    }
}

