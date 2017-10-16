namespace NetworkMonitor
{
    partial class Form1
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
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdStop = new System.Windows.Forms.Button();
            this.textStartTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textExternalIP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textEndTime = new System.Windows.Forms.Label();
            this.textLogs = new System.Windows.Forms.TextBox();
            this.comboFrequency = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboTarget = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textStatus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textResponseTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textFileLocation = new System.Windows.Forms.TextBox();
            this.checkSaveFile = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textMaximumCycles = new System.Windows.Forms.TextBox();
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.label10 = new System.Windows.Forms.Label();
            this.textElapsedms = new System.Windows.Forms.Label();
            this.cmdExit = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.cmdSearchDirectory = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.textPreviousIP = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textIPChangeCount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textDownTime = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textLastScan = new System.Windows.Forms.Label();
            this.textMaxDownTime = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textRunningTime = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textTotalDownTime = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textLastChangeTime = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textNWErrors = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdStart
            // 
            this.cmdStart.BackColor = System.Drawing.Color.Lime;
            this.cmdStart.Location = new System.Drawing.Point(352, 50);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(125, 34);
            this.cmdStart.TabIndex = 0;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = false;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cmdStop
            // 
            this.cmdStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdStop.Location = new System.Drawing.Point(518, 50);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(119, 34);
            this.cmdStop.TabIndex = 1;
            this.cmdStop.Text = "Stop";
            this.cmdStop.UseVisualStyleBackColor = false;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // textStartTime
            // 
            this.textStartTime.AutoSize = true;
            this.textStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStartTime.ForeColor = System.Drawing.Color.Maroon;
            this.textStartTime.Location = new System.Drawing.Point(420, 94);
            this.textStartTime.Name = "textStartTime";
            this.textStartTime.Size = new System.Drawing.Size(16, 13);
            this.textStartTime.TabIndex = 2;
            this.textStartTime.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(349, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(62, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "External IP";
            // 
            // textExternalIP
            // 
            this.textExternalIP.AutoSize = true;
            this.textExternalIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textExternalIP.ForeColor = System.Drawing.Color.Maroon;
            this.textExternalIP.Location = new System.Drawing.Point(144, 158);
            this.textExternalIP.Name = "textExternalIP";
            this.textExternalIP.Size = new System.Drawing.Size(19, 13);
            this.textExternalIP.TabIndex = 5;
            this.textExternalIP.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(443, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Finish Time";
            // 
            // textEndTime
            // 
            this.textEndTime.AutoSize = true;
            this.textEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEndTime.ForeColor = System.Drawing.Color.Maroon;
            this.textEndTime.Location = new System.Drawing.Point(520, 293);
            this.textEndTime.Name = "textEndTime";
            this.textEndTime.Size = new System.Drawing.Size(16, 13);
            this.textEndTime.TabIndex = 7;
            this.textEndTime.Text = "...";
            // 
            // textLogs
            // 
            this.textLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLogs.Location = new System.Drawing.Point(29, 319);
            this.textLogs.Multiline = true;
            this.textLogs.Name = "textLogs";
            this.textLogs.Size = new System.Drawing.Size(619, 219);
            this.textLogs.TabIndex = 8;
            // 
            // comboFrequency
            // 
            this.comboFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFrequency.FormattingEnabled = true;
            this.comboFrequency.Items.AddRange(new object[] {
            "10",
            "15",
            "30",
            "60",
            "120",
            "300",
            "600",
            "900"});
            this.comboFrequency.Location = new System.Drawing.Point(127, 50);
            this.comboFrequency.Name = "comboFrequency";
            this.comboFrequency.Size = new System.Drawing.Size(184, 21);
            this.comboFrequency.TabIndex = 9;
            this.comboFrequency.Text = "60";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(20, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Frequency (Secs)";
            // 
            // comboTarget
            // 
            this.comboTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTarget.FormattingEnabled = true;
            this.comboTarget.Items.AddRange(new object[] {
            "www.vodafone.co.nz",
            "www.teresoft.co.nz",
            "google.com",
            "www.teresoft.com"});
            this.comboTarget.Location = new System.Drawing.Point(127, 88);
            this.comboTarget.Name = "comboTarget";
            this.comboTarget.Size = new System.Drawing.Size(184, 21);
            this.comboTarget.TabIndex = 11;
            this.comboTarget.Text = "www.teresoft.co.nz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(79, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Target";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(26, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Status";
            // 
            // textStatus
            // 
            this.textStatus.AutoSize = true;
            this.textStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStatus.ForeColor = System.Drawing.Color.Maroon;
            this.textStatus.Location = new System.Drawing.Point(76, 293);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(16, 13);
            this.textStatus.TabIndex = 14;
            this.textStatus.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(248, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ping Time";
            // 
            // textResponseTime
            // 
            this.textResponseTime.AutoSize = true;
            this.textResponseTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResponseTime.ForeColor = System.Drawing.Color.Maroon;
            this.textResponseTime.Location = new System.Drawing.Point(318, 269);
            this.textResponseTime.Name = "textResponseTime";
            this.textResponseTime.Size = new System.Drawing.Size(16, 13);
            this.textResponseTime.TabIndex = 16;
            this.textResponseTime.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(17, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "File Location";
            // 
            // textFileLocation
            // 
            this.textFileLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFileLocation.Location = new System.Drawing.Point(99, 12);
            this.textFileLocation.Name = "textFileLocation";
            this.textFileLocation.Size = new System.Drawing.Size(283, 20);
            this.textFileLocation.TabIndex = 18;
            this.textFileLocation.Text = "c:\\temp\\NetworkMonitor";
            // 
            // checkSaveFile
            // 
            this.checkSaveFile.AutoSize = true;
            this.checkSaveFile.Location = new System.Drawing.Point(468, 16);
            this.checkSaveFile.Name = "checkSaveFile";
            this.checkSaveFile.Size = new System.Drawing.Size(125, 17);
            this.checkSaveFile.TabIndex = 19;
            this.checkSaveFile.Text = "Save Results File";
            this.checkSaveFile.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(26, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Maximum Cycles";
            // 
            // textMaximumCycles
            // 
            this.textMaximumCycles.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "1",
            "10",
            "100",
            "1000",
            "10000",
            "1000000"});
            this.textMaximumCycles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMaximumCycles.Location = new System.Drawing.Point(127, 122);
            this.textMaximumCycles.Name = "textMaximumCycles";
            this.textMaximumCycles.Size = new System.Drawing.Size(184, 20);
            this.textMaximumCycles.TabIndex = 21;
            this.textMaximumCycles.Text = "0";
            // 
            // bw
            // 
            this.bw.WorkerReportsProgress = true;
            this.bw.WorkerSupportsCancellation = true;
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            this.bw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw_ProgressChanged);
            this.bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(243, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Cycle Time";
            // 
            // textElapsedms
            // 
            this.textElapsedms.AutoSize = true;
            this.textElapsedms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textElapsedms.ForeColor = System.Drawing.Color.Maroon;
            this.textElapsedms.Location = new System.Drawing.Point(318, 242);
            this.textElapsedms.Name = "textElapsedms";
            this.textElapsedms.Size = new System.Drawing.Size(16, 13);
            this.textElapsedms.TabIndex = 23;
            this.textElapsedms.Text = "...";
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdExit.Location = new System.Drawing.Point(253, 544);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(129, 31);
            this.cmdExit.TabIndex = 24;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // cmdSearchDirectory
            // 
            this.cmdSearchDirectory.Location = new System.Drawing.Point(390, 12);
            this.cmdSearchDirectory.Name = "cmdSearchDirectory";
            this.cmdSearchDirectory.Size = new System.Drawing.Size(62, 23);
            this.cmdSearchDirectory.TabIndex = 25;
            this.cmdSearchDirectory.Text = "Search";
            this.cmdSearchDirectory.UseVisualStyleBackColor = true;
            this.cmdSearchDirectory.Click += new System.EventHandler(this.cmdSearchDirectory_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(9, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Previous External IP";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // textPreviousIP
            // 
            this.textPreviousIP.AutoSize = true;
            this.textPreviousIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPreviousIP.ForeColor = System.Drawing.Color.Maroon;
            this.textPreviousIP.Location = new System.Drawing.Point(144, 184);
            this.textPreviousIP.Name = "textPreviousIP";
            this.textPreviousIP.Size = new System.Drawing.Size(19, 13);
            this.textPreviousIP.TabIndex = 27;
            this.textPreviousIP.Text = "...";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(19, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "IP Changed Count";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // textIPChangeCount
            // 
            this.textIPChangeCount.AutoSize = true;
            this.textIPChangeCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIPChangeCount.ForeColor = System.Drawing.Color.Maroon;
            this.textIPChangeCount.Location = new System.Drawing.Point(144, 212);
            this.textIPChangeCount.Name = "textIPChangeCount";
            this.textIPChangeCount.Size = new System.Drawing.Size(19, 13);
            this.textIPChangeCount.TabIndex = 29;
            this.textIPChangeCount.Text = "...";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(37, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Last Downtime";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // textDownTime
            // 
            this.textDownTime.AutoSize = true;
            this.textDownTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDownTime.ForeColor = System.Drawing.Color.Maroon;
            this.textDownTime.Location = new System.Drawing.Point(144, 242);
            this.textDownTime.Name = "textDownTime";
            this.textDownTime.Size = new System.Drawing.Size(16, 13);
            this.textDownTime.TabIndex = 31;
            this.textDownTime.Text = "...";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(350, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Last Scan";
            // 
            // textLastScan
            // 
            this.textLastScan.AutoSize = true;
            this.textLastScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLastScan.ForeColor = System.Drawing.Color.Maroon;
            this.textLastScan.Location = new System.Drawing.Point(420, 125);
            this.textLastScan.Name = "textLastScan";
            this.textLastScan.Size = new System.Drawing.Size(16, 13);
            this.textLastScan.TabIndex = 32;
            this.textLastScan.Text = "...";
            // 
            // textMaxDownTime
            // 
            this.textMaxDownTime.AutoSize = true;
            this.textMaxDownTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMaxDownTime.ForeColor = System.Drawing.Color.Maroon;
            this.textMaxDownTime.Location = new System.Drawing.Point(144, 269);
            this.textMaxDownTime.Name = "textMaxDownTime";
            this.textMaxDownTime.Size = new System.Drawing.Size(16, 13);
            this.textMaxDownTime.TabIndex = 35;
            this.textMaxDownTime.Text = "...";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Navy;
            this.label16.Location = new System.Drawing.Point(16, 269);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Longest Downtime";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // textRunningTime
            // 
            this.textRunningTime.AutoSize = true;
            this.textRunningTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRunningTime.ForeColor = System.Drawing.Color.Maroon;
            this.textRunningTime.Location = new System.Drawing.Point(520, 242);
            this.textRunningTime.Name = "textRunningTime";
            this.textRunningTime.Size = new System.Drawing.Size(16, 13);
            this.textRunningTime.TabIndex = 37;
            this.textRunningTime.Text = "...";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Navy;
            this.label17.Location = new System.Drawing.Point(427, 242);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "Running TIme";
            // 
            // textTotalDownTime
            // 
            this.textTotalDownTime.AutoSize = true;
            this.textTotalDownTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotalDownTime.ForeColor = System.Drawing.Color.Maroon;
            this.textTotalDownTime.Location = new System.Drawing.Point(520, 269);
            this.textTotalDownTime.Name = "textTotalDownTime";
            this.textTotalDownTime.Size = new System.Drawing.Size(16, 13);
            this.textTotalDownTime.TabIndex = 39;
            this.textTotalDownTime.Text = "...";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Navy;
            this.label18.Location = new System.Drawing.Point(418, 269);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 13);
            this.label18.TabIndex = 38;
            this.label18.Text = "Total Downtime";
            // 
            // textLastChangeTime
            // 
            this.textLastChangeTime.AutoSize = true;
            this.textLastChangeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLastChangeTime.ForeColor = System.Drawing.Color.Maroon;
            this.textLastChangeTime.Location = new System.Drawing.Point(521, 212);
            this.textLastChangeTime.Name = "textLastChangeTime";
            this.textLastChangeTime.Size = new System.Drawing.Size(16, 13);
            this.textLastChangeTime.TabIndex = 41;
            this.textLastChangeTime.Text = "...";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Navy;
            this.label19.Location = new System.Drawing.Point(404, 212);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 13);
            this.label19.TabIndex = 40;
            this.label19.Text = "Last Change Time";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.SlateGray;
            this.label15.Location = new System.Drawing.Point(606, 562);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "v1.1.4";
            // 
            // textNWErrors
            // 
            this.textNWErrors.AutoSize = true;
            this.textNWErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNWErrors.ForeColor = System.Drawing.Color.Maroon;
            this.textNWErrors.Location = new System.Drawing.Point(318, 212);
            this.textNWErrors.Name = "textNWErrors";
            this.textNWErrors.Size = new System.Drawing.Size(19, 13);
            this.textNWErrors.TabIndex = 44;
            this.textNWErrors.Text = "...";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Navy;
            this.label21.Location = new System.Drawing.Point(243, 212);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 13);
            this.label21.TabIndex = 43;
            this.label21.Text = "NW Errors";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 587);
            this.Controls.Add(this.textNWErrors);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textLastChangeTime);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textTotalDownTime);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textRunningTime);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textMaxDownTime);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textLastScan);
            this.Controls.Add(this.textDownTime);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textIPChangeCount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textPreviousIP);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmdSearchDirectory);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.textElapsedms);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textMaximumCycles);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkSaveFile);
            this.Controls.Add(this.textFileLocation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textResponseTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboTarget);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboFrequency);
            this.Controls.Add(this.textLogs);
            this.Controls.Add(this.textEndTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textExternalIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textStartTime);
            this.Controls.Add(this.cmdStop);
            this.Controls.Add(this.cmdStart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "Form1";
            this.Text = "Network Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Label textStartTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label textExternalIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label textEndTime;
        private System.Windows.Forms.TextBox textLogs;
        private System.Windows.Forms.ComboBox comboFrequency;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboTarget;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label textStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label textResponseTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textFileLocation;
        private System.Windows.Forms.CheckBox checkSaveFile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textMaximumCycles;
        private System.ComponentModel.BackgroundWorker bw;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label textElapsedms;
        private System.Windows.Forms.Button cmdExit;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button cmdSearchDirectory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label textPreviousIP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label textIPChangeCount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label textDownTime;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label textLastScan;
        private System.Windows.Forms.Label textMaxDownTime;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label textRunningTime;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label textTotalDownTime;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label textLastChangeTime;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label textNWErrors;
        private System.Windows.Forms.Label label21;
    }
}

