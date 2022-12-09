using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurnMidnightOil
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            aboutVersionLabel.Text = "Version: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            appNameLabel.Text = "App. Name: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
