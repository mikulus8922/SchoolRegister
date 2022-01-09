
namespace School.Forms.UserForms
{
    partial class FormTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeacher));
            this.labelHello = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QuitButton = new School.Interface.CustomButton();
            this.LogOutButton = new School.Interface.CustomButton();
            this.LessonsButton = new School.Interface.CustomButton();
            this.TestsButton = new School.Interface.CustomButton();
            this.GradesButton = new School.Interface.CustomButton();
            this.AbsencesButton = new School.Interface.CustomButton();
            this.panelFormLoader = new System.Windows.Forms.Panel();
            this.XButton = new School.Interface.CustomButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHello
            // 
            this.labelHello.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHello.AutoSize = true;
            this.labelHello.BackColor = System.Drawing.Color.Transparent;
            this.labelHello.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHello.ForeColor = System.Drawing.Color.White;
            this.labelHello.Location = new System.Drawing.Point(105, 204);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(83, 24);
            this.labelHello.TabIndex = 0;
            this.labelHello.Text = "{name} !";
            this.labelHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.QuitButton);
            this.panel1.Controls.Add(this.LogOutButton);
            this.panel1.Controls.Add(this.LessonsButton);
            this.panel1.Controls.Add(this.TestsButton);
            this.panel1.Controls.Add(this.GradesButton);
            this.panel1.Controls.Add(this.AbsencesButton);
            this.panel1.Controls.Add(this.labelHello);
            this.panel1.Location = new System.Drawing.Point(23, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 651);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(92, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 126);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.label1.Location = new System.Drawing.Point(111, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "Hello";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuitButton
            // 
            this.QuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.QuitButton.BackColor = System.Drawing.Color.Transparent;
            this.QuitButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.QuitButton.BorderColor = System.Drawing.Color.Transparent;
            this.QuitButton.BorderRadius = 0;
            this.QuitButton.BorderSize = 0;
            this.QuitButton.FlatAppearance.BorderSize = 0;
            this.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.QuitButton.ForeColor = System.Drawing.Color.White;
            this.QuitButton.ForegroundColor = System.Drawing.Color.White;
            this.QuitButton.Location = new System.Drawing.Point(26, 600);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(259, 35);
            this.QuitButton.TabIndex = 12;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LogOutButton.BackColor = System.Drawing.Color.White;
            this.LogOutButton.BackgroundColor = System.Drawing.Color.White;
            this.LogOutButton.BorderColor = System.Drawing.Color.White;
            this.LogOutButton.BorderRadius = 0;
            this.LogOutButton.BorderSize = 0;
            this.LogOutButton.FlatAppearance.BorderSize = 0;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.LogOutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(43)))));
            this.LogOutButton.ForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(43)))));
            this.LogOutButton.Location = new System.Drawing.Point(26, 559);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(259, 35);
            this.LogOutButton.TabIndex = 11;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // LessonsButton
            // 
            this.LessonsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LessonsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.LessonsButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.LessonsButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.LessonsButton.BorderRadius = 0;
            this.LessonsButton.BorderSize = 0;
            this.LessonsButton.FlatAppearance.BorderSize = 0;
            this.LessonsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LessonsButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.LessonsButton.ForeColor = System.Drawing.Color.White;
            this.LessonsButton.ForegroundColor = System.Drawing.Color.White;
            this.LessonsButton.Location = new System.Drawing.Point(25, 432);
            this.LessonsButton.Name = "LessonsButton";
            this.LessonsButton.Size = new System.Drawing.Size(259, 35);
            this.LessonsButton.TabIndex = 10;
            this.LessonsButton.Text = "Lessons";
            this.LessonsButton.UseVisualStyleBackColor = false;
            this.LessonsButton.Click += new System.EventHandler(this.LessonsButton_Click);
            // 
            // TestsButton
            // 
            this.TestsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TestsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.TestsButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.TestsButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.TestsButton.BorderRadius = 0;
            this.TestsButton.BorderSize = 0;
            this.TestsButton.FlatAppearance.BorderSize = 0;
            this.TestsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestsButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.TestsButton.ForeColor = System.Drawing.Color.White;
            this.TestsButton.ForegroundColor = System.Drawing.Color.White;
            this.TestsButton.Location = new System.Drawing.Point(25, 378);
            this.TestsButton.Name = "TestsButton";
            this.TestsButton.Size = new System.Drawing.Size(259, 35);
            this.TestsButton.TabIndex = 9;
            this.TestsButton.Text = "Tests";
            this.TestsButton.UseVisualStyleBackColor = false;
            this.TestsButton.Click += new System.EventHandler(this.TestsButton_Click);
            // 
            // GradesButton
            // 
            this.GradesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GradesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.GradesButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.GradesButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.GradesButton.BorderRadius = 0;
            this.GradesButton.BorderSize = 0;
            this.GradesButton.FlatAppearance.BorderSize = 0;
            this.GradesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GradesButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.GradesButton.ForeColor = System.Drawing.Color.White;
            this.GradesButton.ForegroundColor = System.Drawing.Color.White;
            this.GradesButton.Location = new System.Drawing.Point(25, 327);
            this.GradesButton.Name = "GradesButton";
            this.GradesButton.Size = new System.Drawing.Size(259, 35);
            this.GradesButton.TabIndex = 8;
            this.GradesButton.Text = "Grades";
            this.GradesButton.UseVisualStyleBackColor = false;
            this.GradesButton.Click += new System.EventHandler(this.GradesButton_Click);
            // 
            // AbsencesButton
            // 
            this.AbsencesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AbsencesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.AbsencesButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.AbsencesButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.AbsencesButton.BorderRadius = 0;
            this.AbsencesButton.BorderSize = 0;
            this.AbsencesButton.FlatAppearance.BorderSize = 0;
            this.AbsencesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AbsencesButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.AbsencesButton.ForeColor = System.Drawing.Color.White;
            this.AbsencesButton.ForegroundColor = System.Drawing.Color.White;
            this.AbsencesButton.Location = new System.Drawing.Point(25, 276);
            this.AbsencesButton.Name = "AbsencesButton";
            this.AbsencesButton.Size = new System.Drawing.Size(259, 35);
            this.AbsencesButton.TabIndex = 7;
            this.AbsencesButton.Text = "Absences";
            this.AbsencesButton.UseVisualStyleBackColor = false;
            this.AbsencesButton.Click += new System.EventHandler(this.AbsencesButton_Click);
            // 
            // panelFormLoader
            // 
            this.panelFormLoader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFormLoader.BackColor = System.Drawing.Color.Transparent;
            this.panelFormLoader.Location = new System.Drawing.Point(354, 39);
            this.panelFormLoader.Name = "panelFormLoader";
            this.panelFormLoader.Size = new System.Drawing.Size(970, 660);
            this.panelFormLoader.TabIndex = 8;
            // 
            // XButton
            // 
            this.XButton.BackColor = System.Drawing.Color.Transparent;
            this.XButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.XButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.XButton.BorderRadius = 0;
            this.XButton.BorderSize = 0;
            this.XButton.FlatAppearance.BorderSize = 0;
            this.XButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XButton.ForeColor = System.Drawing.Color.White;
            this.XButton.ForegroundColor = System.Drawing.Color.White;
            this.XButton.Location = new System.Drawing.Point(1340, 2);
            this.XButton.Margin = new System.Windows.Forms.Padding(4);
            this.XButton.Name = "XButton";
            this.XButton.Size = new System.Drawing.Size(15, 29);
            this.XButton.TabIndex = 19;
            this.XButton.Text = "X";
            this.XButton.UseVisualStyleBackColor = false;
            this.XButton.Click += new System.EventHandler(this.XButton_Click);
            // 
            // FormTeacher
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1356, 750);
            this.Controls.Add(this.XButton);
            this.Controls.Add(this.panelFormLoader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "FormTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherForm";
            this.Load += new System.EventHandler(this.FormTeacher_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelFormLoader;
        private Interface.CustomButton QuitButton;
        private Interface.CustomButton LogOutButton;
        private Interface.CustomButton LessonsButton;
        private Interface.CustomButton TestsButton;
        private Interface.CustomButton GradesButton;
        private Interface.CustomButton AbsencesButton;
        private System.Windows.Forms.Label label1;
        private Interface.CustomButton XButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}