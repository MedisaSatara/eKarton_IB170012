
namespace ekarton.WinUI.Login
{
    partial class frmConfiramtionLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDA = new System.Windows.Forms.Button();
            this.btnNE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(65, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Da li ste sigurni da se zelite odjaviti ?";
            // 
            // btnDA
            // 
            this.btnDA.BackColor = System.Drawing.Color.Snow;
            this.btnDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDA.Location = new System.Drawing.Point(34, 82);
            this.btnDA.Name = "btnDA";
            this.btnDA.Size = new System.Drawing.Size(75, 23);
            this.btnDA.TabIndex = 1;
            this.btnDA.Text = "DA";
            this.btnDA.UseVisualStyleBackColor = false;
            this.btnDA.Click += new System.EventHandler(this.btnDA_Click);
            // 
            // btnNE
            // 
            this.btnNE.BackColor = System.Drawing.Color.Snow;
            this.btnNE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNE.Location = new System.Drawing.Point(208, 82);
            this.btnNE.Name = "btnNE";
            this.btnNE.Size = new System.Drawing.Size(75, 23);
            this.btnNE.TabIndex = 2;
            this.btnNE.Text = "NE";
            this.btnNE.UseVisualStyleBackColor = false;
            this.btnNE.Click += new System.EventHandler(this.btnNE_Click);
            // 
            // frmConfiramtionLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(332, 158);
            this.Controls.Add(this.btnNE);
            this.Controls.Add(this.btnDA);
            this.Controls.Add(this.label1);
            this.Name = "frmConfiramtionLogin";
            this.Text = "frmConfiramtionLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDA;
        private System.Windows.Forms.Button btnNE;
    }
}