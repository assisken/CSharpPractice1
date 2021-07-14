using System.ComponentModel;

namespace CSharpPractice7
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.launch = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.applications = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // launch
            // 
            this.launch.Enabled = false;
            this.launch.Location = new System.Drawing.Point(55, 127);
            this.launch.Name = "launch";
            this.launch.Size = new System.Drawing.Size(104, 32);
            this.launch.TabIndex = 1;
            this.launch.Text = "Запустить";
            this.launch.UseVisualStyleBackColor = true;
            this.launch.Click += new System.EventHandler(this.launch_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(211, 127);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(104, 32);
            this.exit.TabIndex = 2;
            this.exit.Text = "Выйти";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // applications
            // 
            this.applications.FormattingEnabled = true;
            this.applications.Location = new System.Drawing.Point(12, 12);
            this.applications.Name = "applications";
            this.applications.Size = new System.Drawing.Size(341, 108);
            this.applications.TabIndex = 3;
            this.applications.SelectedIndexChanged += new System.EventHandler(this.applications_SelectedIndexChanged);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 168);
            this.Controls.Add(this.applications);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.launch);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button launch;

        private System.Windows.Forms.Button exit;

        private System.Windows.Forms.ListBox applications;


        #endregion
    }
}