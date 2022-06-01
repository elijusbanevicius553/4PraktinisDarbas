namespace _4Praktinis
{
    partial class Update
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
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_newpassword = new System.Windows.Forms.TextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.textBox_pavadinimas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "<---";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_newpassword
            // 
            this.textBox_newpassword.Location = new System.Drawing.Point(335, 167);
            this.textBox_newpassword.Name = "textBox_newpassword";
            this.textBox_newpassword.Size = new System.Drawing.Size(100, 22);
            this.textBox_newpassword.TabIndex = 4;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(348, 209);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 3;
            this.button_update.Text = "ATNAUJINTI";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // textBox_pavadinimas
            // 
            this.textBox_pavadinimas.Location = new System.Drawing.Point(335, 124);
            this.textBox_pavadinimas.Name = "textBox_pavadinimas";
            this.textBox_pavadinimas.Size = new System.Drawing.Size(100, 22);
            this.textBox_pavadinimas.TabIndex = 6;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_pavadinimas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_newpassword);
            this.Controls.Add(this.button_update);
            this.Name = "Update";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_newpassword;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.TextBox textBox_pavadinimas;
    }
}