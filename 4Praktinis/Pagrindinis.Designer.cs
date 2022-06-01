namespace _4Praktinis
{
    partial class Pagrindinis
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
            this.button_atsijungti = new System.Windows.Forms.Button();
            this.listBox_data = new System.Windows.Forms.ListBox();
            this.button_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_atsijungti
            // 
            this.button_atsijungti.Location = new System.Drawing.Point(669, 12);
            this.button_atsijungti.Name = "button_atsijungti";
            this.button_atsijungti.Size = new System.Drawing.Size(119, 23);
            this.button_atsijungti.TabIndex = 0;
            this.button_atsijungti.Text = "ATSIJUNGTI";
            this.button_atsijungti.UseVisualStyleBackColor = true;
            this.button_atsijungti.Click += new System.EventHandler(this.button_atsijungti_Click);
            // 
            // listBox_data
            // 
            this.listBox_data.FormattingEnabled = true;
            this.listBox_data.ItemHeight = 16;
            this.listBox_data.Location = new System.Drawing.Point(83, 71);
            this.listBox_data.Name = "listBox_data";
            this.listBox_data.Size = new System.Drawing.Size(613, 324);
            this.listBox_data.TabIndex = 1;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(288, 401);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // Pagrindinis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.listBox_data);
            this.Controls.Add(this.button_atsijungti);
            this.Name = "Pagrindinis";
            this.Text = "Pagrindinis";
            this.Load += new System.EventHandler(this.Pagrindinis_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_atsijungti;
        private System.Windows.Forms.ListBox listBox_data;
        private System.Windows.Forms.Button button_add;
    }
}