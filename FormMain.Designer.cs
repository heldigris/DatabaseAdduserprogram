namespace DatabaseTest1
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.Fornavne = new System.Windows.Forms.Label();
            this.FornavnBox = new System.Windows.Forms.TextBox();
            this.btnLead = new System.Windows.Forms.Button();
            this.EtternavnBox = new System.Windows.Forms.TextBox();
            this.Etternavn = new System.Windows.Forms.Label();
            this.EpostBox = new System.Windows.Forms.TextBox();
            this.Epost = new System.Windows.Forms.Label();
            this.TelefonBox = new System.Windows.Forms.TextBox();
            this.Telefon = new System.Windows.Forms.Label();
            this.GateAdresseBox = new System.Windows.Forms.TextBox();
            this.GateAdresse = new System.Windows.Forms.Label();
            this.PostnrBox = new System.Windows.Forms.TextBox();
            this.Postnr = new System.Windows.Forms.Label();
            this.PostStedBox = new System.Windows.Forms.TextBox();
            this.PostSted = new System.Windows.Forms.Label();
            this.Dato = new System.Windows.Forms.Label();
            this.Kilde = new System.Windows.Forms.Label();
            this.KildeBox = new System.Windows.Forms.ComboBox();
            this.databaseTest1DataSet = new DatabaseTest1.DatabaseTest1DataSet();
            this.leadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leadTableAdapter = new DatabaseTest1.DatabaseTest1DataSetTableAdapters.LeadTableAdapter();
            this.tableAdapterManager = new DatabaseTest1.DatabaseTest1DataSetTableAdapters.TableAdapterManager();
            this.leadBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.leadBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.DatoBox = new System.Windows.Forms.DateTimePicker();
            this.ListResultat = new System.Windows.Forms.ListBox();
            this.Resultat = new System.Windows.Forms.Label();
            this.leadDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.databaseTest1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadBindingNavigator)).BeginInit();
            this.leadBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leadDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Fornavne
            // 
            this.Fornavne.AutoSize = true;
            this.Fornavne.Location = new System.Drawing.Point(35, 13);
            this.Fornavne.Name = "Fornavne";
            this.Fornavne.Size = new System.Drawing.Size(46, 13);
            this.Fornavne.TabIndex = 0;
            this.Fornavne.Text = "Fornavn";
            // 
            // FornavnBox
            // 
            this.FornavnBox.Location = new System.Drawing.Point(38, 30);
            this.FornavnBox.Name = "FornavnBox";
            this.FornavnBox.Size = new System.Drawing.Size(100, 20);
            this.FornavnBox.TabIndex = 1;
            // 
            // btnLead
            // 
            this.btnLead.Location = new System.Drawing.Point(161, 207);
            this.btnLead.Name = "btnLead";
            this.btnLead.Size = new System.Drawing.Size(221, 82);
            this.btnLead.TabIndex = 2;
            this.btnLead.Text = "Legg til Lead";
            this.btnLead.UseVisualStyleBackColor = true;
            this.btnLead.Click += new System.EventHandler(this.btnLead_Click);
            // 
            // EtternavnBox
            // 
            this.EtternavnBox.Location = new System.Drawing.Point(161, 30);
            this.EtternavnBox.Name = "EtternavnBox";
            this.EtternavnBox.Size = new System.Drawing.Size(100, 20);
            this.EtternavnBox.TabIndex = 4;
            // 
            // Etternavn
            // 
            this.Etternavn.AutoSize = true;
            this.Etternavn.Location = new System.Drawing.Point(158, 13);
            this.Etternavn.Name = "Etternavn";
            this.Etternavn.Size = new System.Drawing.Size(53, 13);
            this.Etternavn.TabIndex = 3;
            this.Etternavn.Text = "Etternavn";
            // 
            // EpostBox
            // 
            this.EpostBox.Location = new System.Drawing.Point(282, 30);
            this.EpostBox.Name = "EpostBox";
            this.EpostBox.Size = new System.Drawing.Size(100, 20);
            this.EpostBox.TabIndex = 6;
            // 
            // Epost
            // 
            this.Epost.AutoSize = true;
            this.Epost.Location = new System.Drawing.Point(279, 13);
            this.Epost.Name = "Epost";
            this.Epost.Size = new System.Drawing.Size(37, 13);
            this.Epost.TabIndex = 5;
            this.Epost.Text = "E-post";
            // 
            // TelefonBox
            // 
            this.TelefonBox.Location = new System.Drawing.Point(395, 30);
            this.TelefonBox.Name = "TelefonBox";
            this.TelefonBox.Size = new System.Drawing.Size(121, 20);
            this.TelefonBox.TabIndex = 8;
            // 
            // Telefon
            // 
            this.Telefon.AutoSize = true;
            this.Telefon.Location = new System.Drawing.Point(392, 13);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(43, 13);
            this.Telefon.TabIndex = 7;
            this.Telefon.Text = "Telefon";
            // 
            // GateAdresseBox
            // 
            this.GateAdresseBox.Location = new System.Drawing.Point(38, 96);
            this.GateAdresseBox.Name = "GateAdresseBox";
            this.GateAdresseBox.Size = new System.Drawing.Size(100, 20);
            this.GateAdresseBox.TabIndex = 10;
            // 
            // GateAdresse
            // 
            this.GateAdresse.AutoSize = true;
            this.GateAdresse.Location = new System.Drawing.Point(35, 79);
            this.GateAdresse.Name = "GateAdresse";
            this.GateAdresse.Size = new System.Drawing.Size(71, 13);
            this.GateAdresse.TabIndex = 9;
            this.GateAdresse.Text = "Gate Adresse";
            // 
            // PostnrBox
            // 
            this.PostnrBox.Location = new System.Drawing.Point(161, 96);
            this.PostnrBox.Name = "PostnrBox";
            this.PostnrBox.Size = new System.Drawing.Size(100, 20);
            this.PostnrBox.TabIndex = 12;
            // 
            // Postnr
            // 
            this.Postnr.AutoSize = true;
            this.Postnr.Location = new System.Drawing.Point(158, 79);
            this.Postnr.Name = "Postnr";
            this.Postnr.Size = new System.Drawing.Size(40, 13);
            this.Postnr.TabIndex = 11;
            this.Postnr.Text = "Postnr.";
            // 
            // PostStedBox
            // 
            this.PostStedBox.Location = new System.Drawing.Point(282, 96);
            this.PostStedBox.Name = "PostStedBox";
            this.PostStedBox.Size = new System.Drawing.Size(100, 20);
            this.PostStedBox.TabIndex = 14;
            // 
            // PostSted
            // 
            this.PostSted.AutoSize = true;
            this.PostSted.Location = new System.Drawing.Point(279, 79);
            this.PostSted.Name = "PostSted";
            this.PostSted.Size = new System.Drawing.Size(19, 13);
            this.PostSted.TabIndex = 13;
            this.PostSted.Text = "By";
            // 
            // Dato
            // 
            this.Dato.AutoSize = true;
            this.Dato.Location = new System.Drawing.Point(255, 146);
            this.Dato.Name = "Dato";
            this.Dato.Size = new System.Drawing.Size(30, 13);
            this.Dato.TabIndex = 15;
            this.Dato.Text = "Dato";
            // 
            // Kilde
            // 
            this.Kilde.AutoSize = true;
            this.Kilde.Location = new System.Drawing.Point(392, 79);
            this.Kilde.Name = "Kilde";
            this.Kilde.Size = new System.Drawing.Size(30, 13);
            this.Kilde.TabIndex = 17;
            this.Kilde.Text = "Kilde";
            // 
            // KildeBox
            // 
            this.KildeBox.FormattingEnabled = true;
            this.KildeBox.Location = new System.Drawing.Point(395, 96);
            this.KildeBox.Name = "KildeBox";
            this.KildeBox.Size = new System.Drawing.Size(121, 21);
            this.KildeBox.TabIndex = 20;
            // 
            // databaseTest1DataSet
            // 
            this.databaseTest1DataSet.DataSetName = "DatabaseTest1DataSet";
            this.databaseTest1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leadBindingSource
            // 
            this.leadBindingSource.DataMember = "Lead";
            this.leadBindingSource.DataSource = this.databaseTest1DataSet;
            // 
            // leadTableAdapter
            // 
            this.leadTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LeadTableAdapter = this.leadTableAdapter;
            this.tableAdapterManager.UpdateOrder = DatabaseTest1.DatabaseTest1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // leadBindingNavigator
            // 
            this.leadBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.leadBindingNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leadBindingNavigator.BindingSource = this.leadBindingSource;
            this.leadBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.leadBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.leadBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.leadBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.leadBindingNavigatorSaveItem});
            this.leadBindingNavigator.Location = new System.Drawing.Point(38, 327);
            this.leadBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.leadBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.leadBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.leadBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.leadBindingNavigator.Name = "leadBindingNavigator";
            this.leadBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.leadBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.leadBindingNavigator.TabIndex = 21;
            this.leadBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // leadBindingNavigatorSaveItem
            // 
            this.leadBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.leadBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("leadBindingNavigatorSaveItem.Image")));
            this.leadBindingNavigatorSaveItem.Name = "leadBindingNavigatorSaveItem";
            this.leadBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.leadBindingNavigatorSaveItem.Text = "Save Data";
            this.leadBindingNavigatorSaveItem.Click += new System.EventHandler(this.leadBindingNavigatorSaveItem_Click);
            // 
            // DatoBox
            // 
            this.DatoBox.Location = new System.Drawing.Point(161, 162);
            this.DatoBox.Name = "DatoBox";
            this.DatoBox.Size = new System.Drawing.Size(221, 20);
            this.DatoBox.TabIndex = 22;
            // 
            // ListResultat
            // 
            this.ListResultat.FormattingEnabled = true;
            this.ListResultat.Location = new System.Drawing.Point(408, 246);
            this.ListResultat.Name = "ListResultat";
            this.ListResultat.Size = new System.Drawing.Size(177, 95);
            this.ListResultat.TabIndex = 24;
            // 
            // Resultat
            // 
            this.Resultat.AutoSize = true;
            this.Resultat.Location = new System.Drawing.Point(405, 216);
            this.Resultat.Name = "Resultat";
            this.Resultat.Size = new System.Drawing.Size(46, 13);
            this.Resultat.TabIndex = 25;
            this.Resultat.Text = "Resultat";
            // 
            // leadDataGridView
            // 
            this.leadDataGridView.AutoGenerateColumns = false;
            this.leadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leadDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.leadDataGridView.DataSource = this.leadBindingSource;
            this.leadDataGridView.Location = new System.Drawing.Point(38, 355);
            this.leadDataGridView.Name = "leadDataGridView";
            this.leadDataGridView.Size = new System.Drawing.Size(547, 220);
            this.leadDataGridView.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Fornavn";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fornavn";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Etternavn";
            this.dataGridViewTextBoxColumn3.HeaderText = "Etternavn";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "E-post";
            this.dataGridViewTextBoxColumn4.HeaderText = "E-post";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefon";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Adresse";
            this.dataGridViewTextBoxColumn6.HeaderText = "Adresse";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Postnr";
            this.dataGridViewTextBoxColumn7.HeaderText = "Postnr";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PostSted";
            this.dataGridViewTextBoxColumn8.HeaderText = "PostSted";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Dato";
            this.dataGridViewTextBoxColumn9.HeaderText = "Dato";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "LeadType";
            this.dataGridViewTextBoxColumn10.HeaderText = "LeadType";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 618);
            this.Controls.Add(this.leadDataGridView);
            this.Controls.Add(this.Resultat);
            this.Controls.Add(this.ListResultat);
            this.Controls.Add(this.DatoBox);
            this.Controls.Add(this.leadBindingNavigator);
            this.Controls.Add(this.KildeBox);
            this.Controls.Add(this.Kilde);
            this.Controls.Add(this.Dato);
            this.Controls.Add(this.PostStedBox);
            this.Controls.Add(this.PostSted);
            this.Controls.Add(this.PostnrBox);
            this.Controls.Add(this.Postnr);
            this.Controls.Add(this.GateAdresseBox);
            this.Controls.Add(this.GateAdresse);
            this.Controls.Add(this.TelefonBox);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.EpostBox);
            this.Controls.Add(this.Epost);
            this.Controls.Add(this.EtternavnBox);
            this.Controls.Add(this.Etternavn);
            this.Controls.Add(this.btnLead);
            this.Controls.Add(this.FornavnBox);
            this.Controls.Add(this.Fornavne);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "Kunde behandling";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseTest1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadBindingNavigator)).EndInit();
            this.leadBindingNavigator.ResumeLayout(false);
            this.leadBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leadDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Fornavne;
        private System.Windows.Forms.TextBox FornavnBox;
        private System.Windows.Forms.Button btnLead;
        private System.Windows.Forms.TextBox EtternavnBox;
        private System.Windows.Forms.Label Etternavn;
        private System.Windows.Forms.TextBox EpostBox;
        private System.Windows.Forms.Label Epost;
        private System.Windows.Forms.TextBox TelefonBox;
        private System.Windows.Forms.Label Telefon;
        private System.Windows.Forms.TextBox GateAdresseBox;
        private System.Windows.Forms.Label GateAdresse;
        private System.Windows.Forms.TextBox PostnrBox;
        private System.Windows.Forms.Label Postnr;
        private System.Windows.Forms.TextBox PostStedBox;
        private System.Windows.Forms.Label PostSted;
        private System.Windows.Forms.Label Dato;
        private System.Windows.Forms.Label Kilde;
        private System.Windows.Forms.ComboBox KildeBox;
        private DatabaseTest1DataSet databaseTest1DataSet;
        private System.Windows.Forms.BindingSource leadBindingSource;
        private DatabaseTest1DataSetTableAdapters.LeadTableAdapter leadTableAdapter;
        private DatabaseTest1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator leadBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton leadBindingNavigatorSaveItem;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.DateTimePicker DatoBox;
        private System.Windows.Forms.ListBox ListResultat;
        private System.Windows.Forms.Label Resultat;
        private System.Windows.Forms.DataGridView leadDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}

