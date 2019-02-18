namespace Colledge
{
    partial class tsmAddPredmet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tsmAddPredmet));
            this.tsmUchenikAddIDNP = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tsmUchenikAddSave = new System.Windows.Forms.Button();
            this.tsmUchenikAddCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tsmUchenikAddIDNP
            // 
            this.tsmUchenikAddIDNP.BackColor = System.Drawing.Color.Transparent;
            this.tsmUchenikAddIDNP.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmUchenikAddIDNP.ForeColor = System.Drawing.Color.Black;
            this.tsmUchenikAddIDNP.Location = new System.Drawing.Point(12, 9);
            this.tsmUchenikAddIDNP.Name = "tsmUchenikAddIDNP";
            this.tsmUchenikAddIDNP.Size = new System.Drawing.Size(86, 51);
            this.tsmUchenikAddIDNP.TabIndex = 5;
            this.tsmUchenikAddIDNP.Text = "Введите предмет:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // tsmUchenikAddSave
            // 
            this.tsmUchenikAddSave.BackColor = System.Drawing.Color.Transparent;
            this.tsmUchenikAddSave.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmUchenikAddSave.Location = new System.Drawing.Point(16, 75);
            this.tsmUchenikAddSave.Name = "tsmUchenikAddSave";
            this.tsmUchenikAddSave.Size = new System.Drawing.Size(75, 27);
            this.tsmUchenikAddSave.TabIndex = 18;
            this.tsmUchenikAddSave.Text = "SAVE";
            this.tsmUchenikAddSave.UseVisualStyleBackColor = false;
            // 
            // tsmUchenikAddCancel
            // 
            this.tsmUchenikAddCancel.BackColor = System.Drawing.Color.Transparent;
            this.tsmUchenikAddCancel.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmUchenikAddCancel.Location = new System.Drawing.Point(140, 75);
            this.tsmUchenikAddCancel.Name = "tsmUchenikAddCancel";
            this.tsmUchenikAddCancel.Size = new System.Drawing.Size(75, 27);
            this.tsmUchenikAddCancel.TabIndex = 20;
            this.tsmUchenikAddCancel.Text = "CANCEL";
            this.tsmUchenikAddCancel.UseVisualStyleBackColor = false;
            // 
            // tsmAddPredmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Colledge.Properties.Resources.HI3AS9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(225, 217);
            this.Controls.Add(this.tsmUchenikAddCancel);
            this.Controls.Add(this.tsmUchenikAddSave);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tsmUchenikAddIDNP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tsmAddPredmet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление предмета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tsmUchenikAddIDNP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button tsmUchenikAddSave;
        private System.Windows.Forms.Button tsmUchenikAddCancel;
    }
}