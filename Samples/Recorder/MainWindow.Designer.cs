namespace Recorder
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.appContainer = new System.Windows.Forms.SplitContainer();
            this.deviceslist = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnChannels = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDriverVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefreshDevices = new System.Windows.Forms.Button();
            this.peakRight = new System.Windows.Forms.ProgressBar();
            this.peakLeft = new System.Windows.Forms.ProgressBar();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblDynRangeValue = new System.Windows.Forms.Label();
            this.lblParpValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.appContainer)).BeginInit();
            this.appContainer.Panel1.SuspendLayout();
            this.appContainer.Panel2.SuspendLayout();
            this.appContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // appContainer
            // 
            this.appContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appContainer.Location = new System.Drawing.Point(0, 0);
            this.appContainer.Margin = new System.Windows.Forms.Padding(4);
            this.appContainer.Name = "appContainer";
            // 
            // appContainer.Panel1
            // 
            this.appContainer.Panel1.Controls.Add(this.deviceslist);
            // 
            // appContainer.Panel2
            // 
            this.appContainer.Panel2.Controls.Add(this.label4);
            this.appContainer.Panel2.Controls.Add(this.label3);
            this.appContainer.Panel2.Controls.Add(this.lblParpValue);
            this.appContainer.Panel2.Controls.Add(this.lblDynRangeValue);
            this.appContainer.Panel2.Controls.Add(this.btnRefreshDevices);
            this.appContainer.Panel2.Controls.Add(this.peakRight);
            this.appContainer.Panel2.Controls.Add(this.peakLeft);
            this.appContainer.Panel2.Controls.Add(this.btnStop);
            this.appContainer.Panel2.Controls.Add(this.btnStart);
            this.appContainer.Size = new System.Drawing.Size(1027, 439);
            this.appContainer.SplitterDistance = 676;
            this.appContainer.SplitterWidth = 5;
            this.appContainer.TabIndex = 0;
            // 
            // deviceslist
            // 
            this.deviceslist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnChannels,
            this.columnDriverVersion});
            this.deviceslist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceslist.Location = new System.Drawing.Point(0, 0);
            this.deviceslist.Margin = new System.Windows.Forms.Padding(4);
            this.deviceslist.MultiSelect = false;
            this.deviceslist.Name = "deviceslist";
            this.deviceslist.Size = new System.Drawing.Size(676, 439);
            this.deviceslist.TabIndex = 0;
            this.deviceslist.UseCompatibleStateImageBehavior = false;
            this.deviceslist.View = System.Windows.Forms.View.Details;
            this.deviceslist.SelectedIndexChanged += new System.EventHandler(this.deviceslist_SelectedIndexChanged);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 250;
            // 
            // columnChannels
            // 
            this.columnChannels.Text = "Channels";
            // 
            // columnDriverVersion
            // 
            this.columnDriverVersion.Text = "Driverversion";
            this.columnDriverVersion.Width = 80;
            // 
            // btnRefreshDevices
            // 
            this.btnRefreshDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshDevices.Location = new System.Drawing.Point(19, 141);
            this.btnRefreshDevices.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshDevices.MinimumSize = new System.Drawing.Size(100, 20);
            this.btnRefreshDevices.Name = "btnRefreshDevices";
            this.btnRefreshDevices.Size = new System.Drawing.Size(148, 28);
            this.btnRefreshDevices.TabIndex = 2;
            this.btnRefreshDevices.Text = "Refresh devices";
            this.btnRefreshDevices.UseVisualStyleBackColor = true;
            this.btnRefreshDevices.Click += new System.EventHandler(this.btnRefreshDevices_Click);
            // 
            // peakRight
            // 
            this.peakRight.Location = new System.Drawing.Point(19, 117);
            this.peakRight.Margin = new System.Windows.Forms.Padding(4);
            this.peakRight.Maximum = 10000;
            this.peakRight.Name = "peakRight";
            this.peakRight.Size = new System.Drawing.Size(271, 16);
            this.peakRight.TabIndex = 5;
            // 
            // peakLeft
            // 
            this.peakLeft.Location = new System.Drawing.Point(19, 94);
            this.peakLeft.Margin = new System.Windows.Forms.Padding(4);
            this.peakLeft.Maximum = 10000;
            this.peakLeft.Name = "peakLeft";
            this.peakLeft.Size = new System.Drawing.Size(271, 16);
            this.peakLeft.TabIndex = 4;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(19, 54);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(148, 28);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop recording";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(19, 17);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(148, 28);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start recording";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblDynRangeValue
            // 
            this.lblDynRangeValue.AutoSize = true;
            this.lblDynRangeValue.Location = new System.Drawing.Point(210, 338);
            this.lblDynRangeValue.Name = "lblDynRangeValue";
            this.lblDynRangeValue.Size = new System.Drawing.Size(0, 17);
            this.lblDynRangeValue.TabIndex = 6;
            // 
            // lblParpValue
            // 
            this.lblParpValue.AutoSize = true;
            this.lblParpValue.Location = new System.Drawing.Point(210, 382);
            this.lblParpValue.Name = "lblParpValue";
            this.lblParpValue.Size = new System.Drawing.Size(0, 17);
            this.lblParpValue.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dynamic range";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "peak-to-average-power ratio";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 439);
            this.Controls.Add(this.appContainer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "CSCore - Recorder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.appContainer.Panel1.ResumeLayout(false);
            this.appContainer.Panel2.ResumeLayout(false);
            this.appContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appContainer)).EndInit();
            this.appContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer appContainer;
        private System.Windows.Forms.Button btnRefreshDevices;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListView deviceslist;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnChannels;
        private System.Windows.Forms.ColumnHeader columnDriverVersion;
        private System.Windows.Forms.ProgressBar peakRight;
        private System.Windows.Forms.ProgressBar peakLeft;
        private System.Windows.Forms.Label lblParpValue;
        private System.Windows.Forms.Label lblDynRangeValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        
    }
}

