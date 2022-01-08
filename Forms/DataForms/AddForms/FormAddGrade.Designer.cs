
namespace School.Forms.DataForms.AddForms
{
    partial class FormAddGrade
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
            this.comboBoxLessons = new System.Windows.Forms.ComboBox();
            this.comboBoxStudents = new System.Windows.Forms.ComboBox();
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddButton = new School.Interface.CustomButton();
            this.QuitButton = new School.Interface.CustomButton();
            this.SuspendLayout();
            // 
            // comboBoxLessons
            // 
            this.comboBoxLessons.BackColor = System.Drawing.Color.LightCyan;
            this.comboBoxLessons.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxLessons.FormattingEnabled = true;
            this.comboBoxLessons.Location = new System.Drawing.Point(89, 102);
            this.comboBoxLessons.Name = "comboBoxLessons";
            this.comboBoxLessons.Size = new System.Drawing.Size(381, 21);
            this.comboBoxLessons.TabIndex = 0;
            this.comboBoxLessons.SelectedIndexChanged += new System.EventHandler(this.comboBoxLessons_SelectedIndexChanged);
            // 
            // comboBoxStudents
            // 
            this.comboBoxStudents.BackColor = System.Drawing.Color.LightCyan;
            this.comboBoxStudents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxStudents.FormattingEnabled = true;
            this.comboBoxStudents.Location = new System.Drawing.Point(89, 159);
            this.comboBoxStudents.Name = "comboBoxStudents";
            this.comboBoxStudents.Size = new System.Drawing.Size(381, 21);
            this.comboBoxStudents.TabIndex = 1;
            this.comboBoxStudents.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudents_SelectedIndexChanged);
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxGrade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGrade.Font = new System.Drawing.Font("Roboto", 9F);
            this.textBoxGrade.Location = new System.Drawing.Point(89, 221);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(100, 15);
            this.textBoxGrade.TabIndex = 2;
            // 
            // textBoxType
            // 
            this.textBoxType.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxType.Font = new System.Drawing.Font("Roboto", 9F);
            this.textBoxType.Location = new System.Drawing.Point(370, 221);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(100, 15);
            this.textBoxType.TabIndex = 3;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWeight.Font = new System.Drawing.Font("Roboto", 9F);
            this.textBoxWeight.Location = new System.Drawing.Point(230, 221);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 15);
            this.textBoxWeight.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Font = new System.Drawing.Font("Roboto", 9F);
            this.textBoxDescription.Location = new System.Drawing.Point(89, 277);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(381, 56);
            this.textBoxDescription.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.label1.Location = new System.Drawing.Point(217, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Add grade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(43)))));
            this.label2.Location = new System.Drawing.Point(90, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Choose Lesson";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(43)))));
            this.label3.Location = new System.Drawing.Point(90, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Choose Student";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(43)))));
            this.label4.Location = new System.Drawing.Point(90, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "Grade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 9F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(43)))));
            this.label5.Location = new System.Drawing.Point(227, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "Weight";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 9F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(43)))));
            this.label6.Location = new System.Drawing.Point(367, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 9F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(43)))));
            this.label7.Location = new System.Drawing.Point(90, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "Description";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.AddButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.AddButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.AddButton.BorderRadius = 30;
            this.AddButton.BorderSize = 0;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.ForegroundColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(166, 360);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(90, 35);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "Add Grade";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.Transparent;
            this.QuitButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.QuitButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.QuitButton.BorderRadius = 30;
            this.QuitButton.BorderSize = 0;
            this.QuitButton.FlatAppearance.BorderSize = 0;
            this.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.QuitButton.ForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.QuitButton.Location = new System.Drawing.Point(280, 360);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(90, 35);
            this.QuitButton.TabIndex = 15;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // FormAddGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxGrade);
            this.Controls.Add(this.comboBoxStudents);
            this.Controls.Add(this.comboBoxLessons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddGrade";
            this.Load += new System.EventHandler(this.FormAddGrade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLessons;
        private System.Windows.Forms.ComboBox comboBoxStudents;
        private System.Windows.Forms.TextBox textBoxGrade;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Interface.CustomButton QuitButton;
        private Interface.CustomButton AddButton;
    }
}