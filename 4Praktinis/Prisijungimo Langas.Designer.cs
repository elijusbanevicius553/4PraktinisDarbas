namespace _4Praktinis
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
            this.button_PRISIJUNGIMAS = new System.Windows.Forms.Button();
            this.button_REGISTRACIJA = new System.Windows.Forms.Button();
            this.panel_Prisijungimas = new System.Windows.Forms.Panel();
            this.button_PRISIJUNGTI = new System.Windows.Forms.Button();
            this.textBox_pri_password = new System.Windows.Forms.TextBox();
            this.textBox_pri_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Registracija = new System.Windows.Forms.Panel();
            this.button_REGISTRUOTIS = new System.Windows.Forms.Button();
            this.textBox_reg_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_reg_username = new System.Windows.Forms.TextBox();
            this.panel_Prisijungimas.SuspendLayout();
            this.panel_Registracija.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_PRISIJUNGIMAS
            // 
            this.button_PRISIJUNGIMAS.Location = new System.Drawing.Point(246, 55);
            this.button_PRISIJUNGIMAS.Name = "button_PRISIJUNGIMAS";
            this.button_PRISIJUNGIMAS.Size = new System.Drawing.Size(154, 35);
            this.button_PRISIJUNGIMAS.TabIndex = 0;
            this.button_PRISIJUNGIMAS.Text = "PRISIJUNGIMAS";
            this.button_PRISIJUNGIMAS.UseVisualStyleBackColor = true;
            this.button_PRISIJUNGIMAS.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_REGISTRACIJA
            // 
            this.button_REGISTRACIJA.Location = new System.Drawing.Point(431, 55);
            this.button_REGISTRACIJA.Name = "button_REGISTRACIJA";
            this.button_REGISTRACIJA.Size = new System.Drawing.Size(154, 35);
            this.button_REGISTRACIJA.TabIndex = 1;
            this.button_REGISTRACIJA.Text = "REGISTRACIJA";
            this.button_REGISTRACIJA.UseVisualStyleBackColor = true;
            this.button_REGISTRACIJA.Click += new System.EventHandler(this.button_REGISTRACIJA_Click);
            // 
            // panel_Prisijungimas
            // 
            this.panel_Prisijungimas.Controls.Add(this.button_PRISIJUNGTI);
            this.panel_Prisijungimas.Controls.Add(this.textBox_pri_password);
            this.panel_Prisijungimas.Controls.Add(this.textBox_pri_username);
            this.panel_Prisijungimas.Controls.Add(this.label1);
            this.panel_Prisijungimas.Location = new System.Drawing.Point(53, 120);
            this.panel_Prisijungimas.Name = "panel_Prisijungimas";
            this.panel_Prisijungimas.Size = new System.Drawing.Size(347, 297);
            this.panel_Prisijungimas.TabIndex = 2;
            this.panel_Prisijungimas.Visible = false;
            // 
            // button_PRISIJUNGTI
            // 
            this.button_PRISIJUNGTI.Location = new System.Drawing.Point(92, 169);
            this.button_PRISIJUNGTI.Name = "button_PRISIJUNGTI";
            this.button_PRISIJUNGTI.Size = new System.Drawing.Size(154, 35);
            this.button_PRISIJUNGTI.TabIndex = 4;
            this.button_PRISIJUNGTI.Text = "PRISIJUNGTI";
            this.button_PRISIJUNGTI.UseVisualStyleBackColor = true;
            this.button_PRISIJUNGTI.Click += new System.EventHandler(this.button_PRISIJUNGTI_Click);
            // 
            // textBox_pri_password
            // 
            this.textBox_pri_password.Location = new System.Drawing.Point(62, 109);
            this.textBox_pri_password.Name = "textBox_pri_password";
            this.textBox_pri_password.Size = new System.Drawing.Size(212, 22);
            this.textBox_pri_password.TabIndex = 2;
            // 
            // textBox_pri_username
            // 
            this.textBox_pri_username.Location = new System.Drawing.Point(62, 61);
            this.textBox_pri_username.Name = "textBox_pri_username";
            this.textBox_pri_username.Size = new System.Drawing.Size(212, 22);
            this.textBox_pri_username.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRISIJUNGIMAS";
            // 
            // panel_Registracija
            // 
            this.panel_Registracija.Controls.Add(this.button_REGISTRUOTIS);
            this.panel_Registracija.Controls.Add(this.textBox_reg_password);
            this.panel_Registracija.Controls.Add(this.label2);
            this.panel_Registracija.Controls.Add(this.textBox_reg_username);
            this.panel_Registracija.Location = new System.Drawing.Point(431, 120);
            this.panel_Registracija.Name = "panel_Registracija";
            this.panel_Registracija.Size = new System.Drawing.Size(347, 297);
            this.panel_Registracija.TabIndex = 3;
            this.panel_Registracija.Visible = false;
            // 
            // button_REGISTRUOTIS
            // 
            this.button_REGISTRUOTIS.Location = new System.Drawing.Point(95, 169);
            this.button_REGISTRUOTIS.Name = "button_REGISTRUOTIS";
            this.button_REGISTRUOTIS.Size = new System.Drawing.Size(154, 35);
            this.button_REGISTRUOTIS.TabIndex = 4;
            this.button_REGISTRUOTIS.Text = "REGISTRUOTIS";
            this.button_REGISTRUOTIS.UseVisualStyleBackColor = true;
            this.button_REGISTRUOTIS.Click += new System.EventHandler(this.button_REGISTRUOTIS_Click);
            // 
            // textBox_reg_password
            // 
            this.textBox_reg_password.Location = new System.Drawing.Point(70, 109);
            this.textBox_reg_password.Name = "textBox_reg_password";
            this.textBox_reg_password.Size = new System.Drawing.Size(212, 22);
            this.textBox_reg_password.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "REGISTRACIJA";
            // 
            // textBox_reg_username
            // 
            this.textBox_reg_username.Location = new System.Drawing.Point(70, 61);
            this.textBox_reg_username.Name = "textBox_reg_username";
            this.textBox_reg_username.Size = new System.Drawing.Size(212, 22);
            this.textBox_reg_username.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_Registracija);
            this.Controls.Add(this.panel_Prisijungimas);
            this.Controls.Add(this.button_REGISTRACIJA);
            this.Controls.Add(this.button_PRISIJUNGIMAS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_Prisijungimas.ResumeLayout(false);
            this.panel_Prisijungimas.PerformLayout();
            this.panel_Registracija.ResumeLayout(false);
            this.panel_Registracija.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_PRISIJUNGIMAS;
        private System.Windows.Forms.Button button_REGISTRACIJA;
        private System.Windows.Forms.Panel panel_Prisijungimas;
        private System.Windows.Forms.Button button_PRISIJUNGTI;
        private System.Windows.Forms.TextBox textBox_pri_password;
        private System.Windows.Forms.TextBox textBox_pri_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Registracija;
        private System.Windows.Forms.Button button_REGISTRUOTIS;
        private System.Windows.Forms.TextBox textBox_reg_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_reg_username;
    }
}

