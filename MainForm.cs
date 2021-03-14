using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FiveThreeOne {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void nastaveníToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void btAbout_Click(object sender, EventArgs e) {
            MessageBox.Show("This is program for track and plan power lifting workouts\naccording to Jim Wendler's 5/3/1 protocol." +
                            "\n\nProgram calculates entire workout regime from one rep maxes\nof four main lifts (bench press, deadlift, squat, overhead press).");
        }

        private void MainForm_Load(object sender, EventArgs e) {
        }
    }
}
