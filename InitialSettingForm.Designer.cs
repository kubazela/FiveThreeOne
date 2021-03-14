
namespace FiveThreeOne {
    partial class InitialSettingForm {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialSettingForm));
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbORM = new System.Windows.Forms.Label();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.lbInitBenchPress = new System.Windows.Forms.Label();
            this.tBoxInitBenchPress = new System.Windows.Forms.TextBox();
            this.tBoxInitSquat = new System.Windows.Forms.TextBox();
            this.lbInitSquat = new System.Windows.Forms.Label();
            this.tBoxInitDeadlift = new System.Windows.Forms.TextBox();
            this.lbInitDeadLift = new System.Windows.Forms.Label();
            this.tBoxInitOHP = new System.Windows.Forms.TextBox();
            this.lbInitOHP = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.numInitBenchPress = new System.Windows.Forms.NumericUpDown();
            this.numInitSquat = new System.Windows.Forms.NumericUpDown();
            this.numInitDeadlift = new System.Windows.Forms.NumericUpDown();
            this.numInitOHP = new System.Windows.Forms.NumericUpDown();
            this.btProceed = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbCreated = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numInitBenchPress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInitSquat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInitDeadlift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInitOHP)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTitle.Location = new System.Drawing.Point(82, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(309, 33);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "5/3/1 by Jim Wendler";
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Location = new System.Drawing.Point(61, 53);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(356, 13);
            this.lbWelcome.TabIndex = 1;
            this.lbWelcome.Text = "Welcome to 5/3/1 workout app. You need to enter inital data to proceed. ";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(170, 120);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(58, 13);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Your name";
            // 
            // lbORM
            // 
            this.lbORM.AutoSize = true;
            this.lbORM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbORM.Location = new System.Drawing.Point(197, 165);
            this.lbORM.Name = "lbORM";
            this.lbORM.Size = new System.Drawing.Size(84, 13);
            this.lbORM.TabIndex = 3;
            this.lbORM.Text = "One Rep Maxes";
            this.toolTip1.SetToolTip(this.lbORM, resources.GetString("lbORM.ToolTip"));
            // 
            // tBoxName
            // 
            this.tBoxName.Location = new System.Drawing.Point(241, 113);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(100, 20);
            this.tBoxName.TabIndex = 4;
            // 
            // lbInitBenchPress
            // 
            this.lbInitBenchPress.AutoSize = true;
            this.lbInitBenchPress.Location = new System.Drawing.Point(35, 209);
            this.lbInitBenchPress.Name = "lbInitBenchPress";
            this.lbInitBenchPress.Size = new System.Drawing.Size(67, 13);
            this.lbInitBenchPress.TabIndex = 5;
            this.lbInitBenchPress.Text = "Bench Press";
            // 
            // tBoxInitBenchPress
            // 
            this.tBoxInitBenchPress.Location = new System.Drawing.Point(27, 225);
            this.tBoxInitBenchPress.Name = "tBoxInitBenchPress";
            this.tBoxInitBenchPress.Size = new System.Drawing.Size(83, 20);
            this.tBoxInitBenchPress.TabIndex = 6;
            this.tBoxInitBenchPress.TextChanged += new System.EventHandler(this.tBox_TextChanged);
            // 
            // tBoxInitSquat
            // 
            this.tBoxInitSquat.Location = new System.Drawing.Point(145, 225);
            this.tBoxInitSquat.Name = "tBoxInitSquat";
            this.tBoxInitSquat.Size = new System.Drawing.Size(83, 20);
            this.tBoxInitSquat.TabIndex = 8;
            this.tBoxInitSquat.TextChanged += new System.EventHandler(this.tBox_TextChanged);
            // 
            // lbInitSquat
            // 
            this.lbInitSquat.AutoSize = true;
            this.lbInitSquat.Location = new System.Drawing.Point(169, 209);
            this.lbInitSquat.Name = "lbInitSquat";
            this.lbInitSquat.Size = new System.Drawing.Size(35, 13);
            this.lbInitSquat.TabIndex = 7;
            this.lbInitSquat.Text = "Squat";
            // 
            // tBoxInitDeadlift
            // 
            this.tBoxInitDeadlift.Location = new System.Drawing.Point(258, 225);
            this.tBoxInitDeadlift.Name = "tBoxInitDeadlift";
            this.tBoxInitDeadlift.Size = new System.Drawing.Size(83, 20);
            this.tBoxInitDeadlift.TabIndex = 10;
            this.tBoxInitDeadlift.TextChanged += new System.EventHandler(this.tBox_TextChanged);
            // 
            // lbInitDeadLift
            // 
            this.lbInitDeadLift.AutoSize = true;
            this.lbInitDeadLift.Location = new System.Drawing.Point(281, 209);
            this.lbInitDeadLift.Name = "lbInitDeadLift";
            this.lbInitDeadLift.Size = new System.Drawing.Size(43, 13);
            this.lbInitDeadLift.TabIndex = 9;
            this.lbInitDeadLift.Text = "Deadlift";
            // 
            // tBoxInitOHP
            // 
            this.tBoxInitOHP.Location = new System.Drawing.Point(369, 225);
            this.tBoxInitOHP.Name = "tBoxInitOHP";
            this.tBoxInitOHP.Size = new System.Drawing.Size(83, 20);
            this.tBoxInitOHP.TabIndex = 12;
            this.tBoxInitOHP.TextChanged += new System.EventHandler(this.tBox_TextChanged);
            // 
            // lbInitOHP
            // 
            this.lbInitOHP.AutoSize = true;
            this.lbInitOHP.Location = new System.Drawing.Point(369, 209);
            this.lbInitOHP.Name = "lbInitOHP";
            this.lbInitOHP.Size = new System.Drawing.Size(83, 13);
            this.lbInitOHP.TabIndex = 11;
            this.lbInitOHP.Text = "Overhead Press";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 20000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // numInitBenchPress
            // 
            this.numInitBenchPress.Location = new System.Drawing.Point(27, 251);
            this.numInitBenchPress.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numInitBenchPress.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInitBenchPress.Name = "numInitBenchPress";
            this.numInitBenchPress.Size = new System.Drawing.Size(83, 20);
            this.numInitBenchPress.TabIndex = 13;
            this.numInitBenchPress.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numInitSquat
            // 
            this.numInitSquat.Location = new System.Drawing.Point(145, 251);
            this.numInitSquat.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numInitSquat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInitSquat.Name = "numInitSquat";
            this.numInitSquat.Size = new System.Drawing.Size(83, 20);
            this.numInitSquat.TabIndex = 14;
            this.numInitSquat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numInitDeadlift
            // 
            this.numInitDeadlift.Location = new System.Drawing.Point(258, 251);
            this.numInitDeadlift.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numInitDeadlift.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInitDeadlift.Name = "numInitDeadlift";
            this.numInitDeadlift.Size = new System.Drawing.Size(83, 20);
            this.numInitDeadlift.TabIndex = 15;
            this.numInitDeadlift.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numInitOHP
            // 
            this.numInitOHP.Location = new System.Drawing.Point(369, 251);
            this.numInitOHP.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numInitOHP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInitOHP.Name = "numInitOHP";
            this.numInitOHP.Size = new System.Drawing.Size(83, 20);
            this.numInitOHP.TabIndex = 16;
            this.numInitOHP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btProceed
            // 
            this.btProceed.Location = new System.Drawing.Point(189, 297);
            this.btProceed.Name = "btProceed";
            this.btProceed.Size = new System.Drawing.Size(105, 35);
            this.btProceed.TabIndex = 17;
            this.btProceed.Text = "Start";
            this.btProceed.UseVisualStyleBackColor = true;
            this.btProceed.Click += new System.EventHandler(this.btProceed_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbCreated});
            this.statusStrip1.Location = new System.Drawing.Point(0, 351);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(485, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbCreated
            // 
            this.lbCreated.Name = "lbCreated";
            this.lbCreated.Size = new System.Drawing.Size(141, 17);
            this.lbCreated.Text = "Created by Jakub Zelenak";
            // 
            // InitialSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 373);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btProceed);
            this.Controls.Add(this.numInitOHP);
            this.Controls.Add(this.numInitDeadlift);
            this.Controls.Add(this.numInitSquat);
            this.Controls.Add(this.numInitBenchPress);
            this.Controls.Add(this.tBoxInitOHP);
            this.Controls.Add(this.lbInitOHP);
            this.Controls.Add(this.tBoxInitDeadlift);
            this.Controls.Add(this.lbInitDeadLift);
            this.Controls.Add(this.tBoxInitSquat);
            this.Controls.Add(this.lbInitSquat);
            this.Controls.Add(this.tBoxInitBenchPress);
            this.Controls.Add(this.lbInitBenchPress);
            this.Controls.Add(this.tBoxName);
            this.Controls.Add(this.lbORM);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.lbTitle);
            this.Name = "InitialSettingForm";
            this.Text = "Initial Settings";
            ((System.ComponentModel.ISupportInitialize)(this.numInitBenchPress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInitSquat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInitDeadlift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInitOHP)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbORM;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Label lbInitBenchPress;
        private System.Windows.Forms.TextBox tBoxInitBenchPress;
        private System.Windows.Forms.TextBox tBoxInitSquat;
        private System.Windows.Forms.Label lbInitSquat;
        private System.Windows.Forms.TextBox tBoxInitDeadlift;
        private System.Windows.Forms.Label lbInitDeadLift;
        private System.Windows.Forms.TextBox tBoxInitOHP;
        private System.Windows.Forms.Label lbInitOHP;
        private System.Windows.Forms.NumericUpDown numInitBenchPress;
        private System.Windows.Forms.NumericUpDown numInitSquat;
        private System.Windows.Forms.NumericUpDown numInitDeadlift;
        private System.Windows.Forms.NumericUpDown numInitOHP;
        private System.Windows.Forms.Button btProceed;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbCreated;
    }
}