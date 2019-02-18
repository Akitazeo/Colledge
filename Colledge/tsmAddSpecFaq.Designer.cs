namespace Colledge
{
    partial class tsmAddSpecFaq
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
            this.tsmUchenikAddCancel = new System.Windows.Forms.Button();
            this.tsmUchenikAddSave = new System.Windows.Forms.Button();
            this.tsmUchenikAddIDNP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tsmUchenikAddCancel
            // 
            this.tsmUchenikAddCancel.BackColor = System.Drawing.Color.Transparent;
            this.tsmUchenikAddCancel.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmUchenikAddCancel.Location = new System.Drawing.Point(174, 156);
            this.tsmUchenikAddCancel.Name = "tsmUchenikAddCancel";
            this.tsmUchenikAddCancel.Size = new System.Drawing.Size(75, 27);
            this.tsmUchenikAddCancel.TabIndex = 10;
            this.tsmUchenikAddCancel.Text = "Cancel";
            this.tsmUchenikAddCancel.UseVisualStyleBackColor = false;
            // 
            // tsmUchenikAddSave
            // 
            this.tsmUchenikAddSave.BackColor = System.Drawing.Color.Transparent;
            this.tsmUchenikAddSave.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmUchenikAddSave.Location = new System.Drawing.Point(16, 156);
            this.tsmUchenikAddSave.Name = "tsmUchenikAddSave";
            this.tsmUchenikAddSave.Size = new System.Drawing.Size(75, 27);
            this.tsmUchenikAddSave.TabIndex = 9;
            this.tsmUchenikAddSave.Text = "SAVE";
            this.tsmUchenikAddSave.UseVisualStyleBackColor = false;
            // 
            // tsmUchenikAddIDNP
            // 
            this.tsmUchenikAddIDNP.BackColor = System.Drawing.Color.Transparent;
            this.tsmUchenikAddIDNP.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmUchenikAddIDNP.ForeColor = System.Drawing.Color.Black;
            this.tsmUchenikAddIDNP.Location = new System.Drawing.Point(12, 9);
            this.tsmUchenikAddIDNP.Name = "tsmUchenikAddIDNP";
            this.tsmUchenikAddIDNP.Size = new System.Drawing.Size(118, 51);
            this.tsmUchenikAddIDNP.TabIndex = 8;
            this.tsmUchenikAddIDNP.Text = "Введите специальность:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 51);
            this.label1.TabIndex = 11;
            this.label1.Text = "Введите факультет:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 13;
            // 
            // tsmAddSpecFaq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Colledge.Properties.Resources.HI3AS9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(260, 259);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsmUchenikAddCancel);
            this.Controls.Add(this.tsmUchenikAddSave);
            this.Controls.Add(this.tsmUchenikAddIDNP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "tsmAddSpecFaq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СпецФак";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tsmUchenikAddCancel;
        private System.Windows.Forms.Button tsmUchenikAddSave;
        private System.Windows.Forms.Label tsmUchenikAddIDNP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}