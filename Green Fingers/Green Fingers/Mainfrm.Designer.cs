namespace Green_Fingers
{
    partial class Mainfrm
    {

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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label plant_NameLabel;
            System.Windows.Forms.Label sow_IndoorsLabel;
            System.Windows.Forms.Label sow_Under_CoverLabel;
            System.Windows.Forms.Label sow_OutdoorsLabel;
            System.Windows.Forms.Label plant_OutLabel;
            System.Windows.Forms.Label harvest_TimeLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label plot_Number_NameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainfrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.tabOview = new System.Windows.Forms.TabControl();
            this.tabOviewPage = new System.Windows.Forms.TabPage();
            this.btnHideInSysTray = new System.Windows.Forms.Button();
            this.lblSelectedPlant = new System.Windows.Forms.Label();
            this.lblmaindataheading = new System.Windows.Forms.Label();
            this.btnClrXml = new System.Windows.Forms.Button();
            this.delReminder = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lstVxmlin = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnActivate = new System.Windows.Forms.Button();
            this.BtnSendToSQL = new System.Windows.Forms.Button();
            this.TxtBSQL = new System.Windows.Forms.TextBox();
            this.LstbLoadInSQL = new System.Windows.Forms.ListBox();
            this.greenFingersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.greenFingersDBDataSet = new Green_Fingers.GreenFingersDBDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDeactivate = new System.Windows.Forms.Button();
            this.lblInfodel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblDatabaseInfo2 = new System.Windows.Forms.Label();
            this.lblDatabaseInfo1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.greenFingersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.greenFingersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.greenFingersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.greenFingersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.plant_NameTextBox = new System.Windows.Forms.TextBox();
            this.sow_IndoorsTextBox = new System.Windows.Forms.TextBox();
            this.sow_Under_CoverTextBox = new System.Windows.Forms.TextBox();
            this.sow_OutdoorsTextBox = new System.Windows.Forms.TextBox();
            this.plant_OutTextBox = new System.Windows.Forms.TextBox();
            this.harvest_TimeTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.plot_Number_NameTextBox = new System.Windows.Forms.TextBox();
            this.frmWindowTitleText = new System.Windows.Forms.Label();
            this.greenFingersTableAdapter = new Green_Fingers.GreenFingersDBDataSetTableAdapters.GreenFingersTableAdapter();
            this.tableAdapterManager = new Green_Fingers.GreenFingersDBDataSetTableAdapters.TableAdapterManager();
            this.nfyIGf = new System.Windows.Forms.NotifyIcon(this.components);
            this.CtxmenNfyIGF = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tTipPlantsInDataBase = new System.Windows.Forms.ToolTip(this.components);
            this.tTipActivateReminders = new System.Windows.Forms.ToolTip(this.components);
            this.nfyIGfDPC = new System.Windows.Forms.NotifyIcon(this.components);
            this.FrmWindowBar = new System.Windows.Forms.Panel();
            this.IconFrmTitleBar = new System.Windows.Forms.PictureBox();
            this.FrmMinimizeBtnlbl = new System.Windows.Forms.Label();
            this.FrmExitBtnlbl = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            plant_NameLabel = new System.Windows.Forms.Label();
            sow_IndoorsLabel = new System.Windows.Forms.Label();
            sow_Under_CoverLabel = new System.Windows.Forms.Label();
            sow_OutdoorsLabel = new System.Windows.Forms.Label();
            plant_OutLabel = new System.Windows.Forms.Label();
            harvest_TimeLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            plot_Number_NameLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabOview.SuspendLayout();
            this.tabOviewPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenFingersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenFingersDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.greenFingersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenFingersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenFingersBindingNavigator)).BeginInit();
            this.greenFingersBindingNavigator.SuspendLayout();
            this.CtxmenNfyIGF.SuspendLayout();
            this.FrmWindowBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconFrmTitleBar)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(17, 40);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "ID:";
            // 
            // plant_NameLabel
            // 
            plant_NameLabel.AutoSize = true;
            plant_NameLabel.Location = new System.Drawing.Point(17, 66);
            plant_NameLabel.Name = "plant_NameLabel";
            plant_NameLabel.Size = new System.Drawing.Size(65, 13);
            plant_NameLabel.TabIndex = 2;
            plant_NameLabel.Text = "Plant Name:";
            // 
            // sow_IndoorsLabel
            // 
            sow_IndoorsLabel.AutoSize = true;
            sow_IndoorsLabel.Location = new System.Drawing.Point(17, 92);
            sow_IndoorsLabel.Name = "sow_IndoorsLabel";
            sow_IndoorsLabel.Size = new System.Drawing.Size(69, 13);
            sow_IndoorsLabel.TabIndex = 4;
            sow_IndoorsLabel.Text = "Sow Indoors:";
            // 
            // sow_Under_CoverLabel
            // 
            sow_Under_CoverLabel.AutoSize = true;
            sow_Under_CoverLabel.Location = new System.Drawing.Point(17, 118);
            sow_Under_CoverLabel.Name = "sow_Under_CoverLabel";
            sow_Under_CoverLabel.Size = new System.Drawing.Size(94, 13);
            sow_Under_CoverLabel.TabIndex = 6;
            sow_Under_CoverLabel.Text = "Sow Under Cover:";
            // 
            // sow_OutdoorsLabel
            // 
            sow_OutdoorsLabel.AutoSize = true;
            sow_OutdoorsLabel.Location = new System.Drawing.Point(17, 144);
            sow_OutdoorsLabel.Name = "sow_OutdoorsLabel";
            sow_OutdoorsLabel.Size = new System.Drawing.Size(77, 13);
            sow_OutdoorsLabel.TabIndex = 8;
            sow_OutdoorsLabel.Text = "Sow Outdoors:";
            // 
            // plant_OutLabel
            // 
            plant_OutLabel.AutoSize = true;
            plant_OutLabel.Location = new System.Drawing.Point(17, 170);
            plant_OutLabel.Name = "plant_OutLabel";
            plant_OutLabel.Size = new System.Drawing.Size(54, 13);
            plant_OutLabel.TabIndex = 10;
            plant_OutLabel.Text = "Plant Out:";
            // 
            // harvest_TimeLabel
            // 
            harvest_TimeLabel.AutoSize = true;
            harvest_TimeLabel.Location = new System.Drawing.Point(17, 196);
            harvest_TimeLabel.Name = "harvest_TimeLabel";
            harvest_TimeLabel.Size = new System.Drawing.Size(73, 13);
            harvest_TimeLabel.TabIndex = 12;
            harvest_TimeLabel.Text = "Harvest Time:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(17, 222);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(38, 13);
            notesLabel.TabIndex = 14;
            notesLabel.Text = "Notes:";
            // 
            // plot_Number_NameLabel
            // 
            plot_Number_NameLabel.AutoSize = true;
            plot_Number_NameLabel.Location = new System.Drawing.Point(17, 415);
            plot_Number_NameLabel.Name = "plot_Number_NameLabel";
            plot_Number_NameLabel.Size = new System.Drawing.Size(101, 13);
            plot_Number_NameLabel.TabIndex = 16;
            plot_Number_NameLabel.Text = "Plot Number/Name:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.AboutMnu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 26);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(846, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveMnu,
            this.exitToolStripMenuItem1,
            this.ExitMnu});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // SaveMnu
            // 
            this.SaveMnu.Image = global::Green_Fingers.Properties.Resources.save;
            this.SaveMnu.Name = "SaveMnu";
            this.SaveMnu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveMnu.Size = new System.Drawing.Size(167, 22);
            this.SaveMnu.Text = "Save";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(164, 6);
            // 
            // ExitMnu
            // 
            this.ExitMnu.Image = global::Green_Fingers.Properties.Resources.exit;
            this.ExitMnu.Name = "ExitMnu";
            this.ExitMnu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Q)));
            this.ExitMnu.Size = new System.Drawing.Size(167, 22);
            this.ExitMnu.Text = "Exit";
            this.ExitMnu.Click += new System.EventHandler(this.ExitMnu_Click);
            // 
            // AboutMnu
            // 
            this.AboutMnu.Image = global::Green_Fingers.Properties.Resources.about;
            this.AboutMnu.Name = "AboutMnu";
            this.AboutMnu.Size = new System.Drawing.Size(68, 24);
            this.AboutMnu.Text = "About";
            this.AboutMnu.Click += new System.EventHandler(this.AboutMnu_Click);
            // 
            // tabOview
            // 
            this.tabOview.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabOview.Controls.Add(this.tabOviewPage);
            this.tabOview.Controls.Add(this.tabPage2);
            this.tabOview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabOview.Location = new System.Drawing.Point(0, 55);
            this.tabOview.Name = "tabOview";
            this.tabOview.SelectedIndex = 0;
            this.tabOview.Size = new System.Drawing.Size(846, 473);
            this.tabOview.TabIndex = 2;
            // 
            // tabOviewPage
            // 
            this.tabOviewPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabOviewPage.Controls.Add(this.btnHideInSysTray);
            this.tabOviewPage.Controls.Add(this.lblSelectedPlant);
            this.tabOviewPage.Controls.Add(this.lblmaindataheading);
            this.tabOviewPage.Controls.Add(this.btnClrXml);
            this.tabOviewPage.Controls.Add(this.delReminder);
            this.tabOviewPage.Controls.Add(this.pictureBox2);
            this.tabOviewPage.Controls.Add(this.lstVxmlin);
            this.tabOviewPage.Controls.Add(this.btnActivate);
            this.tabOviewPage.Controls.Add(this.BtnSendToSQL);
            this.tabOviewPage.Controls.Add(this.TxtBSQL);
            this.tabOviewPage.Controls.Add(this.LstbLoadInSQL);
            this.tabOviewPage.Controls.Add(this.pictureBox1);
            this.tabOviewPage.Controls.Add(this.btnDeactivate);
            this.tabOviewPage.Controls.Add(this.lblInfodel);
            this.tabOviewPage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabOviewPage.Location = new System.Drawing.Point(4, 25);
            this.tabOviewPage.Name = "tabOviewPage";
            this.tabOviewPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabOviewPage.Size = new System.Drawing.Size(838, 444);
            this.tabOviewPage.TabIndex = 0;
            this.tabOviewPage.Text = "Overview";
            this.tabOviewPage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabOviewPage_MouseDown_1);
            // 
            // btnHideInSysTray
            // 
            this.btnHideInSysTray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHideInSysTray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHideInSysTray.Location = new System.Drawing.Point(685, 47);
            this.btnHideInSysTray.Name = "btnHideInSysTray";
            this.btnHideInSysTray.Size = new System.Drawing.Size(118, 50);
            this.btnHideInSysTray.TabIndex = 16;
            this.btnHideInSysTray.Text = "Hide in system tray";
            this.btnHideInSysTray.UseVisualStyleBackColor = false;
            this.btnHideInSysTray.Click += new System.EventHandler(this.btnHideInSysTray_Click);
            // 
            // lblSelectedPlant
            // 
            this.lblSelectedPlant.AutoSize = true;
            this.lblSelectedPlant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedPlant.Location = new System.Drawing.Point(325, 30);
            this.lblSelectedPlant.Name = "lblSelectedPlant";
            this.lblSelectedPlant.Size = new System.Drawing.Size(206, 13);
            this.lblSelectedPlant.TabIndex = 14;
            this.lblSelectedPlant.Text = "Selected Plant to add to Reminder.";
            // 
            // lblmaindataheading
            // 
            this.lblmaindataheading.AutoSize = true;
            this.lblmaindataheading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaindataheading.Location = new System.Drawing.Point(78, 4);
            this.lblmaindataheading.Name = "lblmaindataheading";
            this.lblmaindataheading.Size = new System.Drawing.Size(140, 13);
            this.lblmaindataheading.TabIndex = 13;
            this.lblmaindataheading.Text = "Plants in the Database.";
            // 
            // btnClrXml
            // 
            this.btnClrXml.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClrXml.Location = new System.Drawing.Point(750, 183);
            this.btnClrXml.Name = "btnClrXml";
            this.btnClrXml.Size = new System.Drawing.Size(80, 34);
            this.btnClrXml.TabIndex = 12;
            this.btnClrXml.Text = "Clear All Reminders";
            this.btnClrXml.UseVisualStyleBackColor = true;
            this.btnClrXml.Click += new System.EventHandler(this.btnClrXml_Click);
            // 
            // delReminder
            // 
            this.delReminder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delReminder.Location = new System.Drawing.Point(663, 183);
            this.delReminder.Name = "delReminder";
            this.delReminder.Size = new System.Drawing.Size(85, 34);
            this.delReminder.TabIndex = 11;
            this.delReminder.Text = "Delete a Reminder";
            this.delReminder.UseVisualStyleBackColor = true;
            this.delReminder.Click += new System.EventHandler(this.delReminder_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(405, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // lstVxmlin
            // 
            this.lstVxmlin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstVxmlin.Location = new System.Drawing.Point(6, 218);
            this.lstVxmlin.Name = "lstVxmlin";
            this.lstVxmlin.Size = new System.Drawing.Size(824, 220);
            this.lstVxmlin.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lstVxmlin.TabIndex = 9;
            this.lstVxmlin.TileSize = new System.Drawing.Size(300, 300);
            this.lstVxmlin.UseCompatibleStateImageBehavior = false;
            this.lstVxmlin.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Plant Name";
            this.columnHeader1.Width = 278;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Sow In Doors Date";
            this.columnHeader2.Width = 104;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sow Under Cover Date";
            this.columnHeader3.Width = 127;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sow Out Doors Date";
            this.columnHeader4.Width = 115;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Plant Out Doors";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Harvest Time Date";
            this.columnHeader6.Width = 106;
            // 
            // btnActivate
            // 
            this.btnActivate.BackColor = System.Drawing.Color.LawnGreen;
            this.btnActivate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivate.Location = new System.Drawing.Point(347, 136);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(156, 25);
            this.btnActivate.TabIndex = 7;
            this.btnActivate.Text = "<< Activate Reminders >>";
            this.btnActivate.UseVisualStyleBackColor = false;
            this.btnActivate.Visible = false;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            this.btnActivate.MouseHover += new System.EventHandler(this.btnActivate_MouseHover);
            // 
            // BtnSendToSQL
            // 
            this.BtnSendToSQL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSendToSQL.Location = new System.Drawing.Point(371, 73);
            this.BtnSendToSQL.Name = "BtnSendToSQL";
            this.BtnSendToSQL.Size = new System.Drawing.Size(101, 24);
            this.BtnSendToSQL.TabIndex = 6;
            this.BtnSendToSQL.Text = "Set Reminder";
            this.BtnSendToSQL.UseVisualStyleBackColor = true;
            this.BtnSendToSQL.Click += new System.EventHandler(this.BtnSendToSQL_Click);
            // 
            // TxtBSQL
            // 
            this.TxtBSQL.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtBSQL.Location = new System.Drawing.Point(332, 47);
            this.TxtBSQL.Name = "TxtBSQL";
            this.TxtBSQL.ReadOnly = true;
            this.TxtBSQL.Size = new System.Drawing.Size(193, 20);
            this.TxtBSQL.TabIndex = 2;
            // 
            // LstbLoadInSQL
            // 
            this.LstbLoadInSQL.DataSource = this.greenFingersBindingSource1;
            this.LstbLoadInSQL.DisplayMember = "Plant Name";
            this.LstbLoadInSQL.FormattingEnabled = true;
            this.LstbLoadInSQL.Location = new System.Drawing.Point(6, 19);
            this.LstbLoadInSQL.Name = "LstbLoadInSQL";
            this.LstbLoadInSQL.Size = new System.Drawing.Size(289, 186);
            this.LstbLoadInSQL.TabIndex = 1;
            this.LstbLoadInSQL.ValueMember = "Plant Name";
            this.LstbLoadInSQL.SelectedIndexChanged += new System.EventHandler(this.LstbLoadInSQL_SelectedIndexChanged);
            this.LstbLoadInSQL.MouseHover += new System.EventHandler(this.LstbLoadInSQL_MouseHover);
            // 
            // greenFingersBindingSource1
            // 
            this.greenFingersBindingSource1.DataMember = "GreenFingers";
            this.greenFingersBindingSource1.DataSource = this.greenFingersDBDataSet;
            // 
            // greenFingersDBDataSet
            // 
            this.greenFingersDBDataSet.DataSetName = "GreenFingersDBDataSet";
            this.greenFingersDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(301, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnDeactivate
            // 
            this.btnDeactivate.BackColor = System.Drawing.Color.Tomato;
            this.btnDeactivate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeactivate.Location = new System.Drawing.Point(355, 136);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Size = new System.Drawing.Size(135, 25);
            this.btnDeactivate.TabIndex = 8;
            this.btnDeactivate.Text = "Deactivate Reminders";
            this.btnDeactivate.UseVisualStyleBackColor = false;
            this.btnDeactivate.Visible = false;
            this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_Click);
            // 
            // lblInfodel
            // 
            this.lblInfodel.AutoSize = true;
            this.lblInfodel.Location = new System.Drawing.Point(3, 204);
            this.lblInfodel.Name = "lblInfodel";
            this.lblInfodel.Size = new System.Drawing.Size(661, 13);
            this.lblInfodel.TabIndex = 15;
            this.lblInfodel.Text = "To delete a Plant from the reminders list below, click on the plant name. Once th" +
    "e name is selected click on the \"Delete a reminder\" button.\r\n";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.lblDatabaseInfo2);
            this.tabPage2.Controls.Add(this.lblDatabaseInfo1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.greenFingersDataGridView);
            this.tabPage2.Controls.Add(this.greenFingersBindingNavigator);
            this.tabPage2.Controls.Add(iDLabel);
            this.tabPage2.Controls.Add(this.iDTextBox);
            this.tabPage2.Controls.Add(plant_NameLabel);
            this.tabPage2.Controls.Add(this.plant_NameTextBox);
            this.tabPage2.Controls.Add(sow_IndoorsLabel);
            this.tabPage2.Controls.Add(this.sow_IndoorsTextBox);
            this.tabPage2.Controls.Add(sow_Under_CoverLabel);
            this.tabPage2.Controls.Add(this.sow_Under_CoverTextBox);
            this.tabPage2.Controls.Add(sow_OutdoorsLabel);
            this.tabPage2.Controls.Add(this.sow_OutdoorsTextBox);
            this.tabPage2.Controls.Add(plant_OutLabel);
            this.tabPage2.Controls.Add(this.plant_OutTextBox);
            this.tabPage2.Controls.Add(harvest_TimeLabel);
            this.tabPage2.Controls.Add(this.harvest_TimeTextBox);
            this.tabPage2.Controls.Add(notesLabel);
            this.tabPage2.Controls.Add(this.notesTextBox);
            this.tabPage2.Controls.Add(plot_Number_NameLabel);
            this.tabPage2.Controls.Add(this.plot_Number_NameTextBox);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(838, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Database";
            this.tabPage2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabPage2_MouseDown);
            // 
            // lblDatabaseInfo2
            // 
            this.lblDatabaseInfo2.AutoSize = true;
            this.lblDatabaseInfo2.Location = new System.Drawing.Point(599, 2);
            this.lblDatabaseInfo2.Name = "lblDatabaseInfo2";
            this.lblDatabaseInfo2.Size = new System.Drawing.Size(150, 13);
            this.lblDatabaseInfo2.TabIndex = 22;
            this.lblDatabaseInfo2.Text = "Enter in the plant Data below. ";
            this.lblDatabaseInfo2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblDatabaseInfo2_MouseDown);
            // 
            // lblDatabaseInfo1
            // 
            this.lblDatabaseInfo1.AutoSize = true;
            this.lblDatabaseInfo1.Location = new System.Drawing.Point(524, 15);
            this.lblDatabaseInfo1.Name = "lblDatabaseInfo1";
            this.lblDatabaseInfo1.Size = new System.Drawing.Size(306, 13);
            this.lblDatabaseInfo1.TabIndex = 21;
            this.lblDatabaseInfo1.Text = "The date format must be as follows: DD/MM or DD/MM/YYYY.";
            this.lblDatabaseInfo1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblDatabaseInfo1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Green Fingers Plant Database";
            // 
            // greenFingersDataGridView
            // 
            this.greenFingersDataGridView.AutoGenerateColumns = false;
            this.greenFingersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.greenFingersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.greenFingersDataGridView.DataSource = this.greenFingersBindingSource;
            this.greenFingersDataGridView.Location = new System.Drawing.Point(230, 31);
            this.greenFingersDataGridView.Name = "greenFingersDataGridView";
            this.greenFingersDataGridView.Size = new System.Drawing.Size(600, 401);
            this.greenFingersDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Plant Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Plant Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Sow Indoors";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sow Indoors";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Sow Under Cover";
            this.dataGridViewTextBoxColumn4.HeaderText = "Sow Under Cover";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Sow Outdoors";
            this.dataGridViewTextBoxColumn5.HeaderText = "Sow Outdoors";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Plant Out";
            this.dataGridViewTextBoxColumn6.HeaderText = "Plant Out";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Harvest Time";
            this.dataGridViewTextBoxColumn7.HeaderText = "Harvest Time";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn8.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Plot Number/Name";
            this.dataGridViewTextBoxColumn9.HeaderText = "Plot Number/Name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // greenFingersBindingSource
            // 
            this.greenFingersBindingSource.DataMember = "GreenFingers";
            this.greenFingersBindingSource.DataSource = this.greenFingersDBDataSet;
            // 
            // greenFingersBindingNavigator
            // 
            this.greenFingersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.greenFingersBindingNavigator.BindingSource = this.greenFingersBindingSource;
            this.greenFingersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.greenFingersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.greenFingersBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.greenFingersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.greenFingersBindingNavigatorSaveItem});
            this.greenFingersBindingNavigator.Location = new System.Drawing.Point(230, 3);
            this.greenFingersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.greenFingersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.greenFingersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.greenFingersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.greenFingersBindingNavigator.Name = "greenFingersBindingNavigator";
            this.greenFingersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.greenFingersBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.greenFingersBindingNavigator.TabIndex = 3;
            this.greenFingersBindingNavigator.Text = "bindingNavigator1";
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
            // greenFingersBindingNavigatorSaveItem
            // 
            this.greenFingersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.greenFingersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("greenFingersBindingNavigatorSaveItem.Image")));
            this.greenFingersBindingNavigatorSaveItem.Name = "greenFingersBindingNavigatorSaveItem";
            this.greenFingersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.greenFingersBindingNavigatorSaveItem.Text = "Save Data";
            this.greenFingersBindingNavigatorSaveItem.Click += new System.EventHandler(this.greenFingersBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.greenFingersBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(124, 37);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 1;
            // 
            // plant_NameTextBox
            // 
            this.plant_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.greenFingersBindingSource, "Plant Name", true));
            this.plant_NameTextBox.Location = new System.Drawing.Point(124, 63);
            this.plant_NameTextBox.Name = "plant_NameTextBox";
            this.plant_NameTextBox.ReadOnly = true;
            this.plant_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.plant_NameTextBox.TabIndex = 3;
            // 
            // sow_IndoorsTextBox
            // 
            this.sow_IndoorsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.greenFingersBindingSource, "Sow Indoors", true));
            this.sow_IndoorsTextBox.Location = new System.Drawing.Point(124, 89);
            this.sow_IndoorsTextBox.Name = "sow_IndoorsTextBox";
            this.sow_IndoorsTextBox.ReadOnly = true;
            this.sow_IndoorsTextBox.Size = new System.Drawing.Size(100, 20);
            this.sow_IndoorsTextBox.TabIndex = 5;
            // 
            // sow_Under_CoverTextBox
            // 
            this.sow_Under_CoverTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.greenFingersBindingSource, "Sow Under Cover", true));
            this.sow_Under_CoverTextBox.Location = new System.Drawing.Point(124, 115);
            this.sow_Under_CoverTextBox.Name = "sow_Under_CoverTextBox";
            this.sow_Under_CoverTextBox.ReadOnly = true;
            this.sow_Under_CoverTextBox.Size = new System.Drawing.Size(100, 20);
            this.sow_Under_CoverTextBox.TabIndex = 7;
            // 
            // sow_OutdoorsTextBox
            // 
            this.sow_OutdoorsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.greenFingersBindingSource, "Sow Outdoors", true));
            this.sow_OutdoorsTextBox.Location = new System.Drawing.Point(124, 141);
            this.sow_OutdoorsTextBox.Name = "sow_OutdoorsTextBox";
            this.sow_OutdoorsTextBox.ReadOnly = true;
            this.sow_OutdoorsTextBox.Size = new System.Drawing.Size(100, 20);
            this.sow_OutdoorsTextBox.TabIndex = 9;
            // 
            // plant_OutTextBox
            // 
            this.plant_OutTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.greenFingersBindingSource, "Plant Out", true));
            this.plant_OutTextBox.Location = new System.Drawing.Point(124, 167);
            this.plant_OutTextBox.Name = "plant_OutTextBox";
            this.plant_OutTextBox.ReadOnly = true;
            this.plant_OutTextBox.Size = new System.Drawing.Size(100, 20);
            this.plant_OutTextBox.TabIndex = 11;
            // 
            // harvest_TimeTextBox
            // 
            this.harvest_TimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.greenFingersBindingSource, "Harvest Time", true));
            this.harvest_TimeTextBox.Location = new System.Drawing.Point(124, 193);
            this.harvest_TimeTextBox.Name = "harvest_TimeTextBox";
            this.harvest_TimeTextBox.ReadOnly = true;
            this.harvest_TimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.harvest_TimeTextBox.TabIndex = 13;
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.greenFingersBindingSource, "Notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(61, 219);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.ReadOnly = true;
            this.notesTextBox.Size = new System.Drawing.Size(163, 187);
            this.notesTextBox.TabIndex = 15;
            // 
            // plot_Number_NameTextBox
            // 
            this.plot_Number_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.greenFingersBindingSource, "Plot Number/Name", true));
            this.plot_Number_NameTextBox.Location = new System.Drawing.Point(124, 412);
            this.plot_Number_NameTextBox.Name = "plot_Number_NameTextBox";
            this.plot_Number_NameTextBox.ReadOnly = true;
            this.plot_Number_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.plot_Number_NameTextBox.TabIndex = 17;
            // 
            // frmWindowTitleText
            // 
            this.frmWindowTitleText.AutoSize = true;
            this.frmWindowTitleText.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmWindowTitleText.Location = new System.Drawing.Point(33, 10);
            this.frmWindowTitleText.Name = "frmWindowTitleText";
            this.frmWindowTitleText.Size = new System.Drawing.Size(123, 15);
            this.frmWindowTitleText.TabIndex = 17;
            this.frmWindowTitleText.Text = "Green Fingers V1.5";
            this.frmWindowTitleText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmWindowTitleText_MouseDown);
            // 
            // greenFingersTableAdapter
            // 
            this.greenFingersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GreenFingersTableAdapter = this.greenFingersTableAdapter;
            this.tableAdapterManager.UpdateOrder = Green_Fingers.GreenFingersDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nfyIGf
            // 
            this.nfyIGf.ContextMenuStrip = this.CtxmenNfyIGF;
            this.nfyIGf.Icon = ((System.Drawing.Icon)(resources.GetObject("nfyIGf.Icon")));
            this.nfyIGf.Text = "Green Fingers";
            this.nfyIGf.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nfyIGf_MouseDoubleClick);
            // 
            // CtxmenNfyIGF
            // 
            this.CtxmenNfyIGF.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.CtxmenNfyIGF.Name = "CtxmenNfyIGF";
            this.CtxmenNfyIGF.Size = new System.Drawing.Size(108, 70);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::Green_Fingers.Properties.Resources.leaf;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::Green_Fingers.Properties.Resources.about;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Green_Fingers.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tTipPlantsInDataBase
            // 
            this.tTipPlantsInDataBase.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tTipPlantsInDataBase.ToolTipTitle = "Green Fingers Tip.";
            // 
            // tTipActivateReminders
            // 
            this.tTipActivateReminders.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tTipActivateReminders.ToolTipTitle = "Green Fingers Tip.";
            // 
            // nfyIGfDPC
            // 
            this.nfyIGfDPC.Icon = ((System.Drawing.Icon)(resources.GetObject("nfyIGfDPC.Icon")));
            this.nfyIGfDPC.Text = "Green Fingers Alert";
            // 
            // FrmWindowBar
            // 
            this.FrmWindowBar.BackColor = System.Drawing.Color.PaleGreen;
            this.FrmWindowBar.Controls.Add(this.frmWindowTitleText);
            this.FrmWindowBar.Controls.Add(this.IconFrmTitleBar);
            this.FrmWindowBar.Controls.Add(this.FrmMinimizeBtnlbl);
            this.FrmWindowBar.Controls.Add(this.FrmExitBtnlbl);
            this.FrmWindowBar.Location = new System.Drawing.Point(0, -3);
            this.FrmWindowBar.Name = "FrmWindowBar";
            this.FrmWindowBar.Size = new System.Drawing.Size(846, 30);
            this.FrmWindowBar.TabIndex = 3;
            this.FrmWindowBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmWindowBar_MouseDown);
            // 
            // IconFrmTitleBar
            // 
            this.IconFrmTitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IconFrmTitleBar.Image = global::Green_Fingers.Properties.Resources.leaf;
            this.IconFrmTitleBar.Location = new System.Drawing.Point(-4, 2);
            this.IconFrmTitleBar.Name = "IconFrmTitleBar";
            this.IconFrmTitleBar.Size = new System.Drawing.Size(31, 32);
            this.IconFrmTitleBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconFrmTitleBar.TabIndex = 17;
            this.IconFrmTitleBar.TabStop = false;
            this.IconFrmTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IconFrmTitleBar_MouseDown);
            // 
            // FrmMinimizeBtnlbl
            // 
            this.FrmMinimizeBtnlbl.AutoSize = true;
            this.FrmMinimizeBtnlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrmMinimizeBtnlbl.Location = new System.Drawing.Point(785, 3);
            this.FrmMinimizeBtnlbl.Name = "FrmMinimizeBtnlbl";
            this.FrmMinimizeBtnlbl.Size = new System.Drawing.Size(27, 20);
            this.FrmMinimizeBtnlbl.TabIndex = 17;
            this.FrmMinimizeBtnlbl.Text = "__";
            this.FrmMinimizeBtnlbl.Click += new System.EventHandler(this.FrmMinimizeBtnlbl_Click);
            this.FrmMinimizeBtnlbl.MouseLeave += new System.EventHandler(this.FrmMinimizeBtnlbl_MouseLeave);
            this.FrmMinimizeBtnlbl.MouseHover += new System.EventHandler(this.FrmMinimizeBtnlbl_MouseHover);
            // 
            // FrmExitBtnlbl
            // 
            this.FrmExitBtnlbl.AutoSize = true;
            this.FrmExitBtnlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrmExitBtnlbl.Location = new System.Drawing.Point(819, 7);
            this.FrmExitBtnlbl.Name = "FrmExitBtnlbl";
            this.FrmExitBtnlbl.Size = new System.Drawing.Size(18, 18);
            this.FrmExitBtnlbl.TabIndex = 17;
            this.FrmExitBtnlbl.Text = "X";
            this.FrmExitBtnlbl.Click += new System.EventHandler(this.FrmExitBtnlbl_Click);
            this.FrmExitBtnlbl.MouseLeave += new System.EventHandler(this.FrmExitBtnlbl_MouseLeave);
            this.FrmExitBtnlbl.MouseHover += new System.EventHandler(this.FrmExitBtnlbl_MouseHover);
            // 
            // Mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(845, 529);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.FrmWindowBar);
            this.Controls.Add(this.tabOview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Mainfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Green Fingers V1.0";
            this.Load += new System.EventHandler(this.Mainfrm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mainfrm_MouseDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabOview.ResumeLayout(false);
            this.tabOviewPage.ResumeLayout(false);
            this.tabOviewPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenFingersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenFingersDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.greenFingersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenFingersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenFingersBindingNavigator)).EndInit();
            this.greenFingersBindingNavigator.ResumeLayout(false);
            this.greenFingersBindingNavigator.PerformLayout();
            this.CtxmenNfyIGF.ResumeLayout(false);
            this.FrmWindowBar.ResumeLayout(false);
            this.FrmWindowBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconFrmTitleBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AboutMnu;
        private System.Windows.Forms.TabControl tabOview;
        private System.Windows.Forms.TabPage tabPage2;
        private GreenFingersDBDataSet greenFingersDBDataSet;
        private System.Windows.Forms.BindingSource greenFingersBindingSource;
        private GreenFingersDBDataSetTableAdapters.GreenFingersTableAdapter greenFingersTableAdapter;
        private GreenFingersDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator greenFingersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton greenFingersBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView greenFingersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox plant_NameTextBox;
        private System.Windows.Forms.TextBox sow_IndoorsTextBox;
        private System.Windows.Forms.TextBox sow_Under_CoverTextBox;
        private System.Windows.Forms.TextBox sow_OutdoorsTextBox;
        private System.Windows.Forms.TextBox plant_OutTextBox;
        private System.Windows.Forms.TextBox harvest_TimeTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.TextBox plot_Number_NameTextBox;
        private System.Windows.Forms.BindingSource greenFingersBindingSource1;
        private System.Windows.Forms.TabPage tabOviewPage;
        private System.Windows.Forms.Button btnClrXml;
        private System.Windows.Forms.Button delReminder;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnSendToSQL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox TxtBSQL;
        public System.Windows.Forms.NotifyIcon nfyIGf;
        private System.Windows.Forms.Label lblmaindataheading;
        private System.Windows.Forms.Label lblSelectedPlant;
        private System.Windows.Forms.Label lblInfodel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip tTipPlantsInDataBase;
        private System.Windows.Forms.ToolTip tTipActivateReminders;
        private System.Windows.Forms.Label lblDatabaseInfo2;
        private System.Windows.Forms.Label lblDatabaseInfo1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitMnu;
        private System.Windows.Forms.ToolStripMenuItem SaveMnu;
        private System.Windows.Forms.Button btnHideInSysTray;
        private System.ComponentModel.IContainer components;
        public System.Windows.Forms.NotifyIcon nfyIGfDPC;
        private System.Windows.Forms.ContextMenuStrip CtxmenNfyIGF;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.Button btnActivate;
        public System.Windows.Forms.Button btnDeactivate;
        public System.Windows.Forms.ListBox LstbLoadInSQL;
        public System.Windows.Forms.ListView lstVxmlin;
        private System.Windows.Forms.Panel FrmWindowBar;
        private System.Windows.Forms.Label FrmExitBtnlbl;
        private System.Windows.Forms.Label FrmMinimizeBtnlbl;
        private System.Windows.Forms.PictureBox IconFrmTitleBar;
        private System.Windows.Forms.Label frmWindowTitleText;
    }
}

