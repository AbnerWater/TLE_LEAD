namespace TLE_Form
{
    partial class FrmSetting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.numTrackDue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numMaxEl = new System.Windows.Forms.NumericUpDown();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrackDue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxEl)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.numTrackDue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numMaxEl, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(356, 120);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // numTrackDue
            // 
            this.numTrackDue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numTrackDue.Location = new System.Drawing.Point(176, 43);
            this.numTrackDue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTrackDue.Name = "numTrackDue";
            this.numTrackDue.Size = new System.Drawing.Size(177, 21);
            this.numTrackDue.TabIndex = 3;
            this.numTrackDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "最高仰角限制(°)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "引导文件时间间隔(ms)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numMaxEl
            // 
            this.numMaxEl.DecimalPlaces = 2;
            this.numMaxEl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numMaxEl.Location = new System.Drawing.Point(176, 3);
            this.numMaxEl.Name = "numMaxEl";
            this.numMaxEl.Size = new System.Drawing.Size(177, 21);
            this.numMaxEl.TabIndex = 2;
            this.numMaxEl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnApply.Location = new System.Drawing.Point(147, 196);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(91, 33);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "应用";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.Location = new System.Drawing.Point(259, 196);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 33);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 241);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSetting";
            this.ShowIcon = false;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.FrmSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrackDue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxEl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numTrackDue;
        private System.Windows.Forms.NumericUpDown numMaxEl;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
    }
}