namespace Colledge
{
    partial class tsmAddUchitel
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tsmUchenikAddIDNP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tsmUchenikAddCancel
            // 
            this.tsmUchenikAddCancel.BackColor = System.Drawing.Color.Transparent;
            this.tsmUchenikAddCancel.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmUchenikAddCancel.Location = new System.Drawing.Point(158, 171);
            this.tsmUchenikAddCancel.Name = "tsmUchenikAddCancel";
            this.tsmUchenikAddCancel.Size = new System.Drawing.Size(75, 27);
            this.tsmUchenikAddCancel.TabIndex = 24;
            this.tsmUchenikAddCancel.Text = "CANCEL";
            this.tsmUchenikAddCancel.UseVisualStyleBackColor = false;
            // 
            // tsmUchenikAddSave
            // 
            this.tsmUchenikAddSave.BackColor = System.Drawing.Color.Transparent;
            this.tsmUchenikAddSave.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmUchenikAddSave.Location = new System.Drawing.Point(9, 171);
            this.tsmUchenikAddSave.Name = "tsmUchenikAddSave";
            this.tsmUchenikAddSave.Size = new System.Drawing.Size(75, 27);
            this.tsmUchenikAddSave.TabIndex = 23;
            this.tsmUchenikAddSave.Text = "SAVE";
            this.tsmUchenikAddSave.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 22;
            // 
            // tsmUchenikAddIDNP
            // 
            this.tsmUchenikAddIDNP.BackColor = System.Drawing.Color.Transparent;
            this.tsmUchenikAddIDNP.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsmUchenikAddIDNP.ForeColor = System.Drawing.Color.Black;
            this.tsmUchenikAddIDNP.Location = new System.Drawing.Point(12, 9);
            this.tsmUchenikAddIDNP.Name = "tsmUchenikAddIDNP";
            this.tsmUchenikAddIDNP.Size = new System.Drawing.Size(115, 51);
            this.tsmUchenikAddIDNP.TabIndex = 21;
            this.tsmUchenikAddIDNP.Text = "Введите ФИО учителя:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 51);
            this.label1.TabIndex = 25;
            this.label1.Text = "Введите факультет:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 26;
            // 
            // tsmAddUchitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Colledge.Properties.Resources.HI3AS9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(250, 244);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsmUchenikAddCancel);
            this.Controls.Add(this.tsmUchenikAddSave);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tsmUchenikAddIDNP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "tsmAddUchitel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tsmUchenikAddCancel;
        private System.Windows.Forms.Button tsmUchenikAddSave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label tsmUchenikAddIDNP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
    }
}