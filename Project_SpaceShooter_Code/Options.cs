using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WF1_Training.Properties;

namespace WF1_Training
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();






            AudioManager.Play(@"F:\C#-AP\Project\Mini-Space-Shooter-Simulation\Music\Options.mp3");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            AudioManager.Stop();
        }
    }
}
