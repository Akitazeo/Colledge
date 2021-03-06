﻿namespace Colledge
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mainBtnBackUp = new System.Windows.Forms.Button();
            this.mainBtnSwitch = new System.Windows.Forms.Button();
            this.mainBtnExit = new System.Windows.Forms.Button();
            this.mainBtnRestore = new System.Windows.Forms.Button();
            this.mainBtnDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.mainBtnView = new System.Windows.Forms.Button();
            this.mainAdd = new System.Windows.Forms.Button();
            this.mainBtnEdit = new System.Windows.Forms.Button();
            this.mainBtnUchenik = new System.Windows.Forms.Button();
            this.mainBtnGroup = new System.Windows.Forms.Button();
            this.mainBtnUchitel = new System.Windows.Forms.Button();
            this.mainBtnJournal = new System.Windows.Forms.Button();
            this.mainBtnPredmet = new System.Windows.Forms.Button();
            this.mainBtnSpecFac = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grUcenicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jurnalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specFacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchitelBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.66667F));
            this.tableLayoutPanel1.Controls.Add(this.mainBtnBackUp, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.mainBtnSwitch, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.mainBtnExit, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.mainBtnRestore, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.mainBtnView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mainAdd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mainBtnDelete, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mainBtnEdit, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(220, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1044, 115);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // mainBtnBackUp
            // 
            this.mainBtnBackUp.BackColor = System.Drawing.Color.White;
            this.mainBtnBackUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBtnBackUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainBtnBackUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainBtnBackUp.Enabled = false;
            this.mainBtnBackUp.FlatAppearance.BorderSize = 0;
            this.mainBtnBackUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainBtnBackUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.mainBtnBackUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainBtnBackUp.Location = new System.Drawing.Point(779, 3);
            this.mainBtnBackUp.Name = "mainBtnBackUp";
            this.mainBtnBackUp.Size = new System.Drawing.Size(126, 51);
            this.mainBtnBackUp.TabIndex = 49;
            this.mainBtnBackUp.Text = "Back-up";
            this.mainBtnBackUp.UseVisualStyleBackColor = false;
            this.mainBtnBackUp.Visible = false;
            // 
            // mainBtnSwitch
            // 
            this.mainBtnSwitch.BackColor = System.Drawing.Color.White;
            this.mainBtnSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBtnSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainBtnSwitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainBtnSwitch.FlatAppearance.BorderSize = 0;
            this.mainBtnSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainBtnSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainBtnSwitch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainBtnSwitch.Location = new System.Drawing.Point(911, 60);
            this.mainBtnSwitch.Name = "mainBtnSwitch";
            this.mainBtnSwitch.Size = new System.Drawing.Size(130, 52);
            this.mainBtnSwitch.TabIndex = 48;
            this.mainBtnSwitch.Text = "Сменить пользователя";
            this.mainBtnSwitch.UseVisualStyleBackColor = false;
            this.mainBtnSwitch.Click += new System.EventHandler(this.mainBtnSwitch_Click);
            // 
            // mainBtnExit
            // 
            this.mainBtnExit.BackColor = System.Drawing.Color.White;
            this.mainBtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainBtnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainBtnExit.FlatAppearance.BorderSize = 0;
            this.mainBtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainBtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.mainBtnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainBtnExit.Location = new System.Drawing.Point(911, 3);
            this.mainBtnExit.Name = "mainBtnExit";
            this.mainBtnExit.Size = new System.Drawing.Size(130, 51);
            this.mainBtnExit.TabIndex = 47;
            this.mainBtnExit.Text = "Выход";
            this.mainBtnExit.UseVisualStyleBackColor = false;
            this.mainBtnExit.Click += new System.EventHandler(this.mainBtnExit_Click);
            // 
            // mainBtnRestore
            // 
            this.mainBtnRestore.BackColor = System.Drawing.Color.White;
            this.mainBtnRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBtnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainBtnRestore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainBtnRestore.FlatAppearance.BorderSize = 0;
            this.mainBtnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainBtnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.mainBtnRestore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainBtnRestore.Location = new System.Drawing.Point(779, 60);
            this.mainBtnRestore.Name = "mainBtnRestore";
            this.mainBtnRestore.Size = new System.Drawing.Size(126, 52);
            this.mainBtnRestore.TabIndex = 46;
            this.mainBtnRestore.Text = "Restore";
            this.mainBtnRestore.UseVisualStyleBackColor = false;
            // 
            // mainBtnDelete
            // 
            this.mainBtnDelete.BackColor = System.Drawing.Color.White;
            this.mainBtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainBtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainBtnDelete.Enabled = false;
            this.mainBtnDelete.FlatAppearance.BorderSize = 0;
            this.mainBtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainBtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.mainBtnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainBtnDelete.Location = new System.Drawing.Point(585, 3);
            this.mainBtnDelete.Name = "mainBtnDelete";
            this.tableLayoutPanel1.SetRowSpan(this.mainBtnDelete, 2);
            this.mainBtnDelete.Size = new System.Drawing.Size(188, 109);
            this.mainBtnDelete.TabIndex = 43;
            this.mainBtnDelete.Text = "Удалить";
            this.mainBtnDelete.UseVisualStyleBackColor = false;
            this.mainBtnDelete.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.mainBtnUchenik, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.mainBtnGroup, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.mainBtnUchitel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.mainBtnJournal, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.mainBtnPredmet, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.mainBtnSpecFac, 0, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(220, 689);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(222, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1042, 584);
            this.label1.TabIndex = 3;
            this.label1.Text = "Добро пожаловать, для продолжения работы выберите одну из таблиц.";
            // 
            // mainBtnView
            // 
            this.mainBtnView.BackColor = System.Drawing.Color.White;
            this.mainBtnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBtnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainBtnView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainBtnView.FlatAppearance.BorderSize = 0;
            this.mainBtnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainBtnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.mainBtnView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainBtnView.Location = new System.Drawing.Point(197, 3);
            this.mainBtnView.Name = "mainBtnView";
            this.tableLayoutPanel1.SetRowSpan(this.mainBtnView, 2);
            this.mainBtnView.Size = new System.Drawing.Size(188, 109);
            this.mainBtnView.TabIndex = 45;
            this.mainBtnView.Text = "Просмотр";
            this.mainBtnView.UseVisualStyleBackColor = false;
            this.mainBtnView.Visible = false;
            // 
            // mainAdd
            // 
            this.mainAdd.BackColor = System.Drawing.Color.White;
            this.mainAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainAdd.Enabled = false;
            this.mainAdd.FlatAppearance.BorderSize = 0;
            this.mainAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.mainAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainAdd.Location = new System.Drawing.Point(3, 3);
            this.mainAdd.Name = "mainAdd";
            this.tableLayoutPanel1.SetRowSpan(this.mainAdd, 2);
            this.mainAdd.Size = new System.Drawing.Size(188, 109);
            this.mainAdd.TabIndex = 44;
            this.mainAdd.Text = "Добавить";
            this.mainAdd.UseVisualStyleBackColor = false;
            this.mainAdd.Visible = false;
            // 
            // mainBtnEdit
            // 
            this.mainBtnEdit.BackColor = System.Drawing.Color.White;
            this.mainBtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainBtnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainBtnEdit.Enabled = false;
            this.mainBtnEdit.FlatAppearance.BorderSize = 0;
            this.mainBtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainBtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.mainBtnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainBtnEdit.Location = new System.Drawing.Point(391, 3);
            this.mainBtnEdit.Name = "mainBtnEdit";
            this.tableLayoutPanel1.SetRowSpan(this.mainBtnEdit, 2);
            this.mainBtnEdit.Size = new System.Drawing.Size(188, 109);
            this.mainBtnEdit.TabIndex = 42;
            this.mainBtnEdit.Text = "Изменить";
            this.mainBtnEdit.UseVisualStyleBackColor = false;
            this.mainBtnEdit.Visible = false;
            // 
            // mainBtnUchenik
            // 
            this.mainBtnUchenik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainBtnUchenik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(116)))), ((int)(((byte)(34)))));
            this.mainBtnUchenik.BackgroundImage = global::Colledge.Properties.Resources.mainBtnUchBrightness;
            this.mainBtnUchenik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBtnUchenik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainBtnUchenik.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mainBtnUchenik.FlatAppearance.BorderSize = 0;
            this.mainBtnUchenik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainBtnUchenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainBtnUchenik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainBtnUchenik.Location = new System.Drawing.Point(4, 3);
            this.mainBtnUchenik.Name = "mainBtnUchenik";
            this.mainBtnUchenik.Size = new System.Drawing.Size(211, 108);
            this.mainBtnUchenik.TabIndex = 41;
            this.mainBtnUchenik.Text = "Ученик";
            this.mainBtnUchenik.UseVisualStyleBackColor = false;
            this.mainBtnUchenik.Click += new System.EventHandler(this.mainBtnUchenik_Click);
            this.mainBtnUchenik.MouseEnter += new System.EventHandler(this.mainBtnUchenik_MouseEnter);
            this.mainBtnUchenik.MouseLeave += new System.EventHandler(this.mainBtnUchenik_MouseLeave);
            // 
            // mainBtnGroup
            // 
            this.mainBtnGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainBtnGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(116)))), ((int)(((byte)(34)))));
            this.mainBtnGroup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainBtnGroup.BackgroundImage")));
            this.mainBtnGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBtnGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainBtnGroup.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mainBtnGroup.FlatAppearance.BorderSize = 0;
            this.mainBtnGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainBtnGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainBtnGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainBtnGroup.Location = new System.Drawing.Point(3, 573);
            this.mainBtnGroup.Name = "mainBtnGroup";
            this.mainBtnGroup.Size = new System.Drawing.Size(213, 113);
            this.mainBtnGroup.TabIndex = 45;
            this.mainBtnGroup.Text = "Группа";
            this.mainBtnGroup.UseVisualStyleBackColor = false;
            // 
            // mainBtnUchitel
            // 
            this.mainBtnUchitel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainBtnUchitel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(116)))), ((int)(((byte)(34)))));
            this.mainBtnUchitel.BackgroundImage = global::Colledge.Properties.Resources.MainBtnUchitelBrightness;
            this.mainBtnUchitel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBtnUchitel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainBtnUchitel.FlatAppearance.BorderSize = 0;
            this.mainBtnUchitel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainBtnUchitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainBtnUchitel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainBtnUchitel.Location = new System.Drawing.Point(3, 117);
            this.mainBtnUchitel.Name = "mainBtnUchitel";
            this.mainBtnUchitel.Size = new System.Drawing.Size(213, 108);
            this.mainBtnUchitel.TabIndex = 42;
            this.mainBtnUchitel.Text = "Учитель";
            this.mainBtnUchitel.UseVisualStyleBackColor = false;
            this.mainBtnUchitel.Click += new System.EventHandler(this.mainBtnUchitel_Click);
            this.mainBtnUchitel.MouseEnter += new System.EventHandler(this.mainBtnUchitel_MouseEnter);
            this.mainBtnUchitel.MouseLeave += new System.EventHandler(this.mainBtnUchitel_MouseLeave);
            // 
            // mainBtnJournal
            // 
            this.mainBtnJournal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainBtnJournal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(116)))), ((int)(((byte)(34)))));
            this.mainBtnJournal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainBtnJournal.BackgroundImage")));
            this.mainBtnJournal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBtnJournal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainBtnJournal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mainBtnJournal.FlatAppearance.BorderSize = 0;
            this.mainBtnJournal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainBtnJournal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainBtnJournal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainBtnJournal.Location = new System.Drawing.Point(3, 459);
            this.mainBtnJournal.Name = "mainBtnJournal";
            this.mainBtnJournal.Size = new System.Drawing.Size(213, 108);
            this.mainBtnJournal.TabIndex = 46;
            this.mainBtnJournal.Text = "Журнал";
            this.mainBtnJournal.UseVisualStyleBackColor = false;
            // 
            // mainBtnPredmet
            // 
            this.mainBtnPredmet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainBtnPredmet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(116)))), ((int)(((byte)(34)))));
            this.mainBtnPredmet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainBtnPredmet.BackgroundImage")));
            this.mainBtnPredmet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBtnPredmet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainBtnPredmet.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mainBtnPredmet.FlatAppearance.BorderSize = 0;
            this.mainBtnPredmet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainBtnPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainBtnPredmet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainBtnPredmet.Location = new System.Drawing.Point(3, 231);
            this.mainBtnPredmet.Name = "mainBtnPredmet";
            this.mainBtnPredmet.Size = new System.Drawing.Size(213, 108);
            this.mainBtnPredmet.TabIndex = 46;
            this.mainBtnPredmet.Text = "Предмет";
            this.mainBtnPredmet.UseVisualStyleBackColor = false;
            // 
            // mainBtnSpecFac
            // 
            this.mainBtnSpecFac.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainBtnSpecFac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(116)))), ((int)(((byte)(34)))));
            this.mainBtnSpecFac.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainBtnSpecFac.BackgroundImage")));
            this.mainBtnSpecFac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainBtnSpecFac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainBtnSpecFac.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mainBtnSpecFac.FlatAppearance.BorderSize = 0;
            this.mainBtnSpecFac.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainBtnSpecFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainBtnSpecFac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mainBtnSpecFac.Location = new System.Drawing.Point(3, 345);
            this.mainBtnSpecFac.Name = "mainBtnSpecFac";
            this.mainBtnSpecFac.Size = new System.Drawing.Size(213, 108);
            this.mainBtnSpecFac.TabIndex = 44;
            this.mainBtnSpecFac.Text = "Спец. Фак";
            this.mainBtnSpecFac.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1264, 689);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grUcenicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jurnalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specFacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchitelBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button mainBtnGroup;
        private System.Windows.Forms.Button mainBtnSpecFac;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button mainBtnEdit;
        private System.Windows.Forms.Button mainBtnUchenik;
        private System.Windows.Forms.Button mainBtnUchitel;
        private System.Windows.Forms.Button mainBtnPredmet;
        private System.Windows.Forms.Button mainBtnJournal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button mainBtnBackUp;
        private System.Windows.Forms.Button mainBtnSwitch;
        private System.Windows.Forms.Button mainBtnExit;
        private System.Windows.Forms.Button mainBtnRestore;
        private System.Windows.Forms.Button mainBtnView;
        private System.Windows.Forms.Button mainAdd;
        private System.Windows.Forms.Button mainBtnDelete;
        private System.Windows.Forms.Label label1;
    }
}