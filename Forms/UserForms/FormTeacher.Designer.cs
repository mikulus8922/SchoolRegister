
using System.Drawing;

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
            this.panelDrawer = new System.Windows.Forms.Panel();
            this.labelHello = new System.Windows.Forms.Label();
            this.buttonGrades = new System.Windows.Forms.Button();
            this.buttonAbsences = new System.Windows.Forms.Button();
            this.buttonLessons = new System.Windows.Forms.Button();
            this.buttonTests = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.panelFormLoader = new System.Windows.Forms.Panel();
            this.panelDrawer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDrawer
            // 
            this.panelDrawer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panelDrawer.Controls.Add(this.buttonQuit);
            this.panelDrawer.Controls.Add(this.buttonLogout);
            this.panelDrawer.Controls.Add(this.buttonTests);
            this.panelDrawer.Controls.Add(this.buttonLessons);
            this.panelDrawer.Controls.Add(this.buttonAbsences);
            this.panelDrawer.Controls.Add(this.buttonGrades);
            this.panelDrawer.Controls.Add(this.labelHello);
            this.panelDrawer.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDrawer.Location = new System.Drawing.Point(0, 0);
            this.panelDrawer.Name = "panelDrawer";
            this.panelDrawer.Size = new System.Drawing.Size(266, 768);
            this.panelDrawer.TabIndex = 0;
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Location = new System.Drawing.Point(84, 100);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(68, 13);
            this.labelHello.TabIndex = 1;
            this.labelHello.Text = "Hello {name}";
            // 
            // buttonGrades
            // 
            this.buttonGrades.Location = new System.Drawing.Point(87, 167);
            this.buttonGrades.Name = "buttonGrades";
            this.buttonGrades.Size = new System.Drawing.Size(75, 23);
            this.buttonGrades.TabIndex = 1;
            this.buttonGrades.Text = "Grades";
            this.buttonGrades.UseVisualStyleBackColor = true;
            this.buttonGrades.Click += new System.EventHandler(this.buttonGrades_Click);
            // 
            // buttonAbsences
            // 
            this.buttonAbsences.Location = new System.Drawing.Point(87, 209);
            this.buttonAbsences.Name = "buttonAbsences";
            this.buttonAbsences.Size = new System.Drawing.Size(75, 23);
            this.buttonAbsences.TabIndex = 2;
            this.buttonAbsences.Text = "Absences";
            this.buttonAbsences.UseVisualStyleBackColor = true;
            this.buttonAbsences.Click += new System.EventHandler(this.buttonAbsences_Click);
            // 
            // buttonLessons
            // 
            this.buttonLessons.Location = new System.Drawing.Point(87, 252);
            this.buttonLessons.Name = "buttonLessons";
            this.buttonLessons.Size = new System.Drawing.Size(75, 23);
            this.buttonLessons.TabIndex = 3;
            this.buttonLessons.Text = "Lessons";
            this.buttonLessons.UseVisualStyleBackColor = true;
            this.buttonLessons.Click += new System.EventHandler(this.buttonLessons_Click);
            // 
            // buttonTests
            // 
            this.buttonTests.Location = new System.Drawing.Point(87, 293);
            this.buttonTests.Name = "buttonTests";
            this.buttonTests.Size = new System.Drawing.Size(75, 23);
            this.buttonTests.TabIndex = 2;
            this.buttonTests.Text = "Tests";
            this.buttonTests.UseVisualStyleBackColor = true;
            this.buttonTests.Click += new System.EventHandler(this.buttonTests_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(87, 331);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(88, 373);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(75, 23);
            this.buttonQuit.TabIndex = 4;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // panelFormLoader
            // 
            this.panelFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFormLoader.Location = new System.Drawing.Point(266, 0);
            this.panelFormLoader.Name = "panelFormLoader";
            this.panelFormLoader.Size = new System.Drawing.Size(798, 768);
            this.panelFormLoader.TabIndex = 1;
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1064, 768);
            this.Controls.Add(this.panelFormLoader);
            this.Controls.Add(this.panelDrawer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTeacher";
            this.Load += new System.EventHandler(this.FormTeacher_Load);
            this.panelDrawer.ResumeLayout(false);
            this.panelDrawer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDrawer;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonTests;
        private System.Windows.Forms.Button buttonLessons;
        private System.Windows.Forms.Button buttonAbsences;
        private System.Windows.Forms.Button buttonGrades;
        private System.Windows.Forms.Panel panelFormLoader;
    }
}