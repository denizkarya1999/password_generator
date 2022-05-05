namespace xlanor
{
    partial class password
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
            this.paswd_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Here is your generated password:";
            // 
            // paswd_label
            // 
            this.paswd_label.AutoSize = true;
            this.paswd_label.Font = new System.Drawing.Font("Segoe UI", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paswd_label.Location = new System.Drawing.Point(216, 117);
            this.paswd_label.Name = "paswd_label";
            this.paswd_label.Size = new System.Drawing.Size(256, 116);
            this.paswd_label.TabIndex = 1;
            this.paswd_label.Text = "NULL";
            // 
            // password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 278);
            this.Controls.Add(this.paswd_label);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "password";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Generated Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        protected internal Label paswd_label;
    }
}