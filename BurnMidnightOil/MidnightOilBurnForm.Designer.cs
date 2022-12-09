namespace BurnMidnightOil
{
    partial class MidnightOilBurnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MidnightOilBurnForm));
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.logHeaderLabel = new System.Windows.Forms.Label();
            this.durationGroupBox = new System.Windows.Forms.GroupBox();
            this.durationPanel = new System.Windows.Forms.Panel();
            this.secondsRangeLabel = new System.Windows.Forms.Label();
            this.minutesRangeLabel = new System.Windows.Forms.Label();
            this.hoursRangeLabel = new System.Windows.Forms.Label();
            this.durSecondsLabel = new System.Windows.Forms.Label();
            this.durMinutesLabel = new System.Windows.Forms.Label();
            this.durHoursLabel = new System.Windows.Forms.Label();
            this.durSecondsUpDown = new System.Windows.Forms.NumericUpDown();
            this.durMinutesUpDown = new System.Windows.Forms.NumericUpDown();
            this.durHoursUpDown = new System.Windows.Forms.NumericUpDown();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.statusLabel = new System.Windows.Forms.Label();
            this.mouseFreqGroupBox = new System.Windows.Forms.GroupBox();
            this.mouseFreqAdjustPanel = new System.Windows.Forms.Panel();
            this.mouseMoveMinLabel = new System.Windows.Forms.Label();
            this.mouseMovePromptLabel = new System.Windows.Forms.Label();
            this.mouseMoveMaxLabel = new System.Windows.Forms.Label();
            this.mouseSecondsUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.disableRadioButton = new System.Windows.Forms.RadioButton();
            this.enableRadioButton = new System.Windows.Forms.RadioButton();
            this.propertiesLabel = new System.Windows.Forms.Label();
            this.progressGroupBox = new System.Windows.Forms.GroupBox();
            this.timeRemainLabel = new System.Windows.Forms.Label();
            this.playPauseButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.clearLogsButton = new System.Windows.Forms.Button();
            this.resetPropertiesButton = new System.Windows.Forms.Button();
            this.windowGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.opacityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.opacityTrackBar = new System.Windows.Forms.TrackBar();
            this.opacityLabel = new System.Windows.Forms.Label();
            this.activeSessionBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.mouseMoveBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.durationGroupBox.SuspendLayout();
            this.durationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.durSecondsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durMinutesUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durHoursUpDown)).BeginInit();
            this.mouseFreqGroupBox.SuspendLayout();
            this.mouseFreqAdjustPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mouseSecondsUpDown)).BeginInit();
            this.progressGroupBox.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.windowGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacityTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // logTextBox
            // 
            this.logTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.logTextBox.Location = new System.Drawing.Point(12, 65);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logTextBox.Size = new System.Drawing.Size(287, 453);
            this.logTextBox.TabIndex = 0;
            // 
            // logHeaderLabel
            // 
            this.logHeaderLabel.AutoSize = true;
            this.logHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logHeaderLabel.Location = new System.Drawing.Point(8, 38);
            this.logHeaderLabel.Name = "logHeaderLabel";
            this.logHeaderLabel.Size = new System.Drawing.Size(102, 20);
            this.logHeaderLabel.TabIndex = 1;
            this.logHeaderLabel.Text = "Status Log:";
            // 
            // durationGroupBox
            // 
            this.durationGroupBox.BackColor = System.Drawing.Color.DarkGray;
            this.durationGroupBox.Controls.Add(this.durationPanel);
            this.durationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationGroupBox.Location = new System.Drawing.Point(313, 65);
            this.durationGroupBox.Name = "durationGroupBox";
            this.durationGroupBox.Size = new System.Drawing.Size(399, 134);
            this.durationGroupBox.TabIndex = 6;
            this.durationGroupBox.TabStop = false;
            this.durationGroupBox.Text = "Duration: How long to keep PC active";
            // 
            // durationPanel
            // 
            this.durationPanel.Controls.Add(this.secondsRangeLabel);
            this.durationPanel.Controls.Add(this.minutesRangeLabel);
            this.durationPanel.Controls.Add(this.hoursRangeLabel);
            this.durationPanel.Controls.Add(this.durSecondsLabel);
            this.durationPanel.Controls.Add(this.durMinutesLabel);
            this.durationPanel.Controls.Add(this.durHoursLabel);
            this.durationPanel.Controls.Add(this.durSecondsUpDown);
            this.durationPanel.Controls.Add(this.durMinutesUpDown);
            this.durationPanel.Controls.Add(this.durHoursUpDown);
            this.durationPanel.Location = new System.Drawing.Point(99, 23);
            this.durationPanel.Name = "durationPanel";
            this.durationPanel.Size = new System.Drawing.Size(285, 100);
            this.durationPanel.TabIndex = 2;
            // 
            // secondsRangeLabel
            // 
            this.secondsRangeLabel.AutoSize = true;
            this.secondsRangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsRangeLabel.Location = new System.Drawing.Point(204, 76);
            this.secondsRangeLabel.Name = "secondsRangeLabel";
            this.secondsRangeLabel.Size = new System.Drawing.Size(34, 13);
            this.secondsRangeLabel.TabIndex = 8;
            this.secondsRangeLabel.Text = "0 - 59";
            // 
            // minutesRangeLabel
            // 
            this.minutesRangeLabel.AutoSize = true;
            this.minutesRangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesRangeLabel.Location = new System.Drawing.Point(204, 46);
            this.minutesRangeLabel.Name = "minutesRangeLabel";
            this.minutesRangeLabel.Size = new System.Drawing.Size(34, 13);
            this.minutesRangeLabel.TabIndex = 7;
            this.minutesRangeLabel.Text = "0 - 59";
            // 
            // hoursRangeLabel
            // 
            this.hoursRangeLabel.AutoSize = true;
            this.hoursRangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursRangeLabel.Location = new System.Drawing.Point(204, 17);
            this.hoursRangeLabel.Name = "hoursRangeLabel";
            this.hoursRangeLabel.Size = new System.Drawing.Size(34, 13);
            this.hoursRangeLabel.TabIndex = 6;
            this.hoursRangeLabel.Text = "0 - 23";
            // 
            // durSecondsLabel
            // 
            this.durSecondsLabel.AutoSize = true;
            this.durSecondsLabel.Location = new System.Drawing.Point(10, 72);
            this.durSecondsLabel.Name = "durSecondsLabel";
            this.durSecondsLabel.Size = new System.Drawing.Size(81, 18);
            this.durSecondsLabel.TabIndex = 5;
            this.durSecondsLabel.Text = "Second(s):";
            // 
            // durMinutesLabel
            // 
            this.durMinutesLabel.AutoSize = true;
            this.durMinutesLabel.Location = new System.Drawing.Point(10, 42);
            this.durMinutesLabel.Name = "durMinutesLabel";
            this.durMinutesLabel.Size = new System.Drawing.Size(74, 18);
            this.durMinutesLabel.TabIndex = 4;
            this.durMinutesLabel.Text = "Minute(s):";
            // 
            // durHoursLabel
            // 
            this.durHoursLabel.AutoSize = true;
            this.durHoursLabel.Location = new System.Drawing.Point(10, 12);
            this.durHoursLabel.Name = "durHoursLabel";
            this.durHoursLabel.Size = new System.Drawing.Size(63, 18);
            this.durHoursLabel.TabIndex = 3;
            this.durHoursLabel.Text = "Hour(s):";
            // 
            // durSecondsUpDown
            // 
            this.durSecondsUpDown.Location = new System.Drawing.Point(116, 70);
            this.durSecondsUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.durSecondsUpDown.Name = "durSecondsUpDown";
            this.durSecondsUpDown.Size = new System.Drawing.Size(82, 24);
            this.durSecondsUpDown.TabIndex = 2;
            // 
            // durMinutesUpDown
            // 
            this.durMinutesUpDown.Location = new System.Drawing.Point(116, 40);
            this.durMinutesUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.durMinutesUpDown.Name = "durMinutesUpDown";
            this.durMinutesUpDown.Size = new System.Drawing.Size(82, 24);
            this.durMinutesUpDown.TabIndex = 1;
            // 
            // durHoursUpDown
            // 
            this.durHoursUpDown.Location = new System.Drawing.Point(116, 10);
            this.durHoursUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.durHoursUpDown.Name = "durHoursUpDown";
            this.durHoursUpDown.Size = new System.Drawing.Size(82, 24);
            this.durHoursUpDown.TabIndex = 0;
            this.durHoursUpDown.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.DimGray;
            this.progressBar.Location = new System.Drawing.Point(99, 34);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(285, 23);
            this.progressBar.TabIndex = 7;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(96, 14);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(117, 15);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Progress Status: 0%";
            // 
            // mouseFreqGroupBox
            // 
            this.mouseFreqGroupBox.BackColor = System.Drawing.Color.DarkGray;
            this.mouseFreqGroupBox.Controls.Add(this.mouseFreqAdjustPanel);
            this.mouseFreqGroupBox.Controls.Add(this.disableRadioButton);
            this.mouseFreqGroupBox.Controls.Add(this.enableRadioButton);
            this.mouseFreqGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouseFreqGroupBox.Location = new System.Drawing.Point(313, 205);
            this.mouseFreqGroupBox.Name = "mouseFreqGroupBox";
            this.mouseFreqGroupBox.Size = new System.Drawing.Size(399, 138);
            this.mouseFreqGroupBox.TabIndex = 9;
            this.mouseFreqGroupBox.TabStop = false;
            this.mouseFreqGroupBox.Text = "Auto-Mouse Movement";
            // 
            // mouseFreqAdjustPanel
            // 
            this.mouseFreqAdjustPanel.Controls.Add(this.mouseMoveMinLabel);
            this.mouseFreqAdjustPanel.Controls.Add(this.mouseMovePromptLabel);
            this.mouseFreqAdjustPanel.Controls.Add(this.mouseMoveMaxLabel);
            this.mouseFreqAdjustPanel.Controls.Add(this.mouseSecondsUpDown);
            this.mouseFreqAdjustPanel.Controls.Add(this.label1);
            this.mouseFreqAdjustPanel.Location = new System.Drawing.Point(99, 23);
            this.mouseFreqAdjustPanel.Name = "mouseFreqAdjustPanel";
            this.mouseFreqAdjustPanel.Size = new System.Drawing.Size(285, 100);
            this.mouseFreqAdjustPanel.TabIndex = 3;
            // 
            // mouseMoveMinLabel
            // 
            this.mouseMoveMinLabel.AutoSize = true;
            this.mouseMoveMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouseMoveMinLabel.Location = new System.Drawing.Point(204, 37);
            this.mouseMoveMinLabel.Name = "mouseMoveMinLabel";
            this.mouseMoveMinLabel.Size = new System.Drawing.Size(67, 13);
            this.mouseMoveMinLabel.TabIndex = 11;
            this.mouseMoveMinLabel.Text = "Min: 30 secs";
            // 
            // mouseMovePromptLabel
            // 
            this.mouseMovePromptLabel.AutoSize = true;
            this.mouseMovePromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouseMovePromptLabel.Location = new System.Drawing.Point(10, 13);
            this.mouseMovePromptLabel.Name = "mouseMovePromptLabel";
            this.mouseMovePromptLabel.Size = new System.Drawing.Size(169, 13);
            this.mouseMovePromptLabel.TabIndex = 10;
            this.mouseMovePromptLabel.Text = "Delays between mouse movement";
            // 
            // mouseMoveMaxLabel
            // 
            this.mouseMoveMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mouseMoveMaxLabel.Location = new System.Drawing.Point(204, 58);
            this.mouseMoveMaxLabel.Name = "mouseMoveMaxLabel";
            this.mouseMoveMaxLabel.Size = new System.Drawing.Size(78, 35);
            this.mouseMoveMaxLabel.TabIndex = 12;
            this.mouseMoveMaxLabel.Text = "Max: 5 mins";
            // 
            // mouseSecondsUpDown
            // 
            this.mouseSecondsUpDown.Location = new System.Drawing.Point(116, 47);
            this.mouseSecondsUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.mouseSecondsUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.mouseSecondsUpDown.Name = "mouseSecondsUpDown";
            this.mouseSecondsUpDown.Size = new System.Drawing.Size(82, 24);
            this.mouseSecondsUpDown.TabIndex = 9;
            this.mouseSecondsUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Second(s):";
            // 
            // disableRadioButton
            // 
            this.disableRadioButton.AutoSize = true;
            this.disableRadioButton.Location = new System.Drawing.Point(14, 58);
            this.disableRadioButton.Name = "disableRadioButton";
            this.disableRadioButton.Size = new System.Drawing.Size(75, 22);
            this.disableRadioButton.TabIndex = 1;
            this.disableRadioButton.Text = "Disable";
            this.mainToolTip.SetToolTip(this.disableRadioButton, "Do not auto-move mouse cursor");
            this.disableRadioButton.UseVisualStyleBackColor = true;
            this.disableRadioButton.CheckedChanged += new System.EventHandler(this.disableRadioButton_CheckedChanged);
            // 
            // enableRadioButton
            // 
            this.enableRadioButton.AutoSize = true;
            this.enableRadioButton.Checked = true;
            this.enableRadioButton.Location = new System.Drawing.Point(14, 30);
            this.enableRadioButton.Name = "enableRadioButton";
            this.enableRadioButton.Size = new System.Drawing.Size(71, 22);
            this.enableRadioButton.TabIndex = 0;
            this.enableRadioButton.TabStop = true;
            this.enableRadioButton.Text = "Enable";
            this.mainToolTip.SetToolTip(this.enableRadioButton, "Mouse will randomly move within the Play/Pause button");
            this.enableRadioButton.UseVisualStyleBackColor = true;
            this.enableRadioButton.CheckedChanged += new System.EventHandler(this.enableRadioButton_CheckedChanged);
            // 
            // propertiesLabel
            // 
            this.propertiesLabel.AutoSize = true;
            this.propertiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertiesLabel.Location = new System.Drawing.Point(309, 38);
            this.propertiesLabel.Name = "propertiesLabel";
            this.propertiesLabel.Size = new System.Drawing.Size(91, 20);
            this.propertiesLabel.TabIndex = 10;
            this.propertiesLabel.Text = "Properties";
            // 
            // progressGroupBox
            // 
            this.progressGroupBox.BackColor = System.Drawing.Color.DarkGray;
            this.progressGroupBox.Controls.Add(this.timeRemainLabel);
            this.progressGroupBox.Controls.Add(this.playPauseButton);
            this.progressGroupBox.Controls.Add(this.stopButton);
            this.progressGroupBox.Controls.Add(this.progressBar);
            this.progressGroupBox.Controls.Add(this.statusLabel);
            this.progressGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressGroupBox.Location = new System.Drawing.Point(313, 435);
            this.progressGroupBox.Name = "progressGroupBox";
            this.progressGroupBox.Size = new System.Drawing.Size(399, 83);
            this.progressGroupBox.TabIndex = 11;
            this.progressGroupBox.TabStop = false;
            this.progressGroupBox.Text = "Progress";
            // 
            // timeRemainLabel
            // 
            this.timeRemainLabel.AutoSize = true;
            this.timeRemainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeRemainLabel.Location = new System.Drawing.Point(96, 63);
            this.timeRemainLabel.Name = "timeRemainLabel";
            this.timeRemainLabel.Size = new System.Drawing.Size(67, 13);
            this.timeRemainLabel.TabIndex = 9;
            this.timeRemainLabel.Text = "Time remain:";
            // 
            // playPauseButton
            // 
            this.playPauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playPauseButton.Image = ((System.Drawing.Image)(resources.GetObject("playPauseButton.Image")));
            this.playPauseButton.Location = new System.Drawing.Point(9, 25);
            this.playPauseButton.Name = "playPauseButton";
            this.playPauseButton.Size = new System.Drawing.Size(40, 40);
            this.playPauseButton.TabIndex = 2;
            this.mainToolTip.SetToolTip(this.playPauseButton, "Start Active Session");
            this.playPauseButton.UseVisualStyleBackColor = true;
            this.playPauseButton.Click += new System.EventHandler(this.playPauseButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
            this.stopButton.Location = new System.Drawing.Point(53, 25);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(40, 40);
            this.stopButton.TabIndex = 4;
            this.mainToolTip.SetToolTip(this.stopButton, "Stop Active Session");
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.Color.SlateGray;
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(723, 24);
            this.mainMenuStrip.TabIndex = 12;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.generalToolStripMenuItem.Text = "General";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem2,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // helpToolStripMenuItem2
            // 
            this.helpToolStripMenuItem2.Name = "helpToolStripMenuItem2";
            this.helpToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem2.Text = "Help";
            this.helpToolStripMenuItem2.Click += new System.EventHandler(this.helpToolStripMenuItem2_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // clearLogsButton
            // 
            this.clearLogsButton.Location = new System.Drawing.Point(224, 38);
            this.clearLogsButton.Name = "clearLogsButton";
            this.clearLogsButton.Size = new System.Drawing.Size(75, 23);
            this.clearLogsButton.TabIndex = 14;
            this.clearLogsButton.Text = "Clear Logs";
            this.mainToolTip.SetToolTip(this.clearLogsButton, "Clears Status Log content");
            this.clearLogsButton.UseVisualStyleBackColor = true;
            this.clearLogsButton.Click += new System.EventHandler(this.clearLogsButton_Click);
            // 
            // resetPropertiesButton
            // 
            this.resetPropertiesButton.Location = new System.Drawing.Point(651, 36);
            this.resetPropertiesButton.Name = "resetPropertiesButton";
            this.resetPropertiesButton.Size = new System.Drawing.Size(61, 23);
            this.resetPropertiesButton.TabIndex = 15;
            this.resetPropertiesButton.Text = "Reset...";
            this.mainToolTip.SetToolTip(this.resetPropertiesButton, "Reset property values to default");
            this.resetPropertiesButton.UseVisualStyleBackColor = true;
            this.resetPropertiesButton.Click += new System.EventHandler(this.resetPropertiesButton_Click);
            // 
            // windowGroupBox
            // 
            this.windowGroupBox.BackColor = System.Drawing.Color.DarkGray;
            this.windowGroupBox.Controls.Add(this.panel1);
            this.windowGroupBox.Controls.Add(this.opacityLabel);
            this.windowGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowGroupBox.Location = new System.Drawing.Point(313, 350);
            this.windowGroupBox.Name = "windowGroupBox";
            this.windowGroupBox.Size = new System.Drawing.Size(399, 79);
            this.windowGroupBox.TabIndex = 13;
            this.windowGroupBox.TabStop = false;
            this.windowGroupBox.Text = "Window Appearance";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.opacityNumericUpDown);
            this.panel1.Controls.Add(this.opacityTrackBar);
            this.panel1.Location = new System.Drawing.Point(99, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 50);
            this.panel1.TabIndex = 2;
            // 
            // opacityNumericUpDown
            // 
            this.opacityNumericUpDown.Location = new System.Drawing.Point(146, 13);
            this.opacityNumericUpDown.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.opacityNumericUpDown.Name = "opacityNumericUpDown";
            this.opacityNumericUpDown.Size = new System.Drawing.Size(51, 24);
            this.opacityNumericUpDown.TabIndex = 3;
            this.opacityNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.opacityNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.opacityNumericUpDown.ValueChanged += new System.EventHandler(this.opacityNumericUpDown_ValueChanged);
            // 
            // opacityTrackBar
            // 
            this.opacityTrackBar.Location = new System.Drawing.Point(13, 3);
            this.opacityTrackBar.Maximum = 100;
            this.opacityTrackBar.Minimum = 20;
            this.opacityTrackBar.Name = "opacityTrackBar";
            this.opacityTrackBar.Size = new System.Drawing.Size(127, 45);
            this.opacityTrackBar.TabIndex = 0;
            this.opacityTrackBar.TickFrequency = 10;
            this.opacityTrackBar.Value = 100;
            this.opacityTrackBar.Scroll += new System.EventHandler(this.opacityTrackBar_Scroll);
            // 
            // opacityLabel
            // 
            this.opacityLabel.AutoSize = true;
            this.opacityLabel.Location = new System.Drawing.Point(14, 35);
            this.opacityLabel.Name = "opacityLabel";
            this.opacityLabel.Size = new System.Drawing.Size(75, 18);
            this.opacityLabel.TabIndex = 1;
            this.opacityLabel.Text = "Opacity%:";
            // 
            // activeSessionBackgroundWorker
            // 
            this.activeSessionBackgroundWorker.WorkerReportsProgress = true;
            this.activeSessionBackgroundWorker.WorkerSupportsCancellation = true;
            this.activeSessionBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.activeSessionBackgroundWorker_DoWork);
            this.activeSessionBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.activeSessionBackgroundWorker_ProgressChanged);
            this.activeSessionBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.activeSessionBackgroundWorker_RunWorkerCompleted);
            // 
            // mouseMoveBackgroundWorker
            // 
            this.mouseMoveBackgroundWorker.WorkerSupportsCancellation = true;
            this.mouseMoveBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.mouseMoveBackgroundWorker_DoWork);
            // 
            // MidnightOilBurnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(723, 530);
            this.Controls.Add(this.resetPropertiesButton);
            this.Controls.Add(this.clearLogsButton);
            this.Controls.Add(this.windowGroupBox);
            this.Controls.Add(this.progressGroupBox);
            this.Controls.Add(this.propertiesLabel);
            this.Controls.Add(this.mouseFreqGroupBox);
            this.Controls.Add(this.durationGroupBox);
            this.Controls.Add(this.logHeaderLabel);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MidnightOilBurnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Midnight Oil Burn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MidnightOilBurnForm_FormClosing);
            this.durationGroupBox.ResumeLayout(false);
            this.durationPanel.ResumeLayout(false);
            this.durationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.durSecondsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durMinutesUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durHoursUpDown)).EndInit();
            this.mouseFreqGroupBox.ResumeLayout(false);
            this.mouseFreqGroupBox.PerformLayout();
            this.mouseFreqAdjustPanel.ResumeLayout(false);
            this.mouseFreqAdjustPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mouseSecondsUpDown)).EndInit();
            this.progressGroupBox.ResumeLayout(false);
            this.progressGroupBox.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.windowGroupBox.ResumeLayout(false);
            this.windowGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opacityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacityTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Label logHeaderLabel;
        private System.Windows.Forms.Button playPauseButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.GroupBox durationGroupBox;
        private System.Windows.Forms.Panel durationPanel;
        private System.Windows.Forms.Label durMinutesLabel;
        private System.Windows.Forms.Label durHoursLabel;
        private System.Windows.Forms.NumericUpDown durSecondsUpDown;
        private System.Windows.Forms.NumericUpDown durMinutesUpDown;
        private System.Windows.Forms.NumericUpDown durHoursUpDown;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label durSecondsLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.GroupBox mouseFreqGroupBox;
        private System.Windows.Forms.RadioButton disableRadioButton;
        private System.Windows.Forms.RadioButton enableRadioButton;
        private System.Windows.Forms.Label propertiesLabel;
        private System.Windows.Forms.Panel mouseFreqAdjustPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown mouseSecondsUpDown;
        private System.Windows.Forms.GroupBox progressGroupBox;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolTip mainToolTip;
        private System.Windows.Forms.Label mouseMovePromptLabel;
        private System.Windows.Forms.Label mouseMoveMinLabel;
        private System.Windows.Forms.Label mouseMoveMaxLabel;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox windowGroupBox;
        private System.Windows.Forms.Label opacityLabel;
        private System.Windows.Forms.TrackBar opacityTrackBar;
        private System.Windows.Forms.NumericUpDown opacityNumericUpDown;
        private System.Windows.Forms.Button clearLogsButton;
        private System.Windows.Forms.Button resetPropertiesButton;
        private System.ComponentModel.BackgroundWorker activeSessionBackgroundWorker;
        private System.Windows.Forms.Label hoursRangeLabel;
        private System.Windows.Forms.Label secondsRangeLabel;
        private System.Windows.Forms.Label minutesRangeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker mouseMoveBackgroundWorker;
        private System.Windows.Forms.Label timeRemainLabel;
    }
}

