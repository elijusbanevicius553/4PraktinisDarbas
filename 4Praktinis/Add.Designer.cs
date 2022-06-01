namespace _4Praktinis
{
    partial class Add
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
            this.textBox_pav = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_url = new System.Windows.Forms.TextBox();
            this.textBox_comment = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_pav
            // 
            this.textBox_pav.Location = new System.Drawing.Point(270, 72);
            this.textBox_pav.Name = "textBox_pav";
            this.textBox_pav.Size = new System.Drawing.Size(226, 22);
            this.textBox_pav.TabIndex = 0;
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(270, 118);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(226, 22);
            this.textBox_username.TabIndex = 1;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(270, 163);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(226, 22);
            this.textBox_password.TabIndex = 2;
            // 
            // textBox_url
            // 
            this.textBox_url.Location = new System.Drawing.Point(270, 211);
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.Size = new System.Drawing.Size(226, 22);
            this.textBox_url.TabIndex = 3;
            // 
            // textBox_comment
            // 
            this.textBox_comment.Location = new System.Drawing.Point(270, 252);
            this.textBox_comment.Name = "textBox_comment";
            this.textBox_comment.Size = new System.Drawing.Size(226, 22);
            this.textBox_comment.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generuoti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(341, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "PRIDĖTI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_comment);
            this.Controls.Add(this.textBox_url);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.textBox_pav);
            this.Name = "Add";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_pav;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_url;
        private System.Windows.Forms.TextBox textBox_comment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}