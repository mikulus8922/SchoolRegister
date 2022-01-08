
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
            this.buttonAbsences = new System.Windows.Forms.Button();
            this.buttonGrades = new System.Windows.Forms.Button();
            this.buttonLessons = new System.Windows.Forms.Button();
            this.buttonTests = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelFormLoader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.BackColor = System.Drawing.Color.Transparent;
            this.labelHello.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHello.ForeColor = System.Drawing.Color.White;
            this.labelHello.Location = new System.Drawing.Point(36, 18);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(123, 24);
            this.labelHello.TabIndex = 0;
            this.labelHello.Text = "Hello {name}";
            // 
            // buttonAbsences
            // 
            this.buttonAbsences.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.buttonAbsences.Font = new System.Drawing.Font("Roboto", 10F);
            this.buttonAbsences.ForeColor = System.Drawing.Color.White;
            this.buttonAbsences.Location = new System.Drawing.Point(22, 81);
            this.buttonAbsences.Name = "buttonAbsences";
            this.buttonAbsences.Size = new System.Drawing.Size(150, 40);
            this.buttonAbsences.TabIndex = 1;
            this.buttonAbsences.Text = "Absences";
            this.buttonAbsences.UseVisualStyleBackColor = false;
            // 
            // buttonGrades
            // 
            this.buttonGrades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.buttonGrades.Font = new System.Drawing.Font("Roboto", 10F);
            this.buttonGrades.ForeColor = System.Drawing.Color.White;
            this.buttonGrades.Location = new System.Drawing.Point(22, 137);
            this.buttonGrades.Name = "buttonGrades";
            this.buttonGrades.Size = new System.Drawing.Size(150, 40);
            this.buttonGrades.TabIndex = 2;
            this.buttonGrades.Text = "Grades";
            this.buttonGrades.UseVisualStyleBackColor = false;
            this.buttonGrades.Click += new System.EventHandler(this.buttonGrades_Click);
            // 
            // buttonLessons
            // 
            this.buttonLessons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.buttonLessons.Font = new System.Drawing.Font("Roboto", 10F);
            this.buttonLessons.ForeColor = System.Drawing.Color.White;
            this.buttonLessons.Location = new System.Drawing.Point(22, 192);
            this.buttonLessons.Name = "buttonLessons";
            this.buttonLessons.Size = new System.Drawing.Size(150, 40);
            this.buttonLessons.TabIndex = 3;
            this.buttonLessons.Text = "Lessons";
            this.buttonLessons.UseVisualStyleBackColor = false;
            // 
            // buttonTests
            // 
            this.buttonTests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.buttonTests.Font = new System.Drawing.Font("Roboto", 10F);
            this.buttonTests.ForeColor = System.Drawing.Color.White;
            this.buttonTests.Location = new System.Drawing.Point(22, 248);
            this.buttonTests.Name = "buttonTests";
            this.buttonTests.Size = new System.Drawing.Size(150, 40);
            this.buttonTests.TabIndex = 4;
            this.buttonTests.Text = "Tests";
            this.buttonTests.UseVisualStyleBackColor = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.White;
            this.buttonLogout.Font = new System.Drawing.Font("Roboto", 10F);
            this.buttonLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(8)))), ((int)(((byte)(46)))));
            this.buttonLogout.Location = new System.Drawing.Point(5, 445);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(90, 40);
            this.buttonLogout.TabIndex = 5;
            this.buttonLogout.Text = "Log Out";
            this.buttonLogout.UseVisualStyleBackColor = false;
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.Color.White;
            this.buttonQuit.Font = new System.Drawing.Font("Roboto", 10F);
            this.buttonQuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(8)))), ((int)(((byte)(46)))));
            this.buttonQuit.Location = new System.Drawing.Point(106, 445);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(90, 40);
            this.buttonQuit.TabIndex = 6;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.labelHello);
            this.panel1.Controls.Add(this.buttonQuit);
            this.panel1.Controls.Add(this.buttonAbsences);
            this.panel1.Controls.Add(this.buttonLogout);
            this.panel1.Controls.Add(this.buttonGrades);
            this.panel1.Controls.Add(this.buttonTests);
            this.panel1.Controls.Add(this.buttonLessons);
            this.panel1.Location = new System.Drawing.Point(52, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 497);
            this.panel1.TabIndex = 7;
            // 
            // panelFormLoader
            // 
            this.panelFormLoader.BackColor = System.Drawing.Color.Transparent;
            this.panelFormLoader.Location = new System.Drawing.Point(278, 39);
            this.panelFormLoader.Name = "panelFormLoader";
            this.panelFormLoader.Size = new System.Drawing.Size(770, 530);
            this.panelFormLoader.TabIndex = 8;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1082, 598);
            this.Controls.Add(this.panelFormLoader);
            this.Controls.Add(this.panel1);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Button buttonAbsences;
        private System.Windows.Forms.Button buttonGrades;
        private System.Windows.Forms.Button buttonLessons;
        private System.Windows.Forms.Button buttonTests;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelFormLoader;
    }
}