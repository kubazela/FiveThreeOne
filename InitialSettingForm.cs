using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace FiveThreeOne {
    public partial class InitialSettingForm : Form {

        private string name;
        private double benchPressInit;
        private double squatInit;
        private double deadliftInit;
        private double ohpInit;
        Dictionary<string, string> lastValidText = new Dictionary<string, string>();
        public InitialSettingForm() {
            InitializeComponent();
        }
        private void btProceed_Click(object sender, EventArgs e) {
            try {
                name = tBoxName.Text;
                double benchPressValue = double.Parse(tBoxInitBenchPress.Text);
                double squatValue = double.Parse(tBoxInitSquat.Text);
                double deadliftValue = double.Parse(tBoxInitDeadlift.Text);
                double ohpValue = double.Parse(tBoxInitOHP.Text);

                benchPressInit = CalcLib.OrmCalc(benchPressValue, Convert.ToInt32(numInitBenchPress.Value));
                ohpInit = CalcLib.OrmCalc(ohpValue, Convert.ToInt32(numInitBenchPress.Value));
                squatInit = CalcLib.OrmCalc(squatValue, Convert.ToInt32(numInitBenchPress.Value));
                deadliftInit = CalcLib.OrmCalc(deadliftValue, Convert.ToInt32(numInitBenchPress.Value));
                try { 
                FileLib.SaveIntoFile(name, benchPressInit, squatInit, deadliftInit, ohpInit);
                }
                catch { }

                this.Hide();
                MainForm mainForm = new MainForm(name);
                mainForm.Closed += (s, args) => this.Close();
                mainForm.ShowDialog();

            }
            catch (FormatException) {
                MessageBox.Show("Enter valid data", "Error");
            }
        }
        private void tBox_TextChanged(object sender, EventArgs e) {
            TextBox tb = (TextBox)sender;
            string text = (tb.Text == "") ? "0" : tb.Text;

            if (tb.Text == "") {
                tb.Text = "0";
                tb.SelectionLength = 1;
            }

            try {
                int.Parse(tb.Text);
                if (!lastValidText.ContainsKey(tb.Name))
                    lastValidText.Add(tb.Name, tb.Text);
                else {
                    lastValidText[tb.Name] = tb.Text;
                    tb.Text = text;
                    tb.SelectionLength = 1;
                }
            }
            catch (Exception) {
                if (lastValidText.ContainsKey(tb.Name)) {
                    tb.Text = lastValidText[tb.Name].ToString();
                    tb.SelectionStart = (lastValidText[tb.Name].ToString()).Length;
                }
                else
                    lastValidText[tb.Name] = "";
            }
        }
    }
}
