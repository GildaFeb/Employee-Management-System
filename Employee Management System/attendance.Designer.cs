namespace Employee_Management_System
{
    partial class attendance
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
            this.return_ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // return_
            // 
            this.return_.AutoSize = true;
            this.return_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.return_.Image = global::Employee_Management_System.Properties.Resources.back6;
            this.return_.Location = new System.Drawing.Point(12, 9);
            this.return_.Name = "return_";
            this.return_.Padding = new System.Windows.Forms.Padding(35, 25, 35, 25);
            this.return_.Size = new System.Drawing.Size(70, 70);
            this.return_.TabIndex = 0;
            this.return_.Click += new System.EventHandler(this.return__Click);
            // 
            // attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1349, 688);
            this.Controls.Add(this.return_);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "attendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "attendance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label return_;
    }
}