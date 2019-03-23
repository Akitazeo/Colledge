namespace Colledge
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsmEdit = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmUchenik = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmJurnal = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUchitel = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSpetialnost = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPredmet = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.спецФакToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ученикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учительToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ГруппаУчениковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmПредмет = new System.Windows.Forms.ToolStripMenuItem();
            this.спецФакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTool = new System.Windows.Forms.ToolStripDropDownButton();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.student = new Colledge.Student();
            this.grUcenicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grUcenicTableAdapter = new Colledge.StudentTableAdapters.GrUcenicTableAdapter();
            this.tableAdapterManager = new Colledge.StudentTableAdapters.TableAdapterManager();
            this.jurnalTableAdapter = new Colledge.StudentTableAdapters.JurnalTableAdapter();
            this.predmetTableAdapter = new Colledge.StudentTableAdapters.PredmetTableAdapter();
            this.specFacTableAdapter = new Colledge.StudentTableAdapters.SpecFacTableAdapter();
            this.uchenikTableAdapter = new Colledge.StudentTableAdapters.UchenikTableAdapter();
            this.uchitelTableAdapter = new Colledge.StudentTableAdapters.UchitelTableAdapter();
            this.jurnalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.predmetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specFacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchitelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.средняяОценкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияПоУченикуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grUcenicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jurnalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specFacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchitelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkSalmon;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEdit,
            this.toolStripDropDownButton1,
            this.tsmTool,
            this.toolStripDropDownButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsmEdit
            // 
            this.tsmEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUchenik,
            this.tsmJurnal,
            this.tsmUchitel,
            this.tsmSpetialnost,
            this.tsmPredmet,
            this.спецФакToolStripMenuItem1});
            this.tsmEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsmEdit.Image")));
            this.tsmEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(40, 22);
            this.tsmEdit.Text = "Edit";
            // 
            // tsmUchenik
            // 
            this.tsmUchenik.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem});
            this.tsmUchenik.Name = "tsmUchenik";
            this.tsmUchenik.Size = new System.Drawing.Size(168, 22);
            this.tsmUchenik.Text = "Ученик";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // tsmJurnal
            // 
            this.tsmJurnal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1});
            this.tsmJurnal.Name = "tsmJurnal";
            this.tsmJurnal.Size = new System.Drawing.Size(168, 22);
            this.tsmJurnal.Text = "Журнал";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(96, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // tsmUchitel
            // 
            this.tsmUchitel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem2,
            this.editToolStripMenuItem2,
            this.deleteToolStripMenuItem2});
            this.tsmUchitel.Name = "tsmUchitel";
            this.tsmUchitel.Size = new System.Drawing.Size(168, 22);
            this.tsmUchitel.Text = "Учитель";
            // 
            // addToolStripMenuItem2
            // 
            this.addToolStripMenuItem2.Name = "addToolStripMenuItem2";
            this.addToolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem2.Text = "Add";
            this.addToolStripMenuItem2.Click += new System.EventHandler(this.addToolStripMenuItem2_Click);
            // 
            // editToolStripMenuItem2
            // 
            this.editToolStripMenuItem2.Name = "editToolStripMenuItem2";
            this.editToolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem2.Text = "Edit";
            this.editToolStripMenuItem2.Click += new System.EventHandler(this.editToolStripMenuItem2_Click);
            // 
            // deleteToolStripMenuItem2
            // 
            this.deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            this.deleteToolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem2.Text = "Delete";
            this.deleteToolStripMenuItem2.Click += new System.EventHandler(this.deleteToolStripMenuItem2_Click);
            // 
            // tsmSpetialnost
            // 
            this.tsmSpetialnost.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem3,
            this.deleteToolStripMenuItem3});
            this.tsmSpetialnost.Name = "tsmSpetialnost";
            this.tsmSpetialnost.Size = new System.Drawing.Size(168, 22);
            this.tsmSpetialnost.Text = "Группа учеников";
            // 
            // addToolStripMenuItem3
            // 
            this.addToolStripMenuItem3.Name = "addToolStripMenuItem3";
            this.addToolStripMenuItem3.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem3.Text = "Add";
            this.addToolStripMenuItem3.Click += new System.EventHandler(this.addToolStripMenuItem3_Click);
            // 
            // deleteToolStripMenuItem3
            // 
            this.deleteToolStripMenuItem3.Name = "deleteToolStripMenuItem3";
            this.deleteToolStripMenuItem3.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem3.Text = "Delete";
            this.deleteToolStripMenuItem3.Click += new System.EventHandler(this.deleteToolStripMenuItem3_Click);
            // 
            // tsmPredmet
            // 
            this.tsmPredmet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem5,
            this.deleteToolStripMenuItem5});
            this.tsmPredmet.Name = "tsmPredmet";
            this.tsmPredmet.Size = new System.Drawing.Size(168, 22);
            this.tsmPredmet.Text = "Предмет";
            // 
            // addToolStripMenuItem5
            // 
            this.addToolStripMenuItem5.Name = "addToolStripMenuItem5";
            this.addToolStripMenuItem5.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem5.Text = "Add";
            this.addToolStripMenuItem5.Click += new System.EventHandler(this.addToolStripMenuItem5_Click);
            // 
            // deleteToolStripMenuItem5
            // 
            this.deleteToolStripMenuItem5.Name = "deleteToolStripMenuItem5";
            this.deleteToolStripMenuItem5.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem5.Text = "Delete";
            this.deleteToolStripMenuItem5.Click += new System.EventHandler(this.deleteToolStripMenuItem5_Click);
            // 
            // спецФакToolStripMenuItem1
            // 
            this.спецФакToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem4,
            this.deleteToolStripMenuItem4});
            this.спецФакToolStripMenuItem1.Name = "спецФакToolStripMenuItem1";
            this.спецФакToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.спецФакToolStripMenuItem1.Text = "Спец.Фак.";
            // 
            // addToolStripMenuItem4
            // 
            this.addToolStripMenuItem4.Name = "addToolStripMenuItem4";
            this.addToolStripMenuItem4.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem4.Text = "Add";
            this.addToolStripMenuItem4.Click += new System.EventHandler(this.addToolStripMenuItem4_Click_1);
            // 
            // deleteToolStripMenuItem4
            // 
            this.deleteToolStripMenuItem4.Name = "deleteToolStripMenuItem4";
            this.deleteToolStripMenuItem4.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem4.Text = "Delete";
            this.deleteToolStripMenuItem4.Click += new System.EventHandler(this.deleteToolStripMenuItem4_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ученикToolStripMenuItem,
            this.журналToolStripMenuItem,
            this.учительToolStripMenuItem,
            this.ГруппаУчениковToolStripMenuItem,
            this.tsmПредмет,
            this.спецФакToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(45, 22);
            this.toolStripDropDownButton1.Text = "View";
            // 
            // ученикToolStripMenuItem
            // 
            this.ученикToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.средняяОценкаToolStripMenuItem,
            this.информацияПоУченикуToolStripMenuItem});
            this.ученикToolStripMenuItem.Name = "ученикToolStripMenuItem";
            this.ученикToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ученикToolStripMenuItem.Text = "Ученик";
            this.ученикToolStripMenuItem.Click += new System.EventHandler(this.ученикToolStripMenuItem_Click);
            // 
            // журналToolStripMenuItem
            // 
            this.журналToolStripMenuItem.Name = "журналToolStripMenuItem";
            this.журналToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.журналToolStripMenuItem.Text = "Журнал";
            // 
            // учительToolStripMenuItem
            // 
            this.учительToolStripMenuItem.Name = "учительToolStripMenuItem";
            this.учительToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.учительToolStripMenuItem.Text = "Учитель";
            // 
            // ГруппаУчениковToolStripMenuItem
            // 
            this.ГруппаУчениковToolStripMenuItem.Name = "ГруппаУчениковToolStripMenuItem";
            this.ГруппаУчениковToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ГруппаУчениковToolStripMenuItem.Text = "Группа учеников";
            // 
            // tsmПредмет
            // 
            this.tsmПредмет.Name = "tsmПредмет";
            this.tsmПредмет.Size = new System.Drawing.Size(180, 22);
            this.tsmПредмет.Text = "Предмет";
            // 
            // спецФакToolStripMenuItem
            // 
            this.спецФакToolStripMenuItem.Name = "спецФакToolStripMenuItem";
            this.спецФакToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.спецФакToolStripMenuItem.Text = "Спец.Фак.";
            // 
            // tsmTool
            // 
            this.tsmTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsmTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem,
            this.tsmRestore});
            this.tsmTool.Image = ((System.Drawing.Image)(resources.GetObject("tsmTool.Image")));
            this.tsmTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmTool.Name = "tsmTool";
            this.tsmTool.Size = new System.Drawing.Size(48, 22);
            this.tsmTool.Text = "Tools";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.backupToolStripMenuItem.Text = "Backup";
            // 
            // tsmRestore
            // 
            this.tsmRestore.Name = "tsmRestore";
            this.tsmRestore.Size = new System.Drawing.Size(113, 22);
            this.tsmRestore.Text = "Restore";
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(45, 22);
            this.toolStripDropDownButton3.Text = "Help";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutUsToolStripMenuItem.Text = "About us";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // student
            // 
            this.student.DataSetName = "Student";
            this.student.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grUcenicBindingSource
            // 
            this.grUcenicBindingSource.DataMember = "GrUcenic";
            this.grUcenicBindingSource.DataSource = this.student;
            // 
            // grUcenicTableAdapter
            // 
            this.grUcenicTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GrUcenicTableAdapter = this.grUcenicTableAdapter;
            this.tableAdapterManager.JurnalTableAdapter = this.jurnalTableAdapter;
            this.tableAdapterManager.PredmetTableAdapter = this.predmetTableAdapter;
            this.tableAdapterManager.SpecFacTableAdapter = this.specFacTableAdapter;
            this.tableAdapterManager.UchenikTableAdapter = this.uchenikTableAdapter;
            this.tableAdapterManager.UchitelTableAdapter = this.uchitelTableAdapter;
            this.tableAdapterManager.UpdateOrder = Colledge.StudentTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // jurnalTableAdapter
            // 
            this.jurnalTableAdapter.ClearBeforeFill = true;
            // 
            // predmetTableAdapter
            // 
            this.predmetTableAdapter.ClearBeforeFill = true;
            // 
            // specFacTableAdapter
            // 
            this.specFacTableAdapter.ClearBeforeFill = true;
            // 
            // uchenikTableAdapter
            // 
            this.uchenikTableAdapter.ClearBeforeFill = true;
            // 
            // uchitelTableAdapter
            // 
            this.uchitelTableAdapter.ClearBeforeFill = true;
            // 
            // jurnalBindingSource
            // 
            this.jurnalBindingSource.DataMember = "Jurnal";
            this.jurnalBindingSource.DataSource = this.student;
            // 
            // predmetBindingSource
            // 
            this.predmetBindingSource.DataMember = "Predmet";
            this.predmetBindingSource.DataSource = this.student;
            // 
            // specFacBindingSource
            // 
            this.specFacBindingSource.DataMember = "SpecFac";
            this.specFacBindingSource.DataSource = this.student;
            // 
            // uchenikBindingSource
            // 
            this.uchenikBindingSource.DataMember = "Uchenik";
            this.uchenikBindingSource.DataSource = this.student;
            // 
            // uchitelBindingSource
            // 
            this.uchitelBindingSource.DataMember = "Uchitel";
            this.uchitelBindingSource.DataSource = this.student;
            // 
            // средняяОценкаToolStripMenuItem
            // 
            this.средняяОценкаToolStripMenuItem.Name = "средняяОценкаToolStripMenuItem";
            this.средняяОценкаToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.средняяОценкаToolStripMenuItem.Text = "Средняя оценка";
            this.средняяОценкаToolStripMenuItem.Click += new System.EventHandler(this.средняяОценкаToolStripMenuItem_Click);
            // 
            // информацияПоУченикуToolStripMenuItem
            // 
            this.информацияПоУченикуToolStripMenuItem.Name = "информацияПоУченикуToolStripMenuItem";
            this.информацияПоУченикуToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.информацияПоУченикуToolStripMenuItem.Text = "Информация по ученику";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Colledge.Properties.Resources.mnbjhjhj;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1264, 689);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grUcenicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jurnalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specFacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchitelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsmEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmUchenik;
        private System.Windows.Forms.ToolStripMenuItem tsmJurnal;
        private System.Windows.Forms.ToolStripMenuItem tsmUchitel;
        private System.Windows.Forms.ToolStripMenuItem tsmSpetialnost;
        private System.Windows.Forms.ToolStripMenuItem tsmPredmet;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem5;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton tsmTool;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmRestore;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ученикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem журналToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учительToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ГруппаУчениковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmПредмет;
        private System.Windows.Forms.ToolStripMenuItem спецФакToolStripMenuItem;
        private Student student;
        private System.Windows.Forms.BindingSource grUcenicBindingSource;
        private StudentTableAdapters.GrUcenicTableAdapter grUcenicTableAdapter;
        private StudentTableAdapters.TableAdapterManager tableAdapterManager;
        private StudentTableAdapters.JurnalTableAdapter jurnalTableAdapter;
        private System.Windows.Forms.BindingSource jurnalBindingSource;
        private StudentTableAdapters.PredmetTableAdapter predmetTableAdapter;
        private System.Windows.Forms.BindingSource predmetBindingSource;
        private StudentTableAdapters.SpecFacTableAdapter specFacTableAdapter;
        private System.Windows.Forms.BindingSource specFacBindingSource;
        private StudentTableAdapters.UchenikTableAdapter uchenikTableAdapter;
        private System.Windows.Forms.BindingSource uchenikBindingSource;
        private StudentTableAdapters.UchitelTableAdapter uchitelTableAdapter;
        private System.Windows.Forms.BindingSource uchitelBindingSource;
        private System.Windows.Forms.ToolStripMenuItem спецФакToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem средняяОценкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияПоУченикуToolStripMenuItem;
    }
}