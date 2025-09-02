namespace OpcodeGuide
{
    partial class Guide
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guide));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] { "Signed Byte", "0" }, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] { "Unsigned Byte", "0" }, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] { "Signed Int16", "0" }, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] { "Unsigned Int16", "0" }, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] { "Signed Int32", "0" }, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] { "Unsigned Int32", "0" }, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] { "String SJIS", "" }, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] { "String UTF8", "" }, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] { "String Unicode", "" }, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] { "String Custom", "" }, -1);
            mainMenu = new System.Windows.Forms.MenuStrip();
            file = new System.Windows.Forms.ToolStripMenuItem();
            menuNew = new System.Windows.Forms.ToolStripMenuItem();
            menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            menuOpenScript = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            menuSave = new System.Windows.Forms.ToolStripMenuItem();
            menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            menuClose = new System.Windows.Forms.ToolStripMenuItem();
            menuExit = new System.Windows.Forms.ToolStripMenuItem();
            help = new System.Windows.Forms.ToolStripMenuItem();
            menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            openFile = new System.Windows.Forms.OpenFileDialog();
            saveFile = new System.Windows.Forms.SaveFileDialog();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            statusToolVersion = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            statusScriptVersion = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            statusItemSelect = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            statusBytesSelect = new System.Windows.Forms.ToolStripStatusLabel();
            groupBox1 = new System.Windows.Forms.GroupBox();
            panel_script_ctl = new System.Windows.Forms.Panel();
            btnScriptJump = new System.Windows.Forms.Button();
            btnRestore = new System.Windows.Forms.Button();
            textJumpPosition = new System.Windows.Forms.TextBox();
            textJumpIndex = new System.Windows.Forms.TextBox();
            btnLoadNext = new System.Windows.Forms.Button();
            btnLoadPrev = new System.Windows.Forms.Button();
            radioJumpPosition = new System.Windows.Forms.RadioButton();
            radioJumpIndex = new System.Windows.Forms.RadioButton();
            labelScriptCodeNum = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            labelScriptCodeLen = new System.Windows.Forms.Label();
            labelScriptCodeID = new System.Windows.Forms.Label();
            labelScriptPos = new System.Windows.Forms.Label();
            btnLoadScript = new System.Windows.Forms.Button();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            labelScriptSize = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            textFilename = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            scriptList = new System.Windows.Forms.ListBox();
            opcodeList = new System.Windows.Forms.ListBox();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            splitContainer2 = new System.Windows.Forms.SplitContainer();
            panel_paramList_btn = new System.Windows.Forms.Panel();
            panel_paramList = new System.Windows.Forms.Panel();
            paramsList = new System.Windows.Forms.ListView();
            panel_paramList_right = new System.Windows.Forms.Panel();
            panel_typeList_btn = new System.Windows.Forms.Panel();
            btnInsertUp = new System.Windows.Forms.Button();
            checkNullable = new System.Windows.Forms.CheckBox();
            checkExport = new System.Windows.Forms.CheckBox();
            btnInsertDown = new System.Windows.Forms.Button();
            btnPreview = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnApply = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            splitContainer3 = new System.Windows.Forms.SplitContainer();
            panel_typeList_label = new System.Windows.Forms.Panel();
            panel_typeList = new System.Windows.Forms.Panel();
            typeList = new System.Windows.Forms.ListBox();
            label3 = new System.Windows.Forms.Label();
            panel_previewList_label = new System.Windows.Forms.Panel();
            panel_previewList = new System.Windows.Forms.Panel();
            previewList = new System.Windows.Forms.ListView();
            type = new System.Windows.Forms.ColumnHeader();
            value = new System.Windows.Forms.ColumnHeader();
            label4 = new System.Windows.Forms.Label();
            panel_opcode_textbox_label = new System.Windows.Forms.Panel();
            panel_opcode_textbox = new System.Windows.Forms.Panel();
            panel_opcode_textbox_param = new System.Windows.Forms.Panel();
            textParams = new System.Windows.Forms.TextBox();
            panel_opcode_textbox_name = new System.Windows.Forms.Panel();
            textOpcode = new System.Windows.Forms.TextBox();
            btnTextToList = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            bytesView = new System.Windows.Forms.DataGridView();
            textView = new System.Windows.Forms.RichTextBox();
            openFolder = new System.Windows.Forms.FolderBrowserDialog();
            panel_window_left = new System.Windows.Forms.Panel();
            panel_window_left_bottom = new System.Windows.Forms.Panel();
            panel_window_left_top = new System.Windows.Forms.Panel();
            panel_window_right = new System.Windows.Forms.Panel();
            panel_window_right_bottom = new System.Windows.Forms.Panel();
            panel_window_right_top = new System.Windows.Forms.Panel();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            panel_window = new System.Windows.Forms.Panel();
            mainMenu.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel_script_ctl.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            panel_paramList_btn.SuspendLayout();
            panel_paramList.SuspendLayout();
            panel_paramList_right.SuspendLayout();
            panel_typeList_btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            panel_typeList_label.SuspendLayout();
            panel_typeList.SuspendLayout();
            panel_previewList_label.SuspendLayout();
            panel_previewList.SuspendLayout();
            panel_opcode_textbox_label.SuspendLayout();
            panel_opcode_textbox.SuspendLayout();
            panel_opcode_textbox_param.SuspendLayout();
            panel_opcode_textbox_name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bytesView).BeginInit();
            panel_window_left.SuspendLayout();
            panel_window_left_bottom.SuspendLayout();
            panel_window_left_top.SuspendLayout();
            panel_window_right.SuspendLayout();
            panel_window_right_bottom.SuspendLayout();
            panel_window_right_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel_window.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenu
            // 
            mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { file, help });
            mainMenu.Location = new System.Drawing.Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new System.Drawing.Size(988, 25);
            mainMenu.TabIndex = 0;
            mainMenu.Text = "menuStrip1";
            // 
            // file
            // 
            file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuNew, menuOpen, menuOpenScript, toolStripSeparator, menuSave, menuSaveAs, toolStripSeparator1, menuClose, menuExit });
            file.Name = "file";
            file.Size = new System.Drawing.Size(39, 21);
            file.Text = "&File";
            // 
            // menuNew
            // 
            menuNew.Image = (System.Drawing.Image)resources.GetObject("menuNew.Image");
            menuNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            menuNew.Name = "menuNew";
            menuNew.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N;
            menuNew.Size = new System.Drawing.Size(206, 22);
            menuNew.Text = "&New Opcode";
            // 
            // menuOpen
            // 
            menuOpen.Image = (System.Drawing.Image)resources.GetObject("menuOpen.Image");
            menuOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            menuOpen.Name = "menuOpen";
            menuOpen.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            menuOpen.Size = new System.Drawing.Size(206, 22);
            menuOpen.Text = "&Open Opcode";
            // 
            // menuOpenScript
            // 
            menuOpenScript.Name = "menuOpenScript";
            menuOpenScript.Size = new System.Drawing.Size(206, 22);
            menuOpenScript.Text = "Open Script";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new System.Drawing.Size(203, 6);
            // 
            // menuSave
            // 
            menuSave.Image = (System.Drawing.Image)resources.GetObject("menuSave.Image");
            menuSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            menuSave.Name = "menuSave";
            menuSave.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            menuSave.Size = new System.Drawing.Size(206, 22);
            menuSave.Text = "&Save";
            // 
            // menuSaveAs
            // 
            menuSaveAs.Name = "menuSaveAs";
            menuSaveAs.Size = new System.Drawing.Size(206, 22);
            menuSaveAs.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // menuClose
            // 
            menuClose.Name = "menuClose";
            menuClose.Size = new System.Drawing.Size(206, 22);
            menuClose.Text = "Close Opcode";
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new System.Drawing.Size(206, 22);
            menuExit.Text = "E&xit";
            // 
            // help
            // 
            help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuHelp, toolStripSeparator5, menuAbout });
            help.Name = "help";
            help.Size = new System.Drawing.Size(47, 21);
            help.Text = "&Help";
            // 
            // menuHelp
            // 
            menuHelp.Name = "menuHelp";
            menuHelp.Size = new System.Drawing.Size(127, 22);
            menuHelp.Text = "&Contents";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(124, 6);
            // 
            // menuAbout
            // 
            menuAbout.Name = "menuAbout";
            menuAbout.Size = new System.Drawing.Size(127, 22);
            menuAbout.Text = "&About...";
            // 
            // openFile
            // 
            openFile.DefaultExt = "txt";
            openFile.FileName = "openFileDialog1";
            // 
            // saveFile
            // 
            saveFile.DefaultExt = "txt";
            saveFile.FileName = "OPCODE";
            saveFile.Filter = "文本文件(*.txt)|*.txt|所有文件|*.*";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel1, statusToolVersion, toolStripStatusLabel2, statusScriptVersion, toolStripStatusLabel4, statusItemSelect, toolStripStatusLabel3, statusBytesSelect });
            statusStrip1.Location = new System.Drawing.Point(0, 607);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(988, 27);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(57, 22);
            toolStripStatusLabel1.Text = "ToolVer:";
            // 
            // statusToolVersion
            // 
            statusToolVersion.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            statusToolVersion.Name = "statusToolVersion";
            statusToolVersion.Size = new System.Drawing.Size(68, 22);
            statusToolVersion.Text = "20201212";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new System.Drawing.Size(64, 22);
            toolStripStatusLabel2.Text = "ScriptVer:";
            // 
            // statusScriptVersion
            // 
            statusScriptVersion.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            statusScriptVersion.Name = "statusScriptVersion";
            statusScriptVersion.Size = new System.Drawing.Size(19, 22);
            statusScriptVersion.Text = "3";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new System.Drawing.Size(71, 22);
            toolStripStatusLabel4.Text = "ItemSelect:";
            // 
            // statusItemSelect
            // 
            statusItemSelect.AutoSize = false;
            statusItemSelect.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            statusItemSelect.Name = "statusItemSelect";
            statusItemSelect.Size = new System.Drawing.Size(128, 22);
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new System.Drawing.Size(76, 22);
            toolStripStatusLabel3.Text = "BytesSelect:";
            // 
            // statusBytesSelect
            // 
            statusBytesSelect.AutoSize = false;
            statusBytesSelect.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            statusBytesSelect.Name = "statusBytesSelect";
            statusBytesSelect.Size = new System.Drawing.Size(95, 22);
            statusBytesSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel_script_ctl);
            groupBox1.Controls.Add(labelScriptCodeNum);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(labelScriptCodeLen);
            groupBox1.Controls.Add(labelScriptCodeID);
            groupBox1.Controls.Add(labelScriptPos);
            groupBox1.Controls.Add(btnLoadScript);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(labelScriptSize);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textFilename);
            groupBox1.Controls.Add(label5);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(799, 120);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "脚本控制";
            // 
            // panel_script_ctl
            // 
            panel_script_ctl.Controls.Add(btnScriptJump);
            panel_script_ctl.Controls.Add(btnRestore);
            panel_script_ctl.Controls.Add(textJumpPosition);
            panel_script_ctl.Controls.Add(textJumpIndex);
            panel_script_ctl.Controls.Add(btnLoadNext);
            panel_script_ctl.Controls.Add(btnLoadPrev);
            panel_script_ctl.Controls.Add(radioJumpPosition);
            panel_script_ctl.Controls.Add(radioJumpIndex);
            panel_script_ctl.Dock = System.Windows.Forms.DockStyle.Right;
            panel_script_ctl.Location = new System.Drawing.Point(548, 19);
            panel_script_ctl.Name = "panel_script_ctl";
            panel_script_ctl.Size = new System.Drawing.Size(248, 98);
            panel_script_ctl.TabIndex = 48;
            // 
            // btnScriptJump
            // 
            btnScriptJump.Location = new System.Drawing.Point(0, 4);
            btnScriptJump.Name = "btnScriptJump";
            btnScriptJump.Size = new System.Drawing.Size(59, 52);
            btnScriptJump.TabIndex = 10;
            btnScriptJump.Text = "跳转到";
            btnScriptJump.UseVisualStyleBackColor = true;
            // 
            // btnRestore
            // 
            btnRestore.Location = new System.Drawing.Point(91, 62);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new System.Drawing.Size(58, 31);
            btnRestore.TabIndex = 47;
            btnRestore.Text = "重载";
            btnRestore.UseVisualStyleBackColor = true;
            // 
            // textJumpPosition
            // 
            textJumpPosition.Location = new System.Drawing.Point(160, 5);
            textJumpPosition.Name = "textJumpPosition";
            textJumpPosition.Size = new System.Drawing.Size(80, 23);
            textJumpPosition.TabIndex = 8;
            textJumpPosition.Text = "0";
            // 
            // textJumpIndex
            // 
            textJumpIndex.Location = new System.Drawing.Point(160, 33);
            textJumpIndex.Name = "textJumpIndex";
            textJumpIndex.Size = new System.Drawing.Size(80, 23);
            textJumpIndex.TabIndex = 9;
            textJumpIndex.Text = "0";
            // 
            // btnLoadNext
            // 
            btnLoadNext.Location = new System.Drawing.Point(155, 62);
            btnLoadNext.Name = "btnLoadNext";
            btnLoadNext.Size = new System.Drawing.Size(85, 31);
            btnLoadNext.TabIndex = 30;
            btnLoadNext.Text = "解析下一句>";
            btnLoadNext.UseVisualStyleBackColor = true;
            // 
            // btnLoadPrev
            // 
            btnLoadPrev.Location = new System.Drawing.Point(0, 62);
            btnLoadPrev.Name = "btnLoadPrev";
            btnLoadPrev.Size = new System.Drawing.Size(85, 31);
            btnLoadPrev.TabIndex = 31;
            btnLoadPrev.Text = "<解析上一句";
            btnLoadPrev.UseVisualStyleBackColor = true;
            // 
            // radioJumpPosition
            // 
            radioJumpPosition.AutoSize = true;
            radioJumpPosition.Checked = true;
            radioJumpPosition.Location = new System.Drawing.Point(68, 6);
            radioJumpPosition.Name = "radioJumpPosition";
            radioJumpPosition.Size = new System.Drawing.Size(86, 21);
            radioJumpPosition.TabIndex = 26;
            radioJumpPosition.TabStop = true;
            radioJumpPosition.Text = "语句位置：";
            radioJumpPosition.UseVisualStyleBackColor = true;
            // 
            // radioJumpIndex
            // 
            radioJumpIndex.AutoSize = true;
            radioJumpIndex.Location = new System.Drawing.Point(68, 35);
            radioJumpIndex.Name = "radioJumpIndex";
            radioJumpIndex.Size = new System.Drawing.Size(86, 21);
            radioJumpIndex.TabIndex = 27;
            radioJumpIndex.Text = "语句序号：";
            radioJumpIndex.UseVisualStyleBackColor = true;
            // 
            // labelScriptCodeNum
            // 
            labelScriptCodeNum.AutoSize = true;
            labelScriptCodeNum.Location = new System.Drawing.Point(206, 92);
            labelScriptCodeNum.Name = "labelScriptCodeNum";
            labelScriptCodeNum.Size = new System.Drawing.Size(15, 17);
            labelScriptCodeNum.TabIndex = 36;
            labelScriptCodeNum.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(144, 92);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(68, 17);
            label14.TabIndex = 35;
            label14.Text = "语句数量：";
            // 
            // labelScriptCodeLen
            // 
            labelScriptCodeLen.AutoSize = true;
            labelScriptCodeLen.Location = new System.Drawing.Point(69, 92);
            labelScriptCodeLen.Name = "labelScriptCodeLen";
            labelScriptCodeLen.Size = new System.Drawing.Size(15, 17);
            labelScriptCodeLen.TabIndex = 3;
            labelScriptCodeLen.Text = "0";
            // 
            // labelScriptCodeID
            // 
            labelScriptCodeID.AutoSize = true;
            labelScriptCodeID.Location = new System.Drawing.Point(206, 69);
            labelScriptCodeID.Name = "labelScriptCodeID";
            labelScriptCodeID.Size = new System.Drawing.Size(15, 17);
            labelScriptCodeID.TabIndex = 34;
            labelScriptCodeID.Text = "0";
            // 
            // labelScriptPos
            // 
            labelScriptPos.AutoSize = true;
            labelScriptPos.Location = new System.Drawing.Point(69, 69);
            labelScriptPos.Name = "labelScriptPos";
            labelScriptPos.Size = new System.Drawing.Size(15, 17);
            labelScriptPos.TabIndex = 33;
            labelScriptPos.Text = "0";
            // 
            // btnLoadScript
            // 
            btnLoadScript.Location = new System.Drawing.Point(239, 20);
            btnLoadScript.Name = "btnLoadScript";
            btnLoadScript.Size = new System.Drawing.Size(78, 23);
            btnLoadScript.TabIndex = 32;
            btnLoadScript.Text = "载入脚本";
            btnLoadScript.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(144, 69);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(68, 17);
            label10.TabIndex = 29;
            label10.Text = "当前序号：";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(7, 92);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(68, 17);
            label9.TabIndex = 28;
            label9.Text = "语句长度：";
            // 
            // labelScriptSize
            // 
            labelScriptSize.AutoSize = true;
            labelScriptSize.Location = new System.Drawing.Point(69, 46);
            labelScriptSize.Name = "labelScriptSize";
            labelScriptSize.Size = new System.Drawing.Size(15, 17);
            labelScriptSize.TabIndex = 5;
            labelScriptSize.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(7, 46);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(68, 17);
            label8.TabIndex = 4;
            label8.Text = "脚本大小：";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(7, 69);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(68, 17);
            label7.TabIndex = 2;
            label7.Text = "当前位置：";
            // 
            // textFilename
            // 
            textFilename.Location = new System.Drawing.Point(69, 20);
            textFilename.Name = "textFilename";
            textFilename.ReadOnly = true;
            textFilename.Size = new System.Drawing.Size(155, 23);
            textFilename.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(7, 23);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(68, 17);
            label5.TabIndex = 1;
            label5.Text = "文 件 名 ：";
            // 
            // scriptList
            // 
            scriptList.Dock = System.Windows.Forms.DockStyle.Fill;
            scriptList.FormattingEnabled = true;
            scriptList.ItemHeight = 17;
            scriptList.Location = new System.Drawing.Point(0, 17);
            scriptList.Name = "scriptList";
            scriptList.Size = new System.Drawing.Size(185, 221);
            scriptList.TabIndex = 26;
            // 
            // opcodeList
            // 
            opcodeList.Dock = System.Windows.Forms.DockStyle.Fill;
            opcodeList.FormattingEnabled = true;
            opcodeList.ItemHeight = 17;
            opcodeList.Location = new System.Drawing.Point(0, 17);
            opcodeList.Name = "opcodeList";
            opcodeList.Size = new System.Drawing.Size(185, 327);
            opcodeList.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = System.Windows.Forms.DockStyle.Top;
            label11.Location = new System.Drawing.Point(0, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(92, 17);
            label11.TabIndex = 28;
            label11.Text = "脚本文件列表：";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = System.Windows.Forms.DockStyle.Top;
            label12.Location = new System.Drawing.Point(0, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(95, 17);
            label12.TabIndex = 29;
            label12.Text = "OPCODE列表：";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(splitContainer2);
            groupBox2.Controls.Add(panel_opcode_textbox_label);
            groupBox2.Controls.Add(bytesView);
            groupBox2.Controls.Add(textView);
            groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox2.Location = new System.Drawing.Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(799, 462);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "OPCODE控制";
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer2.Location = new System.Drawing.Point(3, 65);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(panel_paramList_btn);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer3);
            splitContainer2.Size = new System.Drawing.Size(793, 264);
            splitContainer2.SplitterDistance = 280;
            splitContainer2.TabIndex = 52;
            // 
            // panel_paramList_btn
            // 
            panel_paramList_btn.Controls.Add(panel_paramList);
            panel_paramList_btn.Controls.Add(panel_paramList_right);
            panel_paramList_btn.Controls.Add(label2);
            panel_paramList_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_paramList_btn.Location = new System.Drawing.Point(0, 0);
            panel_paramList_btn.Name = "panel_paramList_btn";
            panel_paramList_btn.Size = new System.Drawing.Size(280, 264);
            panel_paramList_btn.TabIndex = 48;
            // 
            // panel_paramList
            // 
            panel_paramList.Controls.Add(paramsList);
            panel_paramList.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_paramList.Location = new System.Drawing.Point(0, 17);
            panel_paramList.Name = "panel_paramList";
            panel_paramList.Size = new System.Drawing.Size(172, 247);
            panel_paramList.TabIndex = 50;
            // 
            // paramsList
            // 
            paramsList.Dock = System.Windows.Forms.DockStyle.Fill;
            paramsList.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            paramsList.FullRowSelect = true;
            paramsList.GridLines = true;
            paramsList.Location = new System.Drawing.Point(0, 0);
            paramsList.MultiSelect = false;
            paramsList.Name = "paramsList";
            paramsList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            paramsList.Scrollable = false;
            paramsList.Size = new System.Drawing.Size(172, 247);
            paramsList.TabIndex = 25;
            paramsList.TileSize = new System.Drawing.Size(60, 40);
            paramsList.UseCompatibleStateImageBehavior = false;
            paramsList.View = System.Windows.Forms.View.List;
            // 
            // panel_paramList_right
            // 
            panel_paramList_right.Controls.Add(panel_typeList_btn);
            panel_paramList_right.Controls.Add(btnPreview);
            panel_paramList_right.Controls.Add(btnDelete);
            panel_paramList_right.Controls.Add(btnApply);
            panel_paramList_right.Dock = System.Windows.Forms.DockStyle.Right;
            panel_paramList_right.Location = new System.Drawing.Point(172, 17);
            panel_paramList_right.Name = "panel_paramList_right";
            panel_paramList_right.Size = new System.Drawing.Size(108, 247);
            panel_paramList_right.TabIndex = 49;
            // 
            // panel_typeList_btn
            // 
            panel_typeList_btn.Controls.Add(btnInsertUp);
            panel_typeList_btn.Controls.Add(checkNullable);
            panel_typeList_btn.Controls.Add(checkExport);
            panel_typeList_btn.Controls.Add(btnInsertDown);
            panel_typeList_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_typeList_btn.Location = new System.Drawing.Point(0, 141);
            panel_typeList_btn.Name = "panel_typeList_btn";
            panel_typeList_btn.Size = new System.Drawing.Size(108, 106);
            panel_typeList_btn.TabIndex = 47;
            // 
            // btnInsertUp
            // 
            btnInsertUp.Location = new System.Drawing.Point(33, 48);
            btnInsertUp.Name = "btnInsertUp";
            btnInsertUp.Size = new System.Drawing.Size(75, 23);
            btnInsertUp.TabIndex = 28;
            btnInsertUp.Text = "<向上插入";
            btnInsertUp.UseVisualStyleBackColor = true;
            // 
            // checkNullable
            // 
            checkNullable.AutoSize = true;
            checkNullable.Location = new System.Drawing.Point(57, 26);
            checkNullable.Name = "checkNullable";
            checkNullable.Size = new System.Drawing.Size(51, 21);
            checkNullable.TabIndex = 44;
            checkNullable.Text = "可空";
            checkNullable.UseVisualStyleBackColor = true;
            // 
            // checkExport
            // 
            checkExport.AutoSize = true;
            checkExport.Location = new System.Drawing.Point(57, 7);
            checkExport.Name = "checkExport";
            checkExport.Size = new System.Drawing.Size(51, 21);
            checkExport.TabIndex = 45;
            checkExport.Text = "导出";
            checkExport.UseVisualStyleBackColor = true;
            // 
            // btnInsertDown
            // 
            btnInsertDown.Location = new System.Drawing.Point(33, 77);
            btnInsertDown.Name = "btnInsertDown";
            btnInsertDown.Size = new System.Drawing.Size(75, 23);
            btnInsertDown.TabIndex = 29;
            btnInsertDown.Text = "<向下插入";
            btnInsertDown.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            btnPreview.Location = new System.Drawing.Point(6, 72);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new System.Drawing.Size(92, 30);
            btnPreview.TabIndex = 46;
            btnPreview.Text = "应用此条";
            btnPreview.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(6, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(75, 23);
            btnDelete.TabIndex = 30;
            btnDelete.Text = "删除";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            btnApply.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            btnApply.Location = new System.Drawing.Point(5, 108);
            btnApply.Name = "btnApply";
            btnApply.Size = new System.Drawing.Size(93, 35);
            btnApply.TabIndex = 43;
            btnApply.Text = "应用全局";
            btnApply.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Top;
            label2.Location = new System.Drawing.Point(0, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(152, 17);
            label2.TabIndex = 37;
            label2.Text = "参数类型列表（可拖动）：";
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer3.Location = new System.Drawing.Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(panel_typeList_label);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(panel_previewList_label);
            splitContainer3.Size = new System.Drawing.Size(509, 264);
            splitContainer3.SplitterDistance = 185;
            splitContainer3.TabIndex = 52;
            // 
            // panel_typeList_label
            // 
            panel_typeList_label.Controls.Add(panel_typeList);
            panel_typeList_label.Controls.Add(label3);
            panel_typeList_label.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_typeList_label.Location = new System.Drawing.Point(0, 0);
            panel_typeList_label.Name = "panel_typeList_label";
            panel_typeList_label.Size = new System.Drawing.Size(185, 264);
            panel_typeList_label.TabIndex = 51;
            // 
            // panel_typeList
            // 
            panel_typeList.Controls.Add(typeList);
            panel_typeList.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_typeList.Location = new System.Drawing.Point(0, 17);
            panel_typeList.Name = "panel_typeList";
            panel_typeList.Size = new System.Drawing.Size(185, 247);
            panel_typeList.TabIndex = 50;
            // 
            // typeList
            // 
            typeList.Dock = System.Windows.Forms.DockStyle.Fill;
            typeList.FormattingEnabled = true;
            typeList.ItemHeight = 17;
            typeList.Location = new System.Drawing.Point(0, 0);
            typeList.Name = "typeList";
            typeList.Size = new System.Drawing.Size(185, 247);
            typeList.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = System.Windows.Forms.DockStyle.Top;
            label3.Location = new System.Drawing.Point(0, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(140, 17);
            label3.TabIndex = 38;
            label3.Text = "可选类型（双击插入）：";
            // 
            // panel_previewList_label
            // 
            panel_previewList_label.Controls.Add(panel_previewList);
            panel_previewList_label.Controls.Add(label4);
            panel_previewList_label.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_previewList_label.Location = new System.Drawing.Point(0, 0);
            panel_previewList_label.Name = "panel_previewList_label";
            panel_previewList_label.Size = new System.Drawing.Size(320, 264);
            panel_previewList_label.TabIndex = 49;
            // 
            // panel_previewList
            // 
            panel_previewList.Controls.Add(previewList);
            panel_previewList.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_previewList.Location = new System.Drawing.Point(0, 17);
            panel_previewList.Name = "panel_previewList";
            panel_previewList.Size = new System.Drawing.Size(320, 247);
            panel_previewList.TabIndex = 50;
            // 
            // previewList
            // 
            previewList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { type, value });
            previewList.Dock = System.Windows.Forms.DockStyle.Fill;
            previewList.FullRowSelect = true;
            previewList.GridLines = true;
            previewList.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6, listViewItem7, listViewItem8, listViewItem9, listViewItem10 });
            previewList.Location = new System.Drawing.Point(0, 0);
            previewList.MultiSelect = false;
            previewList.Name = "previewList";
            previewList.Size = new System.Drawing.Size(320, 247);
            previewList.TabIndex = 34;
            previewList.UseCompatibleStateImageBehavior = false;
            previewList.View = System.Windows.Forms.View.Details;
            // 
            // type
            // 
            type.Name = "type";
            type.Text = "Type";
            type.Width = 100;
            // 
            // value
            // 
            value.Name = "value";
            value.Text = "Value";
            value.Width = 210;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = System.Windows.Forms.DockStyle.Top;
            label4.Location = new System.Drawing.Point(0, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(188, 17);
            label4.TabIndex = 39;
            label4.Text = "数据预览（双击复制到剪辑板）：";
            // 
            // panel_opcode_textbox_label
            // 
            panel_opcode_textbox_label.Controls.Add(panel_opcode_textbox);
            panel_opcode_textbox_label.Controls.Add(label1);
            panel_opcode_textbox_label.Controls.Add(label6);
            panel_opcode_textbox_label.Dock = System.Windows.Forms.DockStyle.Top;
            panel_opcode_textbox_label.Location = new System.Drawing.Point(3, 19);
            panel_opcode_textbox_label.Name = "panel_opcode_textbox_label";
            panel_opcode_textbox_label.Size = new System.Drawing.Size(793, 46);
            panel_opcode_textbox_label.TabIndex = 47;
            // 
            // panel_opcode_textbox
            // 
            panel_opcode_textbox.Controls.Add(panel_opcode_textbox_param);
            panel_opcode_textbox.Controls.Add(panel_opcode_textbox_name);
            panel_opcode_textbox.Controls.Add(btnTextToList);
            panel_opcode_textbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel_opcode_textbox.Location = new System.Drawing.Point(0, 21);
            panel_opcode_textbox.Name = "panel_opcode_textbox";
            panel_opcode_textbox.Size = new System.Drawing.Size(793, 25);
            panel_opcode_textbox.TabIndex = 43;
            // 
            // panel_opcode_textbox_param
            // 
            panel_opcode_textbox_param.Controls.Add(textParams);
            panel_opcode_textbox_param.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_opcode_textbox_param.Location = new System.Drawing.Point(194, 0);
            panel_opcode_textbox_param.Name = "panel_opcode_textbox_param";
            panel_opcode_textbox_param.Size = new System.Drawing.Size(523, 25);
            panel_opcode_textbox_param.TabIndex = 48;
            // 
            // textParams
            // 
            textParams.Dock = System.Windows.Forms.DockStyle.Fill;
            textParams.Location = new System.Drawing.Point(0, 0);
            textParams.Name = "textParams";
            textParams.Size = new System.Drawing.Size(523, 23);
            textParams.TabIndex = 40;
            // 
            // panel_opcode_textbox_name
            // 
            panel_opcode_textbox_name.Controls.Add(textOpcode);
            panel_opcode_textbox_name.Dock = System.Windows.Forms.DockStyle.Left;
            panel_opcode_textbox_name.Location = new System.Drawing.Point(0, 0);
            panel_opcode_textbox_name.Name = "panel_opcode_textbox_name";
            panel_opcode_textbox_name.Size = new System.Drawing.Size(194, 25);
            panel_opcode_textbox_name.TabIndex = 48;
            // 
            // textOpcode
            // 
            textOpcode.Dock = System.Windows.Forms.DockStyle.Fill;
            textOpcode.Location = new System.Drawing.Point(0, 0);
            textOpcode.Name = "textOpcode";
            textOpcode.Size = new System.Drawing.Size(194, 23);
            textOpcode.TabIndex = 35;
            // 
            // btnTextToList
            // 
            btnTextToList.Dock = System.Windows.Forms.DockStyle.Right;
            btnTextToList.Location = new System.Drawing.Point(717, 0);
            btnTextToList.Name = "btnTextToList";
            btnTextToList.Size = new System.Drawing.Size(76, 25);
            btnTextToList.TabIndex = 42;
            btnTextToList.Text = "解析到列表";
            btnTextToList.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(115, 17);
            label1.TabIndex = 36;
            label1.Text = "OPCODE(指令名)：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(194, 1);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(92, 17);
            label6.TabIndex = 41;
            label6.Text = "参数类型序列：";
            // 
            // bytesView
            // 
            bytesView.AllowUserToAddRows = false;
            bytesView.AllowUserToDeleteRows = false;
            bytesView.AllowUserToResizeColumns = false;
            bytesView.AllowUserToResizeRows = false;
            bytesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bytesView.ColumnHeadersVisible = false;
            bytesView.Dock = System.Windows.Forms.DockStyle.Bottom;
            bytesView.Location = new System.Drawing.Point(3, 329);
            bytesView.Name = "bytesView";
            bytesView.ReadOnly = true;
            bytesView.RowHeadersVisible = false;
            bytesView.ShowCellToolTips = false;
            bytesView.Size = new System.Drawing.Size(793, 45);
            bytesView.TabIndex = 33;
            // 
            // textView
            // 
            textView.Dock = System.Windows.Forms.DockStyle.Bottom;
            textView.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F);
            textView.Location = new System.Drawing.Point(3, 374);
            textView.Name = "textView";
            textView.Size = new System.Drawing.Size(793, 85);
            textView.TabIndex = 26;
            textView.Text = "";
            // 
            // openFolder
            // 
            openFolder.Description = "选择脚本所在文件夹";
            openFolder.UseDescriptionForTitle = true;
            // 
            // panel_window_left
            // 
            panel_window_left.Controls.Add(panel_window_left_bottom);
            panel_window_left.Controls.Add(panel_window_left_top);
            panel_window_left.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_window_left.Location = new System.Drawing.Point(0, 0);
            panel_window_left.Name = "panel_window_left";
            panel_window_left.Size = new System.Drawing.Size(185, 582);
            panel_window_left.TabIndex = 32;
            // 
            // panel_window_left_bottom
            // 
            panel_window_left_bottom.Controls.Add(opcodeList);
            panel_window_left_bottom.Controls.Add(label12);
            panel_window_left_bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_window_left_bottom.Location = new System.Drawing.Point(0, 238);
            panel_window_left_bottom.Name = "panel_window_left_bottom";
            panel_window_left_bottom.Size = new System.Drawing.Size(185, 344);
            panel_window_left_bottom.TabIndex = 35;
            // 
            // panel_window_left_top
            // 
            panel_window_left_top.Controls.Add(scriptList);
            panel_window_left_top.Controls.Add(label11);
            panel_window_left_top.Dock = System.Windows.Forms.DockStyle.Top;
            panel_window_left_top.Location = new System.Drawing.Point(0, 0);
            panel_window_left_top.Name = "panel_window_left_top";
            panel_window_left_top.Size = new System.Drawing.Size(185, 238);
            panel_window_left_top.TabIndex = 34;
            // 
            // panel_window_right
            // 
            panel_window_right.Controls.Add(panel_window_right_bottom);
            panel_window_right.Controls.Add(panel_window_right_top);
            panel_window_right.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_window_right.Location = new System.Drawing.Point(0, 0);
            panel_window_right.Name = "panel_window_right";
            panel_window_right.Size = new System.Drawing.Size(799, 582);
            panel_window_right.TabIndex = 33;
            // 
            // panel_window_right_bottom
            // 
            panel_window_right_bottom.Controls.Add(groupBox2);
            panel_window_right_bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_window_right_bottom.Location = new System.Drawing.Point(0, 120);
            panel_window_right_bottom.Name = "panel_window_right_bottom";
            panel_window_right_bottom.Size = new System.Drawing.Size(799, 462);
            panel_window_right_bottom.TabIndex = 32;
            // 
            // panel_window_right_top
            // 
            panel_window_right_top.Controls.Add(groupBox1);
            panel_window_right_top.Dock = System.Windows.Forms.DockStyle.Top;
            panel_window_right_top.Location = new System.Drawing.Point(0, 0);
            panel_window_right_top.Name = "panel_window_right_top";
            panel_window_right_top.Size = new System.Drawing.Size(799, 120);
            panel_window_right_top.TabIndex = 31;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel_window_left);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel_window_right);
            splitContainer1.Size = new System.Drawing.Size(988, 582);
            splitContainer1.SplitterDistance = 185;
            splitContainer1.TabIndex = 49;
            // 
            // panel_window
            // 
            panel_window.Controls.Add(splitContainer1);
            panel_window.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_window.Location = new System.Drawing.Point(0, 25);
            panel_window.Name = "panel_window";
            panel_window.Size = new System.Drawing.Size(988, 582);
            panel_window.TabIndex = 52;
            // 
            // Guide
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(988, 634);
            Controls.Add(panel_window);
            Controls.Add(statusStrip1);
            Controls.Add(mainMenu);
            MainMenuStrip = mainMenu;
            Name = "Guide";
            Text = "OpcodeGuide";
            FormClosing += Guide_FormClosing;
            Load += Guide_Load;
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel_script_ctl.ResumeLayout(false);
            panel_script_ctl.PerformLayout();
            groupBox2.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            panel_paramList_btn.ResumeLayout(false);
            panel_paramList_btn.PerformLayout();
            panel_paramList.ResumeLayout(false);
            panel_paramList_right.ResumeLayout(false);
            panel_typeList_btn.ResumeLayout(false);
            panel_typeList_btn.PerformLayout();
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            panel_typeList_label.ResumeLayout(false);
            panel_typeList_label.PerformLayout();
            panel_typeList.ResumeLayout(false);
            panel_previewList_label.ResumeLayout(false);
            panel_previewList_label.PerformLayout();
            panel_previewList.ResumeLayout(false);
            panel_opcode_textbox_label.ResumeLayout(false);
            panel_opcode_textbox_label.PerformLayout();
            panel_opcode_textbox.ResumeLayout(false);
            panel_opcode_textbox_param.ResumeLayout(false);
            panel_opcode_textbox_param.PerformLayout();
            panel_opcode_textbox_name.ResumeLayout(false);
            panel_opcode_textbox_name.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bytesView).EndInit();
            panel_window_left.ResumeLayout(false);
            panel_window_left_bottom.ResumeLayout(false);
            panel_window_left_bottom.PerformLayout();
            panel_window_left_top.ResumeLayout(false);
            panel_window_left_top.PerformLayout();
            panel_window_right.ResumeLayout(false);
            panel_window_right_bottom.ResumeLayout(false);
            panel_window_right_top.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel_window.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.ToolStripMenuItem menuClose;
        private System.Windows.Forms.ToolStripMenuItem menuOpenScript;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusToolVersion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel statusScriptVersion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel statusBytesSelect;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel statusItemSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textJumpIndex;
        private System.Windows.Forms.TextBox textJumpPosition;
        private System.Windows.Forms.Label labelScriptSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelScriptCodeLen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textFilename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnScriptJump;
        private System.Windows.Forms.RadioButton radioJumpPosition;
        private System.Windows.Forms.RadioButton radioJumpIndex;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLoadPrev;
        private System.Windows.Forms.Button btnLoadNext;
        private System.Windows.Forms.ListBox scriptList;
        private System.Windows.Forms.ListBox opcodeList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkExport;
        private System.Windows.Forms.CheckBox checkNullable;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnTextToList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textParams;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textOpcode;
        private System.Windows.Forms.ListView previewList;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader value;
        private System.Windows.Forms.DataGridView bytesView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsertDown;
        private System.Windows.Forms.Button btnInsertUp;
        private System.Windows.Forms.ListBox typeList;
        private System.Windows.Forms.RichTextBox textView;
        private System.Windows.Forms.ListView paramsList;
        private System.Windows.Forms.FolderBrowserDialog openFolder;
        private System.Windows.Forms.Button btnLoadScript;
        private System.Windows.Forms.Label labelScriptCodeID;
        private System.Windows.Forms.Label labelScriptPos;
        private System.Windows.Forms.Label labelScriptCodeNum;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Panel panel_window_left;
        private System.Windows.Forms.Panel panel_window_right;
        private System.Windows.Forms.Panel panel_window_left_bottom;
        private System.Windows.Forms.Panel panel_window_left_top;
        private System.Windows.Forms.Panel panel_window_right_bottom;
        private System.Windows.Forms.Panel panel_window_right_top;
        private System.Windows.Forms.Panel panel_opcode_textbox_label;
        private System.Windows.Forms.Panel panel_paramList_btn;
        private System.Windows.Forms.Panel panel_paramList;
        private System.Windows.Forms.Panel panel_paramList_right;
        private System.Windows.Forms.Panel panel_typeList_label;
        private System.Windows.Forms.Panel panel_typeList;
        private System.Windows.Forms.Panel panel_previewList_label;
        private System.Windows.Forms.Panel panel_previewList;
        private System.Windows.Forms.Panel panel_opcode_textbox;
        private System.Windows.Forms.Panel panel_opcode_textbox_name;
        private System.Windows.Forms.Panel panel_opcode_textbox_param;
        private System.Windows.Forms.Panel panel_typeList_btn;
        private System.Windows.Forms.Panel panel_script_ctl;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel_window;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
    }
}

