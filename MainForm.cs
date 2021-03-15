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
using System.IO;
using System.Xml;

namespace FiveThreeOne {
    public partial class MainForm : Form {
        public string name;
        public MainForm(string name) {
            this.name = name;
            InitializeComponent();
        }

        private void nastaveníToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void btAbout_Click(object sender, EventArgs e) {
            MessageBox.Show("This is program for track and plan power lifting workouts\naccording to Jim Wendler's 5/3/1 protocol." +
                            "\n\nProgram calculates entire workout regime from one rep maxes\nof four main lifts (bench press, deadlift, squat, overhead press).");
        }

        private void MainForm_Load(object sender, EventArgs e) {
            lbSignedUpUser.Text = "User: " + name;
            LoadMainFormData();
        }
        public void LoadMainFormData() {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(name + ".xml");
            XmlElement root = xmlDoc.DocumentElement;
            lbBenchPressORM.Text = root.SelectSingleNode("ORMbenchPress").InnerText;
            lbSquatORM.Text = root.SelectSingleNode("ORMsquat").InnerText;
            lbDeadliftORM.Text = root.SelectSingleNode("ORMdeadLift").InnerText;
            lbOhpORM.Text = root.SelectSingleNode("ORMohp").InnerText;

            lbBenchPressCycleWeek.Text = root.SelectSingleNode("CycleWeekBenchPress").InnerText;
            lbSquatCycleWeek.Text = root.SelectSingleNode("CycleWeekBenchPress").InnerText;
            lbDeadliftCycleWeek.Text = root.SelectSingleNode("CycleWeekDeadLift").InnerText;
            lbOhpCycleWeek.Text = root.SelectSingleNode("CycleWeekOHP").InnerText;

            lbBenchPressLastDate.Text = root.SelectSingleNode("LastDateBenchPress").InnerText;
            lbSquatLastDate.Text = root.SelectSingleNode("LastDateBenchPress").InnerText;
            lbDeadliftLastDate.Text = root.SelectSingleNode("LastDateDeadLift").InnerText;
            lbOhpLastDate.Text = root.SelectSingleNode("LastDateOHP").InnerText;
        }
    }
}
