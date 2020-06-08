namespace StringEqualityJohnO
{
    partial class frmStringEquality
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
            this.lblEnter = new System.Windows.Forms.Label();
            this.lblString1 = new System.Windows.Forms.Label();
            this.txtString1 = new System.Windows.Forms.TextBox();
            this.lblString2 = new System.Windows.Forms.Label();
            this.txtString2 = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.Location = new System.Drawing.Point(38, 36);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(346, 48);
            this.lblEnter.TabIndex = 8;
            this.lblEnter.Text = "Enter two strings to see if they are equal \r\n(Case doesn\'t matter.\")\r\n";
            // 
            // lblString1
            // 
            this.lblString1.AutoSize = true;
            this.lblString1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblString1.Location = new System.Drawing.Point(38, 128);
            this.lblString1.Name = "lblString1";
            this.lblString1.Size = new System.Drawing.Size(64, 20);
            this.lblString1.TabIndex = 11;
            this.lblString1.Text = "String1:";
            // 
            // txtString1
            // 
            this.txtString1.Location = new System.Drawing.Point(167, 128);
            this.txtString1.Name = "txtString1";
            this.txtString1.Size = new System.Drawing.Size(180, 20);
            this.txtString1.TabIndex = 12;
            // 
            // lblString2
            // 
            this.lblString2.AutoSize = true;
            this.lblString2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblString2.Location = new System.Drawing.Point(38, 193);
            this.lblString2.Name = "lblString2";
            this.lblString2.Size = new System.Drawing.Size(64, 20);
            this.lblString2.TabIndex = 13;
            this.lblString2.Text = "String2:";
            // 
            // txtString2
            // 
            this.txtString2.Location = new System.Drawing.Point(167, 195);
            this.txtString2.Name = "txtString2";
            this.txtString2.Size = new System.Drawing.Size(180, 20);
            this.txtString2.TabIndex = 14;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(167, 271);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(96, 42);
            this.btnCheck.TabIndex = 15;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(84, 333);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(35, 13);
            this.lblAnswer.TabIndex = 16;
            this.lblAnswer.Text = "label1";
            // 
            // frmStringEquality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 376);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtString2);
            this.Controls.Add(this.lblString2);
            this.Controls.Add(this.txtString1);
            this.Controls.Add(this.lblString1);
            this.Controls.Add(this.lblEnter);
            this.Name = "frmStringEquality";
            this.Text = "String Equality";
            this.Load += new System.EventHandler(this.frmStringEquality_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Label lblString1;
        private System.Windows.Forms.TextBox txtString1;
        private System.Windows.Forms.Label lblString2;
        private System.Windows.Forms.TextBox txtString2;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblAnswer;
    }
}

