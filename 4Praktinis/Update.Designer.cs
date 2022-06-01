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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "<---";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_newpassword
            // 
            this.textBox_newpassword.Location = new System.Drawing.Point(43, 109);
            this.textBox_newpassword.Name = "textBox_newpassword";
            this.textBox_newpassword.Size = new System.Drawing.Size(165, 22);
            this.textBox_newpassword.TabIndex = 4;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(57, 149);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(127, 36);
            this.button_update.TabIndex = 3;
            this.button_update.Text = "ATNAUJINTI";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // textBox_pavadinimas
            // 
            this.textBox_pavadinimas.Location = new System.Drawing.Point(43, 52);
            this.textBox_pavadinimas.Name = "textBox_pavadinimas";
            this.textBox_pavadinimas.Size = new System.Drawing.Size(165, 22);
            this.textBox_pavadinimas.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "PAVADINIMAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "SLAPTAŽODIS";
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 264);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_pavadinimas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_newpassword);
            this.Controls.Add(this.button_update);
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}