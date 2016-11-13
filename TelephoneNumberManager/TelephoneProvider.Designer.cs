namespace TelephoneNumberManager
{
    partial class TelephoneProvider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelephoneProvider));
            System.Windows.Forms.Label siteIDLabel;
            System.Windows.Forms.Label telcoIDLabel;
            System.Windows.Forms.Label acctNumberLabel;
            System.Windows.Forms.Label telcoNameLabel;
            System.Windows.Forms.Label telcoMemoLabel;
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radEditNo = new System.Windows.Forms.RadioButton();
            this.radEditYes = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.telephoneNumbersDataSet = new TelephoneNumberManager.TelephoneNumbersDataSet();
            this.sitesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sitesTableAdapter = new TelephoneNumberManager.TelephoneNumbersDataSetTableAdapters.SitesTableAdapter();
            this.tableAdapterManager = new TelephoneNumberManager.TelephoneNumbersDataSetTableAdapters.TableAdapterManager();
            this.sitesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.sitesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.siteIDComboBox = new System.Windows.Forms.ComboBox();
            this.telephoneNumbersDataSet1 = new TelephoneNumberManager.TelephoneNumbersDataSet1();
            this.telcoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telcoTableAdapter = new TelephoneNumberManager.TelephoneNumbersDataSet1TableAdapters.TelcoTableAdapter();
            this.tableAdapterManager1 = new TelephoneNumberManager.TelephoneNumbersDataSet1TableAdapters.TableAdapterManager();
            this.telcoIDTextBox = new System.Windows.Forms.TextBox();
            this.acctNumberTextBox = new System.Windows.Forms.TextBox();
            this.telcoNameTextBox = new System.Windows.Forms.TextBox();
            this.custServTelephonNoTextBox = new System.Windows.Forms.TextBox();
            this.telcoMemoTextBox = new System.Windows.Forms.TextBox();
            this.chkisActive = new System.Windows.Forms.CheckBox();
            siteIDLabel = new System.Windows.Forms.Label();
            telcoIDLabel = new System.Windows.Forms.Label();
            acctNumberLabel = new System.Windows.Forms.Label();
            telcoNameLabel = new System.Windows.Forms.Label();
            telcoMemoLabel = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneNumbersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sitesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sitesBindingNavigator)).BeginInit();
            this.sitesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneNumbersDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telcoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repair Phone No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Service Start Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(388, 88);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(93, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(2016, 10, 30, 16, 24, 31, 0);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 386);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(558, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(12, 17);
            this.lblStatus.Text = "-";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(140, 177);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(56, 20);
            this.btnPrevious.TabIndex = 17;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(300, 177);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(56, 20);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radEditNo);
            this.groupBox1.Controls.Add(this.radEditYes);
            this.groupBox1.Location = new System.Drawing.Point(442, 133);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(62, 64);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // radEditNo
            // 
            this.radEditNo.AutoSize = true;
            this.radEditNo.Checked = true;
            this.radEditNo.Location = new System.Drawing.Point(5, 41);
            this.radEditNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radEditNo.Name = "radEditNo";
            this.radEditNo.Size = new System.Drawing.Size(39, 17);
            this.radEditNo.TabIndex = 1;
            this.radEditNo.TabStop = true;
            this.radEditNo.Text = "No";
            this.radEditNo.UseVisualStyleBackColor = true;
            // 
            // radEditYes
            // 
            this.radEditYes.AutoSize = true;
            this.radEditYes.Location = new System.Drawing.Point(5, 18);
            this.radEditYes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radEditYes.Name = "radEditYes";
            this.radEditYes.Size = new System.Drawing.Size(43, 17);
            this.radEditYes.TabIndex = 0;
            this.radEditYes.Text = "Yes";
            this.radEditYes.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(223, 335);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 25);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(300, 335);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 25);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(140, 335);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(70, 25);
            this.btnAddNew.TabIndex = 25;
            this.btnAddNew.Text = "ADD NEW";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(206, 180);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Record Selector";
            // 
            // telephoneNumbersDataSet
            // 
            this.telephoneNumbersDataSet.DataSetName = "TelephoneNumbersDataSet";
            this.telephoneNumbersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sitesBindingSource
            // 
            this.sitesBindingSource.DataMember = "Sites";
            this.sitesBindingSource.DataSource = this.telephoneNumbersDataSet;
            // 
            // sitesTableAdapter
            // 
            this.sitesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SitesTableAdapter = this.sitesTableAdapter;
            this.tableAdapterManager.UpdateOrder = TelephoneNumberManager.TelephoneNumbersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sitesBindingNavigator
            // 
            this.sitesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sitesBindingNavigator.BindingSource = this.sitesBindingSource;
            this.sitesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sitesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sitesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sitesBindingNavigatorSaveItem});
            this.sitesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sitesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sitesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sitesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sitesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sitesBindingNavigator.Name = "sitesBindingNavigator";
            this.sitesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sitesBindingNavigator.Size = new System.Drawing.Size(558, 25);
            this.sitesBindingNavigator.TabIndex = 27;
            this.sitesBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // sitesBindingNavigatorSaveItem
            // 
            this.sitesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sitesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sitesBindingNavigatorSaveItem.Image")));
            this.sitesBindingNavigatorSaveItem.Name = "sitesBindingNavigatorSaveItem";
            this.sitesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sitesBindingNavigatorSaveItem.Text = "Save Data";
            this.sitesBindingNavigatorSaveItem.Click += new System.EventHandler(this.sitesBindingNavigatorSaveItem_Click);
            // 
            // siteIDLabel
            // 
            siteIDLabel.AutoSize = true;
            siteIDLabel.Location = new System.Drawing.Point(340, 63);
            siteIDLabel.Name = "siteIDLabel";
            siteIDLabel.Size = new System.Drawing.Size(42, 13);
            siteIDLabel.TabIndex = 27;
            siteIDLabel.Text = "Site ID:";
            // 
            // siteIDComboBox
            // 
            this.siteIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sitesBindingSource, "SiteID", true));
            this.siteIDComboBox.FormattingEnabled = true;
            this.siteIDComboBox.Location = new System.Drawing.Point(388, 60);
            this.siteIDComboBox.Name = "siteIDComboBox";
            this.siteIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.siteIDComboBox.TabIndex = 28;
            // 
            // telephoneNumbersDataSet1
            // 
            this.telephoneNumbersDataSet1.DataSetName = "TelephoneNumbersDataSet1";
            this.telephoneNumbersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // telcoBindingSource
            // 
            this.telcoBindingSource.DataMember = "Telco";
            this.telcoBindingSource.DataSource = this.telephoneNumbersDataSet1;
            // 
            // telcoTableAdapter
            // 
            this.telcoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.TelcoTableAdapter = this.telcoTableAdapter;
            this.tableAdapterManager1.UpdateOrder = TelephoneNumberManager.TelephoneNumbersDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // telcoIDLabel
            // 
            telcoIDLabel.AutoSize = true;
            telcoIDLabel.Location = new System.Drawing.Point(20, 41);
            telcoIDLabel.Name = "telcoIDLabel";
            telcoIDLabel.Size = new System.Drawing.Size(51, 13);
            telcoIDLabel.TabIndex = 28;
            telcoIDLabel.Text = "Telco ID:";
            // 
            // telcoIDTextBox
            // 
            this.telcoIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telcoBindingSource, "TelcoID", true));
            this.telcoIDTextBox.Location = new System.Drawing.Point(114, 38);
            this.telcoIDTextBox.Name = "telcoIDTextBox";
            this.telcoIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.telcoIDTextBox.TabIndex = 29;
            // 
            // acctNumberLabel
            // 
            acctNumberLabel.AutoSize = true;
            acctNumberLabel.Location = new System.Drawing.Point(20, 66);
            acctNumberLabel.Name = "acctNumberLabel";
            acctNumberLabel.Size = new System.Drawing.Size(72, 13);
            acctNumberLabel.TabIndex = 29;
            acctNumberLabel.Text = "Acct Number:";
            // 
            // acctNumberTextBox
            // 
            this.acctNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telcoBindingSource, "AcctNumber", true));
            this.acctNumberTextBox.Location = new System.Drawing.Point(114, 63);
            this.acctNumberTextBox.Name = "acctNumberTextBox";
            this.acctNumberTextBox.Size = new System.Drawing.Size(156, 20);
            this.acctNumberTextBox.TabIndex = 30;
            // 
            // telcoNameLabel
            // 
            telcoNameLabel.AutoSize = true;
            telcoNameLabel.Location = new System.Drawing.Point(20, 92);
            telcoNameLabel.Name = "telcoNameLabel";
            telcoNameLabel.Size = new System.Drawing.Size(68, 13);
            telcoNameLabel.TabIndex = 30;
            telcoNameLabel.Text = "Telco Name:";
            // 
            // telcoNameTextBox
            // 
            this.telcoNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telcoBindingSource, "TelcoName", true));
            this.telcoNameTextBox.Location = new System.Drawing.Point(114, 89);
            this.telcoNameTextBox.Name = "telcoNameTextBox";
            this.telcoNameTextBox.Size = new System.Drawing.Size(156, 20);
            this.telcoNameTextBox.TabIndex = 31;
            // 
            // custServTelephonNoTextBox
            // 
            this.custServTelephonNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telcoBindingSource, "CustServTelephonNo", true));
            this.custServTelephonNoTextBox.Location = new System.Drawing.Point(114, 116);
            this.custServTelephonNoTextBox.Name = "custServTelephonNoTextBox";
            this.custServTelephonNoTextBox.Size = new System.Drawing.Size(123, 20);
            this.custServTelephonNoTextBox.TabIndex = 32;
            // 
            // telcoMemoLabel
            // 
            telcoMemoLabel.AutoSize = true;
            telcoMemoLabel.Location = new System.Drawing.Point(20, 194);
            telcoMemoLabel.Name = "telcoMemoLabel";
            telcoMemoLabel.Size = new System.Drawing.Size(69, 13);
            telcoMemoLabel.TabIndex = 32;
            telcoMemoLabel.Text = "Telco Memo:";
            // 
            // telcoMemoTextBox
            // 
            this.telcoMemoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telcoBindingSource, "TelcoMemo", true));
            this.telcoMemoTextBox.Location = new System.Drawing.Point(23, 217);
            this.telcoMemoTextBox.Multiline = true;
            this.telcoMemoTextBox.Name = "telcoMemoTextBox";
            this.telcoMemoTextBox.Size = new System.Drawing.Size(486, 102);
            this.telcoMemoTextBox.TabIndex = 33;
            // 
            // chkisActive
            // 
            this.chkisActive.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.telcoBindingSource, "IsActive", true));
            this.chkisActive.Location = new System.Drawing.Point(333, 133);
            this.chkisActive.Name = "chkisActive";
            this.chkisActive.Size = new System.Drawing.Size(104, 24);
            this.chkisActive.TabIndex = 34;
            this.chkisActive.Text = "Is Active";
            this.chkisActive.UseVisualStyleBackColor = true;
            // 
            // TelephoneProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 408);
            this.Controls.Add(this.chkisActive);
            this.Controls.Add(telcoMemoLabel);
            this.Controls.Add(this.telcoMemoTextBox);
            this.Controls.Add(this.custServTelephonNoTextBox);
            this.Controls.Add(telcoNameLabel);
            this.Controls.Add(this.telcoNameTextBox);
            this.Controls.Add(acctNumberLabel);
            this.Controls.Add(this.acctNumberTextBox);
            this.Controls.Add(telcoIDLabel);
            this.Controls.Add(this.telcoIDTextBox);
            this.Controls.Add(siteIDLabel);
            this.Controls.Add(this.siteIDComboBox);
            this.Controls.Add(this.sitesBindingNavigator);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelephoneProvider";
            this.Text = "Telephone Provider";
            this.Load += new System.EventHandler(this.TelephoneProvider_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneNumbersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sitesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sitesBindingNavigator)).EndInit();
            this.sitesBindingNavigator.ResumeLayout(false);
            this.sitesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneNumbersDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telcoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radEditNo;
        private System.Windows.Forms.RadioButton radEditYes;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label8;
        private TelephoneNumbersDataSet telephoneNumbersDataSet;
        private System.Windows.Forms.BindingSource sitesBindingSource;
        private TelephoneNumbersDataSetTableAdapters.SitesTableAdapter sitesTableAdapter;
        private TelephoneNumbersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sitesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sitesBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox siteIDComboBox;
        private TelephoneNumbersDataSet1 telephoneNumbersDataSet1;
        private System.Windows.Forms.BindingSource telcoBindingSource;
        private TelephoneNumbersDataSet1TableAdapters.TelcoTableAdapter telcoTableAdapter;
        private TelephoneNumbersDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox telcoIDTextBox;
        private System.Windows.Forms.TextBox acctNumberTextBox;
        private System.Windows.Forms.TextBox telcoNameTextBox;
        private System.Windows.Forms.TextBox custServTelephonNoTextBox;
        private System.Windows.Forms.TextBox telcoMemoTextBox;
        private System.Windows.Forms.CheckBox chkisActive;
    }
}