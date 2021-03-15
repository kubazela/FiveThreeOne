
namespace FiveThreeOne {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.btReset = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.btExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbSignedUpUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbBenchPress = new System.Windows.Forms.Label();
            this.lbSquat = new System.Windows.Forms.Label();
            this.lbDeadlift = new System.Windows.Forms.Label();
            this.lbOHP = new System.Windows.Forms.Label();
            this.lbBenchPressCycleWeek = new System.Windows.Forms.Label();
            this.lbBenchPressLastDate = new System.Windows.Forms.Label();
            this.lbBenchPressORM = new System.Windows.Forms.Label();
            this.lbSquatORM = new System.Windows.Forms.Label();
            this.lbSquatLastDate = new System.Windows.Forms.Label();
            this.lbSquatCycleWeek = new System.Windows.Forms.Label();
            this.lbDeadliftORM = new System.Windows.Forms.Label();
            this.lbDeadliftLastDate = new System.Windows.Forms.Label();
            this.lbDeadliftCycleWeek = new System.Windows.Forms.Label();
            this.lbOhpORM = new System.Windows.Forms.Label();
            this.lbOhpLastDate = new System.Windows.Forms.Label();
            this.lbOhpCycleWeek = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btSettings,
            this.btAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btSettings
            // 
            this.btSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btReset,
            this.toolStripMenuItem1,
            this.btExit});
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(61, 20);
            this.btSettings.Text = "Settings";
            this.btSettings.Click += new System.EventHandler(this.nastaveníToolStripMenuItem_Click);
            // 
            // btReset
            // 
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(102, 22);
            this.btReset.Text = "Reset";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(99, 6);
            // 
            // btExit
            // 
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(102, 22);
            this.btExit.Text = "Exit";
            // 
            // btAbout
            // 
            this.btAbout.Name = "btAbout";
            this.btAbout.Size = new System.Drawing.Size(52, 20);
            this.btAbout.Text = "About";
            this.btAbout.Click += new System.EventHandler(this.btAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbSignedUpUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbSignedUpUser
            // 
            this.lbSignedUpUser.Name = "lbSignedUpUser";
            this.lbSignedUpUser.Size = new System.Drawing.Size(118, 17);
            this.lbSignedUpUser.Text = "toolStripStatusLabel1";
            // 
            // lbBenchPress
            // 
            this.lbBenchPress.AutoSize = true;
            this.lbBenchPress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbBenchPress.Location = new System.Drawing.Point(133, 39);
            this.lbBenchPress.Name = "lbBenchPress";
            this.lbBenchPress.Size = new System.Drawing.Size(98, 20);
            this.lbBenchPress.TabIndex = 3;
            this.lbBenchPress.Text = "Bench press";
            // 
            // lbSquat
            // 
            this.lbSquat.AutoSize = true;
            this.lbSquat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbSquat.Location = new System.Drawing.Point(289, 39);
            this.lbSquat.Name = "lbSquat";
            this.lbSquat.Size = new System.Drawing.Size(52, 20);
            this.lbSquat.TabIndex = 4;
            this.lbSquat.Text = "Squat";
            // 
            // lbDeadlift
            // 
            this.lbDeadlift.AutoSize = true;
            this.lbDeadlift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDeadlift.Location = new System.Drawing.Point(422, 39);
            this.lbDeadlift.Name = "lbDeadlift";
            this.lbDeadlift.Size = new System.Drawing.Size(64, 20);
            this.lbDeadlift.TabIndex = 5;
            this.lbDeadlift.Text = "Deadlift";
            // 
            // lbOHP
            // 
            this.lbOHP.AutoSize = true;
            this.lbOHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbOHP.Location = new System.Drawing.Point(548, 39);
            this.lbOHP.Name = "lbOHP";
            this.lbOHP.Size = new System.Drawing.Size(121, 20);
            this.lbOHP.TabIndex = 6;
            this.lbOHP.Text = "Overhead press";
            // 
            // lbBenchPressCycleWeek
            // 
            this.lbBenchPressCycleWeek.AutoSize = true;
            this.lbBenchPressCycleWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbBenchPressCycleWeek.Location = new System.Drawing.Point(135, 70);
            this.lbBenchPressCycleWeek.Name = "lbBenchPressCycleWeek";
            this.lbBenchPressCycleWeek.Size = new System.Drawing.Size(55, 12);
            this.lbBenchPressCycleWeek.TabIndex = 7;
            this.lbBenchPressCycleWeek.Text = "Cycle Week";
            // 
            // lbBenchPressLastDate
            // 
            this.lbBenchPressLastDate.AutoSize = true;
            this.lbBenchPressLastDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbBenchPressLastDate.Location = new System.Drawing.Point(135, 82);
            this.lbBenchPressLastDate.Name = "lbBenchPressLastDate";
            this.lbBenchPressLastDate.Size = new System.Drawing.Size(43, 12);
            this.lbBenchPressLastDate.TabIndex = 8;
            this.lbBenchPressLastDate.Text = "Last date";
            // 
            // lbBenchPressORM
            // 
            this.lbBenchPressORM.AutoSize = true;
            this.lbBenchPressORM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbBenchPressORM.Location = new System.Drawing.Point(143, 105);
            this.lbBenchPressORM.Name = "lbBenchPressORM";
            this.lbBenchPressORM.Size = new System.Drawing.Size(44, 18);
            this.lbBenchPressORM.TabIndex = 9;
            this.lbBenchPressORM.Text = "ORM";
            // 
            // lbSquatORM
            // 
            this.lbSquatORM.AutoSize = true;
            this.lbSquatORM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbSquatORM.Location = new System.Drawing.Point(299, 105);
            this.lbSquatORM.Name = "lbSquatORM";
            this.lbSquatORM.Size = new System.Drawing.Size(44, 18);
            this.lbSquatORM.TabIndex = 12;
            this.lbSquatORM.Text = "ORM";
            // 
            // lbSquatLastDate
            // 
            this.lbSquatLastDate.AutoSize = true;
            this.lbSquatLastDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbSquatLastDate.Location = new System.Drawing.Point(291, 82);
            this.lbSquatLastDate.Name = "lbSquatLastDate";
            this.lbSquatLastDate.Size = new System.Drawing.Size(43, 12);
            this.lbSquatLastDate.TabIndex = 11;
            this.lbSquatLastDate.Text = "Last date";
            // 
            // lbSquatCycleWeek
            // 
            this.lbSquatCycleWeek.AutoSize = true;
            this.lbSquatCycleWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbSquatCycleWeek.Location = new System.Drawing.Point(291, 70);
            this.lbSquatCycleWeek.Name = "lbSquatCycleWeek";
            this.lbSquatCycleWeek.Size = new System.Drawing.Size(55, 12);
            this.lbSquatCycleWeek.TabIndex = 10;
            this.lbSquatCycleWeek.Text = "Cycle Week";
            // 
            // lbDeadliftORM
            // 
            this.lbDeadliftORM.AutoSize = true;
            this.lbDeadliftORM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDeadliftORM.Location = new System.Drawing.Point(432, 105);
            this.lbDeadliftORM.Name = "lbDeadliftORM";
            this.lbDeadliftORM.Size = new System.Drawing.Size(44, 18);
            this.lbDeadliftORM.TabIndex = 15;
            this.lbDeadliftORM.Text = "ORM";
            // 
            // lbDeadliftLastDate
            // 
            this.lbDeadliftLastDate.AutoSize = true;
            this.lbDeadliftLastDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDeadliftLastDate.Location = new System.Drawing.Point(424, 82);
            this.lbDeadliftLastDate.Name = "lbDeadliftLastDate";
            this.lbDeadliftLastDate.Size = new System.Drawing.Size(43, 12);
            this.lbDeadliftLastDate.TabIndex = 14;
            this.lbDeadliftLastDate.Text = "Last date";
            // 
            // lbDeadliftCycleWeek
            // 
            this.lbDeadliftCycleWeek.AutoSize = true;
            this.lbDeadliftCycleWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDeadliftCycleWeek.Location = new System.Drawing.Point(424, 70);
            this.lbDeadliftCycleWeek.Name = "lbDeadliftCycleWeek";
            this.lbDeadliftCycleWeek.Size = new System.Drawing.Size(55, 12);
            this.lbDeadliftCycleWeek.TabIndex = 13;
            this.lbDeadliftCycleWeek.Text = "Cycle Week";
            // 
            // lbOhpORM
            // 
            this.lbOhpORM.AutoSize = true;
            this.lbOhpORM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbOhpORM.Location = new System.Drawing.Point(581, 105);
            this.lbOhpORM.Name = "lbOhpORM";
            this.lbOhpORM.Size = new System.Drawing.Size(44, 18);
            this.lbOhpORM.TabIndex = 18;
            this.lbOhpORM.Text = "ORM";
            // 
            // lbOhpLastDate
            // 
            this.lbOhpLastDate.AutoSize = true;
            this.lbOhpLastDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbOhpLastDate.Location = new System.Drawing.Point(573, 82);
            this.lbOhpLastDate.Name = "lbOhpLastDate";
            this.lbOhpLastDate.Size = new System.Drawing.Size(43, 12);
            this.lbOhpLastDate.TabIndex = 17;
            this.lbOhpLastDate.Text = "Last date";
            // 
            // lbOhpCycleWeek
            // 
            this.lbOhpCycleWeek.AutoSize = true;
            this.lbOhpCycleWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbOhpCycleWeek.Location = new System.Drawing.Point(573, 70);
            this.lbOhpCycleWeek.Name = "lbOhpCycleWeek";
            this.lbOhpCycleWeek.Size = new System.Drawing.Size(55, 12);
            this.lbOhpCycleWeek.TabIndex = 16;
            this.lbOhpCycleWeek.Text = "Cycle Week";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbOhpORM);
            this.Controls.Add(this.lbOhpLastDate);
            this.Controls.Add(this.lbOhpCycleWeek);
            this.Controls.Add(this.lbDeadliftORM);
            this.Controls.Add(this.lbDeadliftLastDate);
            this.Controls.Add(this.lbDeadliftCycleWeek);
            this.Controls.Add(this.lbSquatORM);
            this.Controls.Add(this.lbSquatLastDate);
            this.Controls.Add(this.lbSquatCycleWeek);
            this.Controls.Add(this.lbBenchPressORM);
            this.Controls.Add(this.lbBenchPressLastDate);
            this.Controls.Add(this.lbBenchPressCycleWeek);
            this.Controls.Add(this.lbOHP);
            this.Controls.Add(this.lbDeadlift);
            this.Controls.Add(this.lbSquat);
            this.Controls.Add(this.lbBenchPress);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "5/3/1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btSettings;
        private System.Windows.Forms.ToolStripMenuItem btReset;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btExit;
        private System.Windows.Forms.ToolStripMenuItem btAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbSignedUpUser;
        private System.Windows.Forms.Label lbBenchPress;
        private System.Windows.Forms.Label lbSquat;
        private System.Windows.Forms.Label lbDeadlift;
        private System.Windows.Forms.Label lbOHP;
        private System.Windows.Forms.Label lbBenchPressCycleWeek;
        private System.Windows.Forms.Label lbBenchPressLastDate;
        private System.Windows.Forms.Label lbBenchPressORM;
        private System.Windows.Forms.Label lbSquatORM;
        private System.Windows.Forms.Label lbSquatLastDate;
        private System.Windows.Forms.Label lbSquatCycleWeek;
        private System.Windows.Forms.Label lbDeadliftORM;
        private System.Windows.Forms.Label lbDeadliftLastDate;
        private System.Windows.Forms.Label lbDeadliftCycleWeek;
        private System.Windows.Forms.Label lbOhpORM;
        private System.Windows.Forms.Label lbOhpLastDate;
        private System.Windows.Forms.Label lbOhpCycleWeek;
    }
}

