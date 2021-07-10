namespace CSharpPractice7
{
    partial class MultiplierForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.addOne = new System.Windows.Forms.Button();
            this.doubleValue = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.redo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddOne
            // 
            this.addOne.Location = new System.Drawing.Point(90, 6);
            this.addOne.Name = "AddOne";
            this.addOne.Size = new System.Drawing.Size(32, 24);
            this.addOne.TabIndex = 0;
            this.addOne.Text = "+1";
            this.addOne.UseVisualStyleBackColor = true;
            this.addOne.Click += new System.EventHandler(this.AddOne_Click);
            // 
            // Double
            // 
            this.doubleValue.Location = new System.Drawing.Point(128, 6);
            this.doubleValue.Name = "Double";
            this.doubleValue.Size = new System.Drawing.Size(32, 24);
            this.doubleValue.TabIndex = 1;
            this.doubleValue.Text = "x2";
            this.doubleValue.UseVisualStyleBackColor = true;
            this.doubleValue.Click += new System.EventHandler(this.Double_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(90, 66);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(70, 24);
            this.Reset.TabIndex = 2;
            this.Reset.Text = "Сброс";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(12, 12);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(72, 108);
            this.label.TabIndex = 3;
            this.label.Text = "label1";
            // 
            // redo
            // 
            this.redo.Location = new System.Drawing.Point(90, 36);
            this.redo.Name = "redo";
            this.redo.Size = new System.Drawing.Size(70, 24);
            this.redo.TabIndex = 4;
            this.redo.Text = "Отменить";
            this.redo.UseVisualStyleBackColor = true;
            this.redo.Click += new System.EventHandler(this.redo_Click);
            // 
            // MultiplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(167, 97);
            this.Controls.Add(this.redo);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.doubleValue);
            this.Controls.Add(this.addOne);
            this.Name = "MultiplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практика по C# 7";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button redo;

        private System.Windows.Forms.Button addOne;
        private System.Windows.Forms.Button doubleValue;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button Reset;

        #endregion
    }
}