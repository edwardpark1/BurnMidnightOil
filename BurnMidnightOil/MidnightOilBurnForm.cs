using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BurnMidnightOil
{
    public partial class MidnightOilBurnForm : Form
    {
        const int SIGNAL_DELAY = 2; //seconds
        const string PROGRESS_HEADER = "Progress Status: ";
        const string TIME_REMAIN_HEADER = "Time remain: ";
        private readonly Bitmap PlayImage = Properties.Resources.play;
        private readonly Bitmap PauseImage = Properties.Resources.pause;
        private readonly Bitmap StopImage = Properties.Resources.stop;

        private bool bPlayStatus = true;
        private bool bMouseMove = false;

        private ControlDimension ctrlDimension;

        public MidnightOilBurnForm()
        {
            InitializeComponent();
            RefreshLabels();
            bMouseMove = enableRadioButton.Checked;
        }

        private void RefreshLabels()
        {
            hoursRangeLabel.Text = $"{durHoursUpDown.Minimum} - {durHoursUpDown.Maximum}";
            minutesRangeLabel.Text = $"{durMinutesUpDown.Minimum} - {durMinutesUpDown.Maximum}";
            secondsRangeLabel.Text = $"{durSecondsUpDown.Minimum} - {durSecondsUpDown.Maximum}";

            Time mouseMinTime = new Time((int)mouseSecondsUpDown.Minimum);
            Time mouseMaxTime = new Time((int)mouseSecondsUpDown.Maximum);
            mouseMoveMinLabel.Text = $"Min: {GetCleanTime(mouseMinTime)}";
            mouseMoveMaxLabel.Text = $"Max: {GetCleanTime(mouseMaxTime)}";
        }

        public string GetCleanTime(Time time)
        {
            StringBuilder result = new StringBuilder();
            
            if(time.Hours > 0)
            {
                result.Append($"{time.Hours} hrs. ");
            }

            if (time.Minutes > 0)
            {
                result.Append($"{time.Minutes} mins. ");
            }

            result.Append($"{time.Seconds} secs. ");

            return result.ToString().Trim();
        }

        private void playPauseButton_Click(object sender, EventArgs e)
        {
            if (durHoursUpDown.Value + durMinutesUpDown.Value + durSecondsUpDown.Value <= 0)
            {
                display("Please provide a duration greater than 0");
                return;
            }

            if (bPlayStatus)
            {
                //play/ resume state
                playPauseButton.Image = PauseImage;
                bPlayStatus = false;
                if(!activeSessionBackgroundWorker.IsBusy)
                {
                    statusLabel.Text = PROGRESS_HEADER + "0%";
                    timeRemainLabel.Text = TIME_REMAIN_HEADER + GetCleanTime(new 
                        Time((int)durHoursUpDown.Value, (int)durMinutesUpDown.Value, (int)durSecondsUpDown.Value));
                    ReportToStatusLog("Started new active session");
                    TogglePropertyControls();
                    activeSessionBackgroundWorker.RunWorkerAsync();

                    //run mouse move if user enables the feature
                    if(bMouseMove)
                    {
                        //mousemove thread will run in tandem with active session
                        mouseMoveBackgroundWorker.RunWorkerAsync();
                    }
                    else
                    {
                        ReportToStatusLog("Mouse move not enabled");
                    }
                }
                else
                {
                    ReportToStatusLog("Continue current session");
                }
            }
            else
            {
                //pause state
                playPauseButton.Image = PlayImage;
                bPlayStatus = true;
            }
        }

        private void disableRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            mouseFreqAdjustPanel.Enabled = false;
            ToggleMouseMoveEnable();
        }

        private void enableRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            mouseFreqAdjustPanel.Enabled = true;
            ToggleMouseMoveEnable();
        }

        private void ToggleMouseMoveEnable()
        {
            if (enableRadioButton.Checked)
            {
                bMouseMove = true;
            }
            else
            {
                bMouseMove = false;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            bPlayStatus = false;
            playPauseButton.Image = PlayImage;

            if (!activeSessionBackgroundWorker.CancellationPending)
            {
                activeSessionBackgroundWorker.CancelAsync();
            }

            if (!mouseMoveBackgroundWorker.CancellationPending)
            {
                mouseMoveBackgroundWorker.CancelAsync();
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void opacityTrackBar_Scroll(object sender, EventArgs e)
        {
            opacityNumericUpDown.Value = opacityTrackBar.Value;
            Opacity = opacityTrackBar.Value / 100.00;
        }

        private void opacityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            opacityTrackBar.Value = (int)opacityNumericUpDown.Value;
            Opacity = opacityTrackBar.Value / 100.00;
        }

        private void TogglePropertyControls()
        {
            durationGroupBox.Enabled = !durationGroupBox.Enabled;
            mouseFreqGroupBox.Enabled = !mouseFreqGroupBox.Enabled;
            mainMenuStrip.Enabled = !mainMenuStrip.Enabled;
            windowGroupBox.Enabled = !windowGroupBox.Enabled;
            stopButton.Enabled = !stopButton.Enabled;
            resetPropertiesButton.Enabled = !resetPropertiesButton.Enabled;
        }

        public void ReportToStatusLog(string strMessage)
        {
            if(logTextBox.InvokeRequired)
            {
                Action safeWrite = delegate { ReportToStatusLog(strMessage); };
                logTextBox.Invoke(safeWrite);
            }
            else
            {
                int minBound, maxBound;
                string previousMessage;
                string currentMessage = $"[{DateTime.Now}]: {strMessage}\r\n";
                minBound = logTextBox.Text.IndexOf("]: ");
                maxBound = logTextBox.Text.IndexOf('\r');

                while (logTextBox.Text.Length + currentMessage.Length >= logTextBox.MaxLength)
                {
                    //truncate last full line
                    logTextBox.Text = logTextBox.Text.Remove(logTextBox.Text.Substring(0, logTextBox.Text.LastIndexOf('\n')).LastIndexOf('\n') + 1);
                }

                if (minBound > 0 && maxBound > minBound)
                {
                    previousMessage = logTextBox.Text.Substring(minBound+3, maxBound - minBound-3);
                    if(previousMessage == strMessage)
                    {
                        //change the timestamp if previous message is same
                        logTextBox.Text = logTextBox.Text.Remove(0, minBound+1);
                        logTextBox.Text = logTextBox.Text.Insert(0, $"[{DateTime.Now}]");
                    }
                    else
                    {
                        logTextBox.Text = $"{currentMessage}{logTextBox.Text}";
                    }
                }
                else
                {
                    logTextBox.Text = $"{currentMessage}{logTextBox.Text}";
                }
            }
        }

        public void ClearStatusLog()
        {
            logTextBox.Text = "";
        }

        private void clearLogsButton_Click(object sender, EventArgs e)
        {
            ClearStatusLog();
            display("Logs cleared!");
        }

        private void resetPropertiesButton_Click(object sender, EventArgs e)
        {
            durHoursUpDown.Value = 8;
            durMinutesUpDown.Value = 0;
            durSecondsUpDown.Value = 0;

            enableRadioButton.Checked = true;
            mouseSecondsUpDown.Value = 5;

            opacityTrackBar.Value = 100;
            opacityNumericUpDown.Value = 100;   
        }

        private void mouseMoveBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //delay between mouse movements
            Time delayTime = new Time((int)mouseSecondsUpDown.Value);
            MouseMoveSession mouseSession = new MouseMoveSession(ReportToStatusLog, delayTime);
            int counterDelayTime = 1;
            int totalDelayTime = mouseSession.DelayTime.TotalSeconds;

            ReportToStatusLog("Started Mouse Movement");
            while (activeSessionBackgroundWorker.IsBusy)
            {
                while (bPlayStatus)
                {
                    Thread.Sleep(500);
                }

                if (counterDelayTime % totalDelayTime == 0)
                {
                    FocusForm();
                    GetControlAbsoluteCoords(playPauseButton);
                    mouseSession.InvokeSession(ctrlDimension);
                    ReportToStatusLog("MOVING Mouse Movement");
                    //Debug
                    //ReportToStatusLog($"Mouse Moved to: {ctrlDimension.Origin.X} {ctrlDimension.Origin.Y} {ctrlDimension.Width} {ctrlDimension.Height}");
                    counterDelayTime = 0;
                }

                counterDelayTime++;
                Thread.Sleep(1000);
            }

            ReportToStatusLog("Ended Mouse Movement");
        }

        private void activeSessionBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //delay between signals
            Time delayTime = new Time(SIGNAL_DELAY);
            //Max duration
            Time activeTime = new Time((int)durHoursUpDown.Value,
                    (int)durMinutesUpDown.Value, (int)durSecondsUpDown.Value);

            ActiveSession activeSession = new ActiveSession(ReportToStatusLog, delayTime, activeTime);

            int totalMaxTime = activeSession.MaxTime.TotalSeconds;
            int totalDelayTime = activeSession.DelayTime.TotalSeconds;

            int counter = 0;
            int counterDelayTime = 0;
           
            do
            {
                while (bPlayStatus)
                {
                    ReportToStatusLog("Paused\n");
                    Thread.Sleep(500);
                }

                if (activeSessionBackgroundWorker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                if(counterDelayTime % totalDelayTime == 0)
                {
                    activeSession.InvokeSession();
                    counterDelayTime = 0;
                }

                Thread.Sleep(1000);
                counter++;
                counterDelayTime++;

                activeTime.TimePass();
                UpdateTimeRemainLabel(GetCleanTime(activeTime));
                int percent = (int)((totalMaxTime - activeSession.MaxTime.TotalSeconds) / (decimal)totalMaxTime * 100);
                activeSessionBackgroundWorker.ReportProgress(percent);
            } while (counter < totalMaxTime);
        }

        private void UpdateTimeRemainLabel(string val)
        {
            if(timeRemainLabel.InvokeRequired)
            {
                Action action = delegate { UpdateTimeRemainLabel(val); };
                timeRemainLabel.Invoke(action);
            }
            else
            {
                timeRemainLabel.Text = TIME_REMAIN_HEADER + val;
            }
        }

        private void activeSessionBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            statusLabel.Text = PROGRESS_HEADER + e.ProgressPercentage.ToString() + "%";
        }

        private void activeSessionBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                ReportToStatusLog("Current session aborted!");
                display("Session Aborted!");
            }
            else
            {
                display("Session Complete!");
            }
            progressBar.Value = 0;
            statusLabel.Text = PROGRESS_HEADER + "0%";
            bPlayStatus = true;
            TogglePropertyControls();
            playPauseButton.Image = PlayImage;
        }

        private void display(string text)
        {
            MessageBox.Show(text);
        }

        private void MidnightOilBurnForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //CloseReason prevents the popup window from firing this event twice
            if ((mouseMoveBackgroundWorker.IsBusy || activeSessionBackgroundWorker.IsBusy) 
                && e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("A session is currently active.\n Would you like to abort and close application?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    stopButton_Click(sender, e);
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                Application.Exit();
            }
        }

        //Force the app to be focused
        public void FocusForm()
        {
            if(this.InvokeRequired)
            {
                Action safeFormFocus = delegate { FocusForm(); };
                this.Invoke(safeFormFocus);
            }
            else
            {
                this.TopMost = true;
                if (!this.Focused)
                {
                    this.Activate();
                }
                this.WindowState = FormWindowState.Normal;
            }
        }

        public void GetControlAbsoluteCoords(Control ctrl)
        {
            if (ctrl.InvokeRequired)
            {
                Action safeGetCoords = delegate 
                {
                    ctrlDimension = new ControlDimension(ctrl.PointToScreen(Point.Empty), 
                        ctrl.Width, ctrl.Height);
                };
                
                ctrl.Invoke(safeGetCoords);
            }
            else
            {
                ctrlDimension = new ControlDimension(ctrl.PointToScreen(Point.Empty),
                         ctrl.Width, ctrl.Height);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(AboutForm aboutForm = new AboutForm())
            {
                aboutForm.ShowDialog();
            }
        }

        private void helpToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            using (HelpForm helpForm = new HelpForm())
            {
                helpForm.ShowDialog();
            }
        }
    }
}
