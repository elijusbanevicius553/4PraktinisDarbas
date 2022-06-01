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
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.button_add.Location = new System.Drawing.Point(277, 401);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(439, 401);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 3;
            this.button_Delete.Text = "DELETE";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(358, 401);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 4;
            this.button_update.Text = "UPDATE";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(702, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "SHOW";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pagrindinis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_Delete);
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
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button1;
    }
}