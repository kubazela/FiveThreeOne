
namespace FiveThreeOne {
    partial class StartupForm {
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
            this.lbStartUp = new System.Windows.Forms.Label();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.btSelectUser = new System.Windows.Forms.Button();
            this.btCreateUser = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbCreated = new System.Windows.Forms.ToolStripStatusLabel();
            this.btDeleteUser = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbStartUp
            // 
            this.lbStartUp.AutoSize = true;
            this.lbStartUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbStartUp.Location = new System.Drawing.Point(52, 9);
            this.lbStartUp.Name = "lbStartUp";
            this.lbStartUp.Size = new System.Drawing.Size(309, 33);
            this.lbStartUp.TabIndex = 0;
            this.lbStartUp.Text = "5/3/1 by Jim Wendler";
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.Location = new System.Drawing.Point(12, 57);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(193, 199);
            this.listBoxUsers.TabIndex = 1;
            // 
            // btSelectUser
            // 
            this.btSelectUser.Location = new System.Drawing.Point(253, 101);
            this.btSelectUser.Name = "btSelectUser";
            this.btSelectUser.Size = new System.Drawing.Size(144, 31);
            this.btSelectUser.TabIndex = 2;
            this.btSelectUser.Text = "Select user";
            this.btSelectUser.UseVisualStyleBackColor = true;
            // 
            // btCreateUser
            // 
            this.btCreateUser.Location = new System.Drawing.Point(253, 138);
            this.btCreateUser.Name = "btCreateUser";
            this.btCreateUser.Size = new System.Drawing.Size(144, 31);
            this.btCreateUser.TabIndex = 3;
            this.btCreateUser.Text = "Create user";
            this.btCreateUser.UseVisualStyleBackColor = true;
            this.btCreateUser.Click += new System.EventHandler(this.btCreateUser_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbCreated});
            this.statusStrip1.Location = new System.Drawing.Point(0, 268);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(435, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbCreated
            // 
            this.lbCreated.Name = "lbCreated";
            this.lbCreated.Size = new System.Drawing.Size(141, 17);
            this.lbCreated.Text = "Created by Jakub Zelenak";
            // 
            // btDeleteUser
            // 
            this.btDeleteUser.Location = new System.Drawing.Point(253, 197);
            this.btDeleteUser.Name = "btDeleteUser";
            this.btDeleteUser.Size = new System.Drawing.Size(144, 31);
            this.btDeleteUser.TabIndex = 5;
            this.btDeleteUser.Text = "Delete user";
            this.btDeleteUser.UseVisualStyleBackColor = true;
            this.btDeleteUser.Click += new System.EventHandler(this.btDeleteUser_Click);
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 290);
            this.Controls.Add(this.btDeleteUser);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btCreateUser);
            this.Controls.Add(this.btSelectUser);
            this.Controls.Add(this.listBoxUsers);
            this.Controls.Add(this.lbStartUp);
            this.Name = "StartupForm";
            this.Text = "StartupForm";
            this.Load += new System.EventHandler(this.StartupForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStartUp;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Button btSelectUser;
        private System.Windows.Forms.Button btCreateUser;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbCreated;
        private System.Windows.Forms.Button btDeleteUser;
    }
}