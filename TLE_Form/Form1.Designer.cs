namespace TLE_Form
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入TLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开TLE数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新TLE数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.太阳星历计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.numTrackTime = new System.Windows.Forms.NumericUpDown();
            this.numMinEl = new System.Windows.Forms.NumericUpDown();
            this.numPridectDay = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timeStart = new System.Windows.Forms.DateTimePicker();
            this.btnPridect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.numLat = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numLog = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textSatLine2 = new System.Windows.Forms.TextBox();
            this.textSatLine1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textSatName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvMission = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.全部导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrackTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinEl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPridectDay)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLog)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMission)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑ToolStripMenuItem,
            this.太阳星历计算ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入TLEToolStripMenuItem,
            this.打开TLE数据库ToolStripMenuItem,
            this.更新TLE数据库ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 导入TLEToolStripMenuItem
            // 
            this.导入TLEToolStripMenuItem.Name = "导入TLEToolStripMenuItem";
            this.导入TLEToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.导入TLEToolStripMenuItem.Text = "导入TLE";
            this.导入TLEToolStripMenuItem.Click += new System.EventHandler(this.导入TLEToolStripMenuItem_Click);
            // 
            // 打开TLE数据库ToolStripMenuItem
            // 
            this.打开TLE数据库ToolStripMenuItem.Name = "打开TLE数据库ToolStripMenuItem";
            this.打开TLE数据库ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.打开TLE数据库ToolStripMenuItem.Text = "打开TLE数据库";
            this.打开TLE数据库ToolStripMenuItem.Click += new System.EventHandler(this.打开TLE数据库ToolStripMenuItem_Click);
            // 
            // 更新TLE数据库ToolStripMenuItem
            // 
            this.更新TLE数据库ToolStripMenuItem.Name = "更新TLE数据库ToolStripMenuItem";
            this.更新TLE数据库ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.更新TLE数据库ToolStripMenuItem.Text = "更新TLE数据库";
            this.更新TLE数据库ToolStripMenuItem.Click += new System.EventHandler(this.更新TLE数据库ToolStripMenuItem_Click);
            // 
            // 太阳星历计算ToolStripMenuItem
            // 
            this.太阳星历计算ToolStripMenuItem.Name = "太阳星历计算ToolStripMenuItem";
            this.太阳星历计算ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.太阳星历计算ToolStripMenuItem.Text = "太阳星历计算";
            this.太阳星历计算ToolStripMenuItem.Click += new System.EventHandler(this.太阳星历计算ToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            this.设置ToolStripMenuItem.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.btnPridect);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(785, 557);
            this.splitContainer1.SplitterDistance = 356;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 131);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "时间设置";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.numTrackTime, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.numMinEl, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.numPridectDay, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.timeStart, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(350, 111);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // numTrackTime
            // 
            this.numTrackTime.DecimalPlaces = 2;
            this.numTrackTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numTrackTime.Location = new System.Drawing.Point(100, 84);
            this.numTrackTime.Name = "numTrackTime";
            this.numTrackTime.Size = new System.Drawing.Size(247, 21);
            this.numTrackTime.TabIndex = 11;
            this.numTrackTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numMinEl
            // 
            this.numMinEl.DecimalPlaces = 2;
            this.numMinEl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numMinEl.Location = new System.Drawing.Point(100, 57);
            this.numMinEl.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numMinEl.Name = "numMinEl";
            this.numMinEl.Size = new System.Drawing.Size(247, 21);
            this.numMinEl.TabIndex = 10;
            this.numMinEl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numPridectDay
            // 
            this.numPridectDay.DecimalPlaces = 1;
            this.numPridectDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPridectDay.Location = new System.Drawing.Point(100, 30);
            this.numPridectDay.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPridectDay.Name = "numPridectDay";
            this.numPridectDay.Size = new System.Drawing.Size(247, 21);
            this.numPridectDay.TabIndex = 9;
            this.numPridectDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 30);
            this.label10.TabIndex = 7;
            this.label10.Text = "跟踪时长(min)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 27);
            this.label7.TabIndex = 4;
            this.label7.Text = "起始时间";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 27);
            this.label8.TabIndex = 5;
            this.label8.Text = "预测天数";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 27);
            this.label9.TabIndex = 6;
            this.label9.Text = "最小仰角(°)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeStart
            // 
            this.timeStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeStart.Location = new System.Drawing.Point(100, 3);
            this.timeStart.Name = "timeStart";
            this.timeStart.Size = new System.Drawing.Size(247, 21);
            this.timeStart.TabIndex = 8;
            this.timeStart.Value = new System.DateTime(2021, 11, 2, 11, 56, 57, 0);
            // 
            // btnPridect
            // 
            this.btnPridect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPridect.Location = new System.Drawing.Point(259, 362);
            this.btnPridect.Name = "btnPridect";
            this.btnPridect.Size = new System.Drawing.Size(91, 33);
            this.btnPridect.TabIndex = 2;
            this.btnPridect.Text = "任务预测";
            this.btnPridect.UseVisualStyleBackColor = true;
            this.btnPridect.Click += new System.EventHandler(this.btnPridect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 115);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "站址";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.numHeight, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.numLat, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.numLog, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(350, 95);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // numHeight
            // 
            this.numHeight.DecimalPlaces = 5;
            this.numHeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numHeight.Location = new System.Drawing.Point(62, 65);
            this.numHeight.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(285, 21);
            this.numHeight.TabIndex = 7;
            this.numHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numLat
            // 
            this.numLat.DecimalPlaces = 5;
            this.numLat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numLat.Location = new System.Drawing.Point(62, 34);
            this.numLat.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numLat.Name = "numLat";
            this.numLat.Size = new System.Drawing.Size(285, 21);
            this.numLat.TabIndex = 6;
            this.numLat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "经度";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 31);
            this.label6.TabIndex = 4;
            this.label6.Text = "纬度";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 33);
            this.label5.TabIndex = 3;
            this.label5.Text = "海拔(m)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numLog
            // 
            this.numLog.DecimalPlaces = 5;
            this.numLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numLog.Location = new System.Drawing.Point(62, 3);
            this.numLog.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numLog.Name = "numLog";
            this.numLog.Size = new System.Drawing.Size(285, 21);
            this.numLog.TabIndex = 5;
            this.numLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "卫星参数(TLE)";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textSatLine2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textSatLine1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textSatName, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 90);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textSatLine2
            // 
            this.textSatLine2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textSatLine2.Location = new System.Drawing.Point(62, 63);
            this.textSatLine2.Name = "textSatLine2";
            this.textSatLine2.Size = new System.Drawing.Size(285, 21);
            this.textSatLine2.TabIndex = 5;
            // 
            // textSatLine1
            // 
            this.textSatLine1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textSatLine1.Location = new System.Drawing.Point(62, 33);
            this.textSatLine1.Name = "textSatLine1";
            this.textSatLine1.Size = new System.Drawing.Size(285, 21);
            this.textSatLine1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Line 2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Line 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textSatName
            // 
            this.textSatName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textSatName.Location = new System.Drawing.Point(62, 3);
            this.textSatName.Name = "textSatName";
            this.textSatName.Size = new System.Drawing.Size(285, 21);
            this.textSatName.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvMission);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(425, 557);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "任务列表";
            // 
            // dgvMission
            // 
            this.dgvMission.AllowUserToAddRows = false;
            this.dgvMission.AllowUserToDeleteRows = false;
            this.dgvMission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMission.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvMission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMission.Location = new System.Drawing.Point(3, 17);
            this.dgvMission.Name = "dgvMission";
            this.dgvMission.ReadOnly = true;
            this.dgvMission.RowHeadersWidth = 82;
            this.dgvMission.RowTemplate.Height = 23;
            this.dgvMission.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMission.Size = new System.Drawing.Size(419, 537);
            this.dgvMission.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExport,
            this.全部导出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // menuExport
            // 
            this.menuExport.Name = "menuExport";
            this.menuExport.Size = new System.Drawing.Size(180, 22);
            this.menuExport.Text = "导出";
            this.menuExport.Click += new System.EventHandler(this.menuExport_Click);
            // 
            // 全部导出ToolStripMenuItem
            // 
            this.全部导出ToolStripMenuItem.Name = "全部导出ToolStripMenuItem";
            this.全部导出ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.全部导出ToolStripMenuItem.Text = "全部导出";
            this.全部导出ToolStripMenuItem.Click += new System.EventHandler(this.全部导出ToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 582);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "星历解析生成软件";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrackTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinEl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPridectDay)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLog)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMission)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.NumericUpDown numTrackTime;
        private System.Windows.Forms.NumericUpDown numMinEl;
        private System.Windows.Forms.NumericUpDown numPridectDay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker timeStart;
        private System.Windows.Forms.Button btnPridect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.NumericUpDown numLat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textSatLine2;
        private System.Windows.Forms.TextBox textSatLine1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSatName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvMission;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuExport;
        private System.Windows.Forms.ToolStripMenuItem 全部导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入TLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新TLE数据库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开TLE数据库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 太阳星历计算ToolStripMenuItem;
    }
}

