using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ClassLibrary;

namespace FiveThreeOne {
    public partial class WorkoutForm : Form {
        private string name;
        private string exercise;
        private double orm;
        private int week;
        private int cycle;
        public WorkoutForm(string name, string exercise) {
            this.name = name;
            this.exercise = exercise;
            InitializeComponent();
            LoadData();
        }
        
        private void WorkoutForm_Load(object sender, EventArgs e) {
            orm = CalcLib.getORMValue(name, exercise);
            LoadData();
        }
        private void LoadData() {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(name + ".xml");
            XmlElement root = xmlDoc.DocumentElement;
            try {
                week = Convert.ToInt32(root.SelectSingleNode($"Week{exercise}").InnerText);
                cycle = Convert.ToInt32(root.SelectSingleNode($"Cycle{exercise}").InnerText);
            }
            catch (FormatException) {
                root.SelectSingleNode($"Week{exercise}").InnerText = "1";
                root.SelectSingleNode($"Cycle{exercise}").InnerText = "1";
                week = Convert.ToInt32(root.SelectSingleNode($"Week{exercise}").InnerText);
                cycle = Convert.ToInt32(root.SelectSingleNode($"Cycle{exercise}").InnerText);
            }
            switch (week) {
                case 1:
                    loadFirstWeek();
                    break;
                case 2:
                    loadSecondWeek();
                    break;
                case 3:
                    loadThirdWeek();
                    break;
            }
        }
        public void loadFirstWeek() {
            numWarmUpCount1.Value = 5;
            numWarmUpCount2.Value = 5;
            numWarmUpCount3.Value = 5;

            numWarmUpWeight1.Value = (decimal)CalcLib.getWeight(orm * 0.40);
            numWarmUpWeight2.Value = (decimal)CalcLib.getWeight(orm * 0.50);
            numWarmUpWeight3.Value = (decimal)CalcLib.getWeight(orm * 0.60);

            numMainCount1.Value = 5;
            numMainCount2.Value = 5;
            numMainCount3.Value = 5;
              
            numMainWeight1.Value = (decimal)CalcLib.getWeight(orm * 0.65);
            numMainWeight2.Value = (decimal)CalcLib.getWeight(orm * 0.75);
            numMainWeight3.Value = (decimal)CalcLib.getWeight(orm * 0.85);

            numBBBCount1.Value = 5;
            numBBBCount2.Value = 5;
            numBBBCount3.Value = 5;
            numBBBCount4.Value = 5;
            numBBBCount5.Value = 5;

            numBBBWeight1.Value = (decimal)CalcLib.getWeight(orm * 0.65);
            numBBBWeight2.Value = (decimal)CalcLib.getWeight(orm * 0.65);
            numBBBWeight3.Value = (decimal)CalcLib.getWeight(orm * 0.65);
            numBBBWeight4.Value = (decimal)CalcLib.getWeight(orm * 0.65);
            numBBBWeight5.Value = (decimal)CalcLib.getWeight(orm * 0.65);
        }
        public void loadSecondWeek() {
            numWarmUpCount1.Value = 5;
            numWarmUpCount2.Value = 5;
            numWarmUpCount3.Value = 5;

            numWarmUpWeight1.Value = (decimal)CalcLib.getWeight(orm * 0.40);
            numWarmUpWeight2.Value = (decimal)CalcLib.getWeight(orm * 0.50);
            numWarmUpWeight3.Value = (decimal)CalcLib.getWeight(orm * 0.60);

            numMainCount1.Value = 3;
            numMainCount2.Value = 3;
            numMainCount3.Value = 3;

            numMainWeight1.Value = (decimal)CalcLib.getWeight(orm * 0.70);
            numMainWeight2.Value = (decimal)CalcLib.getWeight(orm * 0.80);
            numMainWeight3.Value = (decimal)CalcLib.getWeight(orm * 0.90);

            numBBBCount1.Value = 5;
            numBBBCount2.Value = 5;
            numBBBCount3.Value = 5;
            numBBBCount4.Value = 5;
            numBBBCount5.Value = 5;

            numBBBWeight1.Value = (decimal)CalcLib.getWeight(orm * 0.65);
            numBBBWeight2.Value = (decimal)CalcLib.getWeight(orm * 0.65);
            numBBBWeight3.Value = (decimal)CalcLib.getWeight(orm * 0.65);
            numBBBWeight4.Value = (decimal)CalcLib.getWeight(orm * 0.65);
            numBBBWeight5.Value = (decimal)CalcLib.getWeight(orm * 0.65);
        }
        public void loadThirdWeek() {
            numWarmUpCount1.Value = 5;
            numWarmUpCount2.Value = 5;
            numWarmUpCount3.Value = 5;

            numWarmUpWeight1.Value = (decimal)CalcLib.getWeight(orm * 0.40);
            numWarmUpWeight2.Value = (decimal)CalcLib.getWeight(orm * 0.50);
            numWarmUpWeight3.Value = (decimal)CalcLib.getWeight(orm * 0.60);

            numMainCount1.Value = 5;
            numMainCount2.Value = 3;
            numMainCount3.Value = 1;

            numMainWeight1.Value = (decimal)CalcLib.getWeight(orm * 0.75);
            numMainWeight2.Value = (decimal)CalcLib.getWeight(orm * 0.85);
            numMainWeight3.Value = (decimal)CalcLib.getWeight(orm * 0.95);

            numBBBCount1.Value = 5;
            numBBBCount2.Value = 5;
            numBBBCount3.Value = 5;
            numBBBCount4.Value = 5;
            numBBBCount5.Value = 5;

            numBBBWeight1.Value = (decimal)CalcLib.getWeight(orm * 0.65);
            numBBBWeight2.Value = (decimal)CalcLib.getWeight(orm * 0.65);
            numBBBWeight3.Value = (decimal)CalcLib.getWeight(orm * 0.65);
            numBBBWeight4.Value = (decimal)CalcLib.getWeight(orm * 0.65);
            numBBBWeight5.Value = (decimal)CalcLib.getWeight(orm * 0.65);
        }

        private void btEndWorkout_Click(object sender, EventArgs e) {
            double potentORM = CalcLib.OrmCalc((double)numMainCount3.Value, (int)numMainWeight3.Value);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(name + ".xml");
            XmlElement root = xmlDoc.DocumentElement;
            if (root.SelectSingleNode($"Week{exercise}").InnerText == "3") {
                root.SelectSingleNode($"Week{exercise}").InnerText = "1";
                cycle++;
                root.SelectSingleNode($"Cycle{exercise}").InnerText = "1";
            }
            else {
                week++;
                root.SelectSingleNode($"Week{exercise}").InnerText = week.ToString();
            }
            if (potentORM > Convert.ToDouble(root.SelectSingleNode($"ORM{exercise}").InnerText)) {
                root.SelectSingleNode($"ORM{exercise}").InnerText = potentORM.ToString();
                MessageBox.Show($"New {exercise} 1RM ! {potentORM} kg!");
            }
            this.Close();
        }
    }
}
