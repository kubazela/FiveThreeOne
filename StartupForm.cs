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
using System.IO;

namespace FiveThreeOne {
    public partial class StartupForm : Form {

        public StartupForm() {
            InitializeComponent();
        }
        private void StartupForm_Load(object sender, EventArgs e) {
            if (FileLib.ListBoxUsersUpdate().Count == 0)
                btCreateUser_Click(sender, e);
            else {
                listBoxUsers.DataSource = FileLib.ListBoxUsersUpdate();
            }
        }

        private void btCreateUser_Click(object sender, EventArgs e) {
            this.Hide();
            InitialSettingForm initForm = new InitialSettingForm();
            initForm.Closed += (s, args) => this.Close();
            initForm.ShowDialog();
        }

        private void btDeleteUser_Click(object sender, EventArgs e) {
            //string name = listBoxUsers.SelectedItem.Va;
            string name = listBoxUsers.GetItemText(listBoxUsers.SelectedItem.ToString());
            FileLib.DeleteFile(name);
            StartupForm_Load(sender, e);
        }
    }
}
