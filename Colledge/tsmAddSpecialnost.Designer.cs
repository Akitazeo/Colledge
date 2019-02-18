namespace Colledge
{
    partial class tsmAddSpecialnost
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tsmUchenikAddCancel
            // 
            this.tsmUchenikAddCancel.BackColor = System.Drawing.Color.Transparent;
            this.tsmUchenikAddCancel.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmUchenikAddCancel.Location = new System.Drawing.Point(178, 85);
            this.tsmUchenikAddCancel.Name = "tsmUchenikAddCancel";
            this.tsmUchenikAddCancel.Size = new System.Drawing.Size(75, 27);
            this.tsmUchenikAddCancel.TabIndex = 23;
            this.tsmUchenikAddCancel.Text = "CANCEL";
            this.tsmUchenikAddCancel.UseVisualStyleBackColor = false;
            // 
            // tsmUchenikAddSave
            // 
            this.tsmUchenikAddSave.BackColor = System.Drawing.Color.Transparent;
            this.tsmUchenikAddSave.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmUchenikAddSave.Location = new System.Drawing.Point(16, 85);
            this.tsmUchenikAddSave.Name = "tsmUchenikAddSave";
            this.tsmUchenikAddSave.Size = new System.Drawing.Size(75, 27);
            this.tsmUchenikAddSave.TabIndex = 22;
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
            this.tsmUchenikAddIDNP.Size = new System.Drawing.Size(122, 51);
            this.tsmUchenikAddIDNP.TabIndex = 21;
            this.tsmUchenikAddIDNP.Text = "Введите специальность:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 24;
            // 
            // tsmAddSpecialnost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Colledge.Properties.Resources.HI3AS9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(279, 266);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tsmUchenikAddCancel);
            this.Controls.Add(this.tsmUchenikAddSave);
            this.Controls.Add(this.tsmUchenikAddIDNP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "tsmAddSpecialnost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление специальности";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tsmUchenikAddCancel;
        private System.Windows.Forms.Button tsmUchenikAddSave;
        private System.Windows.Forms.Label tsmUchenikAddIDNP;
        private System.Windows.Forms.TextBox textBox1;
    }
}