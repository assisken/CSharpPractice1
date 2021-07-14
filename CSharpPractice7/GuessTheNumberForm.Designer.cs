using System.ComponentModel;

namespace CSharpPractice7
{
    partial class GuessTheNumberForm
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
            this.guessButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(69, 54);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(118, 31);
            this.guessButton.TabIndex = 0;
            this.guessButton.Text = "Угадать число";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(231, 42);
            this.label.TabIndex = 1;
            this.label.Text = "label1";
            // 
            // GuessTheNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 92);
            this.Controls.Add(this.label);
            this.Controls.Add(this.guessButton);
            this.Name = "GuessTheNumberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuessTheNumberForm";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button guessButton;

        #endregion
    }
}