﻿namespace SwitchStatementJohnO
{
    partial class frmSwitchStatement
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
            this.lblGradeLevel = new System.Windows.Forms.Label();
            this.txtGradeLevel = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGradeLevel
            // 
            this.lblGradeLevel.AutoSize = true;
            this.lblGradeLevel.Location = new System.Drawing.Point(42, 107);
            this.lblGradeLevel.Name = "lblGradeLevel";
            this.lblGradeLevel.Size = new System.Drawing.Size(99, 13);
            this.lblGradeLevel.TabIndex = 1;
            this.lblGradeLevel.Text = "Enter a grade level:";
            // 
            // txtGradeLevel
            // 
            this.txtGradeLevel.Location = new System.Drawing.Point(179, 107);
            this.txtGradeLevel.Name = "txtGradeLevel";
            this.txtGradeLevel.Size = new System.Drawing.Size(100, 20);
            this.txtGradeLevel.TabIndex = 2;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(136, 174);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // frmSwitchStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 305);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtGradeLevel);
            this.Controls.Add(this.lblGradeLevel);
            this.Name = "frmSwitchStatement";
            this.Text = "Switch Statement";
            this.Load += new System.EventHandler(this.frmSwitchStatement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGradeLevel;
        private System.Windows.Forms.TextBox txtGradeLevel;
        private System.Windows.Forms.Button btnEnter;
    }
}

