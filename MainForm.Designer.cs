
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.btReset = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.btExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
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
            // chartMain
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMain.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMain.Legends.Add(legend2);
            this.chartMain.Location = new System.Drawing.Point(484, 255);
            this.chartMain.Name = "chartMain";
            this.chartMain.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartMain.Series.Add(series2);
            this.chartMain.Size = new System.Drawing.Size(304, 183);
            this.chartMain.TabIndex = 1;
            this.chartMain.Text = "chart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "5/3/1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
    }
}

