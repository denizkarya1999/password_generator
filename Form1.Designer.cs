namespace xlanor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.generate_button = new System.Windows.Forms.Button();
            this.name_of_the_user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.surname_of_the_user_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.day_of_birth_form = new System.Windows.Forms.ComboBox();
            this.month_of_birth_box = new System.Windows.Forms.ComboBox();
            this.year_of_birth_form = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.special_q_answer = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // generate_button
            // 
            this.generate_button.Location = new System.Drawing.Point(263, 570);
            this.generate_button.Name = "generate_button";
            this.generate_button.Size = new System.Drawing.Size(258, 77);
            this.generate_button.TabIndex = 0;
            this.generate_button.Text = "Generate";
            this.generate_button.UseVisualStyleBackColor = true;
            this.generate_button.Click += new System.EventHandler(this.generate_button_Click);
            // 
            // name_of_the_user
            // 
            this.name_of_the_user.Location = new System.Drawing.Point(229, 66);
            this.name_of_the_user.Name = "name_of_the_user";
            this.name_of_the_user.Size = new System.Drawing.Size(541, 47);
            this.name_of_the_user.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "Surname:";
            // 
            // surname_of_the_user_box
            // 
            this.surname_of_the_user_box.Location = new System.Drawing.Point(229, 142);
            this.surname_of_the_user_box.Name = "surname_of_the_user_box";
            this.surname_of_the_user_box.Size = new System.Drawing.Size(541, 47);
            this.surname_of_the_user_box.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date of Birth:";
            // 
            // day_of_birth_form
            // 
            this.day_of_birth_form.FormattingEnabled = true;
            this.day_of_birth_form.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.day_of_birth_form.Location = new System.Drawing.Point(229, 220);
            this.day_of_birth_form.Name = "day_of_birth_form";
            this.day_of_birth_form.Size = new System.Drawing.Size(90, 49);
            this.day_of_birth_form.TabIndex = 7;
            // 
            // month_of_birth_box
            // 
            this.month_of_birth_box.FormattingEnabled = true;
            this.month_of_birth_box.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.month_of_birth_box.Location = new System.Drawing.Point(336, 220);
            this.month_of_birth_box.Name = "month_of_birth_box";
            this.month_of_birth_box.Size = new System.Drawing.Size(209, 49);
            this.month_of_birth_box.TabIndex = 8;
            // 
            // year_of_birth_form
            // 
            this.year_of_birth_form.Location = new System.Drawing.Point(564, 222);
            this.year_of_birth_form.Name = "year_of_birth_form";
            this.year_of_birth_form.Size = new System.Drawing.Size(206, 47);
            this.year_of_birth_form.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 41);
            this.label4.TabIndex = 10;
            this.label4.Text = "Special Question:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "What`s the name of your best friend?",
            "What`s the name of your first pet?",
            "Where did you go to school when you were seven?",
            "What`s your favorite color?",
            "What`s the greatest secret about you?"});
            this.comboBox1.Location = new System.Drawing.Point(32, 355);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(738, 49);
            this.comboBox1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 41);
            this.label5.TabIndex = 12;
            this.label5.Text = "Answer:";
            // 
            // special_q_answer
            // 
            this.special_q_answer.Location = new System.Drawing.Point(32, 482);
            this.special_q_answer.Name = "special_q_answer";
            this.special_q_answer.Size = new System.Drawing.Size(738, 47);
            this.special_q_answer.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 52);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(124, 48);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(810, 684);
            this.Controls.Add(this.special_q_answer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.year_of_birth_form);
            this.Controls.Add(this.month_of_birth_box);
            this.Controls.Add(this.day_of_birth_form);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.surname_of_the_user_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_of_the_user);
            this.Controls.Add(this.generate_button);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button generate_button;
        private TextBox name_of_the_user;
        private Label label1;
        private Label label2;
        private TextBox surname_of_the_user_box;
        private Label label3;
        private ComboBox day_of_birth_form;
        private ComboBox month_of_birth_box;
        private TextBox year_of_birth_form;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox special_q_answer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}