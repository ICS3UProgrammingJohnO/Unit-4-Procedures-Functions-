namespace NewWalkingManJohnO
{
    partial class frmNewWalkingMan
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.PictureBox_Click = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Click)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(196, 47);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(187, 13);
            this.lblInstructions.TabIndex = 2;
            this.lblInstructions.Text = "Click on an image to make them move";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(255, 338);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(84, 30);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // PictureBox_Click
            // 
            this.PictureBox_Click.Image = global::NewWalkingManJohnO.Properties.Resources.walk1;
            this.PictureBox_Click.Location = new System.Drawing.Point(166, 119);
            this.PictureBox_Click.Name = "PictureBox_Click";
            this.PictureBox_Click.Size = new System.Drawing.Size(217, 166);
            this.PictureBox_Click.TabIndex = 4;
            this.PictureBox_Click.TabStop = false;
            this.PictureBox_Click.Click += new System.EventHandler(this.PictureBox_Click_Click);
            // 
            // frmNewWalkingMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 442);
            this.Controls.Add(this.PictureBox_Click);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblInstructions);
            this.Name = "frmNewWalkingMan";
            this.Text = "New Walking Man";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Click)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox PictureBox_Click;
    }
}

