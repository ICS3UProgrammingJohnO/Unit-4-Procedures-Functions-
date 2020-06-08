namespace HypotenuseJohnO
{
    partial class frmHypotenuse
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
            this.lblOpposite = new System.Windows.Forms.Label();
            this.txtOpposite = new System.Windows.Forms.TextBox();
            this.lblAdjacent = new System.Windows.Forms.Label();
            this.txtAdjacent = new System.Windows.Forms.TextBox();
            this.btnCalculateHypotenuse = new System.Windows.Forms.Button();
            this.lblHypotenuse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOpposite
            // 
            this.lblOpposite.AutoSize = true;
            this.lblOpposite.Location = new System.Drawing.Point(75, 77);
            this.lblOpposite.Name = "lblOpposite";
            this.lblOpposite.Size = new System.Drawing.Size(41, 13);
            this.lblOpposite.TabIndex = 1;
            this.lblOpposite.Text = "Side A:";
            // 
            // txtOpposite
            // 
            this.txtOpposite.Location = new System.Drawing.Point(182, 77);
            this.txtOpposite.Name = "txtOpposite";
            this.txtOpposite.Size = new System.Drawing.Size(100, 20);
            this.txtOpposite.TabIndex = 5;
            // 
            // lblAdjacent
            // 
            this.lblAdjacent.AutoSize = true;
            this.lblAdjacent.Location = new System.Drawing.Point(75, 152);
            this.lblAdjacent.Name = "lblAdjacent";
            this.lblAdjacent.Size = new System.Drawing.Size(41, 13);
            this.lblAdjacent.TabIndex = 6;
            this.lblAdjacent.Text = "Side B:";
            // 
            // txtAdjacent
            // 
            this.txtAdjacent.Location = new System.Drawing.Point(182, 152);
            this.txtAdjacent.Name = "txtAdjacent";
            this.txtAdjacent.Size = new System.Drawing.Size(100, 20);
            this.txtAdjacent.TabIndex = 7;
            // 
            // btnCalculateHypotenuse
            // 
            this.btnCalculateHypotenuse.Location = new System.Drawing.Point(125, 216);
            this.btnCalculateHypotenuse.Name = "btnCalculateHypotenuse";
            this.btnCalculateHypotenuse.Size = new System.Drawing.Size(126, 45);
            this.btnCalculateHypotenuse.TabIndex = 8;
            this.btnCalculateHypotenuse.Text = "Calculate Hypotenuse";
            this.btnCalculateHypotenuse.UseVisualStyleBackColor = true;
            this.btnCalculateHypotenuse.Click += new System.EventHandler(this.btnCalculateHypotenuse_Click);
            // 
            // lblHypotenuse
            // 
            this.lblHypotenuse.AutoSize = true;
            this.lblHypotenuse.Location = new System.Drawing.Point(55, 331);
            this.lblHypotenuse.Name = "lblHypotenuse";
            this.lblHypotenuse.Size = new System.Drawing.Size(35, 13);
            this.lblHypotenuse.TabIndex = 9;
            this.lblHypotenuse.Text = "label1";
            // 
            // frmHypotenuse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 394);
            this.Controls.Add(this.lblHypotenuse);
            this.Controls.Add(this.btnCalculateHypotenuse);
            this.Controls.Add(this.txtAdjacent);
            this.Controls.Add(this.lblAdjacent);
            this.Controls.Add(this.txtOpposite);
            this.Controls.Add(this.lblOpposite);
            this.Name = "frmHypotenuse";
            this.Text = "Hypotenuse";
            this.Load += new System.EventHandler(this.frmHypotenuse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpposite;
        private System.Windows.Forms.TextBox txtOpposite;
        private System.Windows.Forms.Label lblAdjacent;
        private System.Windows.Forms.TextBox txtAdjacent;
        private System.Windows.Forms.Button btnCalculateHypotenuse;
        private System.Windows.Forms.Label lblHypotenuse;
    }
}

