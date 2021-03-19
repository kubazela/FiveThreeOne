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
using ClassLibrary;

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
            lbBenchPressORM.Text = root.SelectSingleNode("ORMBenchPress").InnerText;
            lbSquatORM.Text = root.SelectSingleNode("ORMSquat").InnerText;
            lbDeadliftORM.Text = root.SelectSingleNode("ORMDeadLift").InnerText;
            lbOhpORM.Text = root.SelectSingleNode("ORMOhp").InnerText;

            lbBenchPressCycle.Text = root.SelectSingleNode("CycleBenchPress").InnerText;
            lbSquatCycle.Text = root.SelectSingleNode("CycleBenchPress").InnerText;
            lbDeadliftCycle.Text = root.SelectSingleNode("CycleDeadLift").InnerText;
            lbOhpCycle.Text = root.SelectSingleNode("CycleOhp").InnerText;

            lbBenchPressWeek.Text = root.SelectSingleNode("WeekBenchPress").InnerText;
            lbSquatWeek.Text = root.SelectSingleNode("WeekBenchPress").InnerText;
            lbDeadliftWeek.Text = root.SelectSingleNode("WeekDeadLift").InnerText;
            lbOhpWeek.Text = root.SelectSingleNode("WeekOhp").InnerText;

            lbBenchPressLastDate.Text = root.SelectSingleNode("LastDateBenchPress").InnerText;
            lbSquatLastDate.Text = root.SelectSingleNode("LastDateBenchPress").InnerText;
            lbDeadliftLastDate.Text = root.SelectSingleNode("LastDateDeadLift").InnerText;
            lbOhpLastDate.Text = root.SelectSingleNode("LastDateOhp").InnerText;
        }

        private void btBenchStart_Click(object sender, EventArgs e) {
            WorkoutForm workoutForm = new WorkoutForm(name, "BenchPress");
            workoutForm.ShowDialog();
        }
        
        private void btSquatStart_Click(object sender, EventArgs e) {
            WorkoutForm workoutForm = new WorkoutForm(name, "Squat");
            workoutForm.ShowDialog();
        }

        private void btDeadliftStart_Click(object sender, EventArgs e) {
            WorkoutForm workoutForm = new WorkoutForm(name, "DeadLift");
            workoutForm.ShowDialog();
        }

        private void btOhpStart_Click(object sender, EventArgs e) {
            WorkoutForm workoutForm = new WorkoutForm(name, "Ohp");
            workoutForm.ShowDialog();
        }
    }
}
