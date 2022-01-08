
namespace School.Forms.UserForms
{
    partial class TeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            this.labelHello = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelFormLoader = new System.Windows.Forms.Panel();
            this.AbsencesButton = new School.Interface.CustomButton();
            this.GradesButton = new School.Interface.CustomButton();
            this.TestsButton = new School.Interface.CustomButton();
            this.LessonsButton = new School.Interface.CustomButton();
            this.LogOutButton = new School.Interface.CustomButton();
            this.QuitButton = new School.Interface.CustomButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.BackColor = System.Drawing.Color.Transparent;
            this.labelHello.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHello.ForeColor = System.Drawing.Color.White;
            this.labelHello.Location = new System.Drawing.Point(51, 27);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(99, 19);
            this.labelHello.TabIndex = 0;
            this.labelHello.Text = "Hello {name}";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.QuitButton);
            this.panel1.Controls.Add(this.LogOutButton);
            this.panel1.Controls.Add(this.LessonsButton);
            this.panel1.Controls.Add(this.TestsButton);
            this.panel1.Controls.Add(this.GradesButton);
            this.panel1.Controls.Add(this.AbsencesButton);
            this.panel1.Controls.Add(this.labelHello);
            this.panel1.Location = new System.Drawing.Point(52, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 497);
            this.panel1.TabIndex = 7;
            // 
            // panelFormLoader
            // 
            this.panelFormLoader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFormLoader.BackColor = System.Drawing.Color.Transparent;
            this.panelFormLoader.Location = new System.Drawing.Point(278, 39);
            this.panelFormLoader.Name = "panelFormLoader";
            this.panelFormLoader.Size = new System.Drawing.Size(771, 528);
            this.panelFormLoader.TabIndex = 8;
            // 
            // AbsencesButton
            // 
            this.AbsencesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.AbsencesButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.AbsencesButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.AbsencesButton.BorderRadius = 30;
            this.AbsencesButton.BorderSize = 0;
            this.AbsencesButton.FlatAppearance.BorderSize = 0;
            this.AbsencesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AbsencesButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbsencesButton.ForeColor = System.Drawing.Color.White;
            this.AbsencesButton.ForegroundColor = System.Drawing.Color.White;
            this.AbsencesButton.Location = new System.Drawing.Point(24, 123);
            this.AbsencesButton.Name = "AbsencesButton";
            this.AbsencesButton.Size = new System.Drawing.Size(150, 35);
            this.AbsencesButton.TabIndex = 7;
            this.AbsencesButton.Text = "Absences";
            this.AbsencesButton.UseVisualStyleBackColor = false;
            this.AbsencesButton.Click += new System.EventHandler(this.AbsencesButton_Click);
            // 
            // GradesButton
            // 
            this.GradesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.GradesButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.GradesButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.GradesButton.BorderRadius = 30;
            this.GradesButton.BorderSize = 0;
            this.GradesButton.FlatAppearance.BorderSize = 0;
            this.GradesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GradesButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradesButton.ForeColor = System.Drawing.Color.White;
            this.GradesButton.ForegroundColor = System.Drawing.Color.White;
            this.GradesButton.Location = new System.Drawing.Point(24, 174);
            this.GradesButton.Name = "GradesButton";
            this.GradesButton.Size = new System.Drawing.Size(150, 35);
            this.GradesButton.TabIndex = 8;
            this.GradesButton.Text = "Grades";
            this.GradesButton.UseVisualStyleBackColor = false;
            this.GradesButton.Click += new System.EventHandler(this.GradesButton_Click_1);
            // 
            // TestsButton
            // 
            this.TestsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.TestsButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.TestsButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.TestsButton.BorderRadius = 30;
            this.TestsButton.BorderSize = 0;
            this.TestsButton.FlatAppearance.BorderSize = 0;
            this.TestsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestsButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestsButton.ForeColor = System.Drawing.Color.White;
            this.TestsButton.ForegroundColor = System.Drawing.Color.White;
            this.TestsButton.Location = new System.Drawing.Point(24, 225);
            this.TestsButton.Name = "TestsButton";
            this.TestsButton.Size = new System.Drawing.Size(150, 35);
            this.TestsButton.TabIndex = 9;
            this.TestsButton.Text = "Tests";
            this.TestsButton.UseVisualStyleBackColor = false;
            this.TestsButton.Click += new System.EventHandler(this.TestsButton_Click);
            // 
            // LessonsButton
            // 
            this.LessonsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.LessonsButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.LessonsButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.LessonsButton.BorderRadius = 30;
            this.LessonsButton.BorderSize = 0;
            this.LessonsButton.FlatAppearance.BorderSize = 0;
            this.LessonsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LessonsButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LessonsButton.ForeColor = System.Drawing.Color.White;
            this.LessonsButton.ForegroundColor = System.Drawing.Color.White;
            this.LessonsButton.Location = new System.Drawing.Point(24, 279);
            this.LessonsButton.Name = "LessonsButton";
            this.LessonsButton.Size = new System.Drawing.Size(150, 35);
            this.LessonsButton.TabIndex = 10;
            this.LessonsButton.Text = "Lessons";
            this.LessonsButton.UseVisualStyleBackColor = false;
            this.LessonsButton.Click += new System.EventHandler(this.LessonsButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.White;
            this.LogOutButton.BackgroundColor = System.Drawing.Color.White;
            this.LogOutButton.BorderColor = System.Drawing.Color.White;
            this.LogOutButton.BorderRadius = 30;
            this.LogOutButton.BorderSize = 0;
            this.LogOutButton.FlatAppearance.BorderSize = 0;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(43)))));
            this.LogOutButton.ForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(43)))));
            this.LogOutButton.Location = new System.Drawing.Point(3, 459);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(90, 35);
            this.LogOutButton.TabIndex = 11;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.White;
            this.QuitButton.BackgroundColor = System.Drawing.Color.White;
            this.QuitButton.BorderColor = System.Drawing.Color.White;
            this.QuitButton.BorderRadius = 30;
            this.QuitButton.BorderSize = 0;
            this.QuitButton.FlatAppearance.BorderSize = 0;
            this.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(43)))));
            this.QuitButton.ForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(43)))));
            this.QuitButton.Location = new System.Drawing.Point(105, 459);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(90, 35);
            this.QuitButton.TabIndex = 12;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // TeacherForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1080, 600);
            this.Controls.Add(this.panelFormLoader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1080, 600);
            this.MinimumSize = new System.Drawing.Size(1080, 600);
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}