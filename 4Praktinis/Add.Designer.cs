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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_pav
            // 
            this.textBox_pav.Location = new System.Drawing.Point(29, 40);
            this.textBox_pav.Name = "textBox_pav";
            this.textBox_pav.Size = new System.Drawing.Size(276, 22);
            this.textBox_pav.TabIndex = 0;
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(29, 86);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(276, 22);
            this.textBox_username.TabIndex = 1;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(30, 130);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(276, 22);
            this.textBox_password.TabIndex = 2;
            // 
            // textBox_url
            // 
            this.textBox_url.Location = new System.Drawing.Point(29, 178);
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.Size = new System.Drawing.Size(276, 22);
            this.textBox_url.TabIndex = 3;
            // 
            // textBox_comment
            // 
            this.textBox_comment.Location = new System.Drawing.Point(29, 233);
            this.textBox_comment.Multiline = true;
            this.textBox_comment.Name = "textBox_comment";
            this.textBox_comment.Size = new System.Drawing.Size(276, 85);
            this.textBox_comment.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "GENERUOTI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "PRIDĖTI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "PAVADINIMAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "SLAPYVARDIS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "SLAPTAŽODIS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "URL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "KOMENTARAS";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "<---";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 440);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_comment);
            this.Controls.Add(this.textBox_url);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.textBox_pav);
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
    }
}