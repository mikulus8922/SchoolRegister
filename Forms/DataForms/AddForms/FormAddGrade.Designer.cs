
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
            this.XButton = new School.Interface.CustomButton();
            this.SuspendLayout();
            // 
            // comboBoxLessons
            // 
            this.comboBoxLessons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(146)))));
            this.comboBoxLessons.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxLessons.Font = new System.Drawing.Font("Roboto", 10F);
            this.comboBoxLessons.ForeColor = System.Drawing.Color.White;
            this.comboBoxLessons.FormattingEnabled = true;
            this.comboBoxLessons.Location = new System.Drawing.Point(119, 126);
            this.comboBoxLessons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxLessons.Name = "comboBoxLessons";
            this.comboBoxLessons.Size = new System.Drawing.Size(507, 28);
            this.comboBoxLessons.TabIndex = 0;
            this.comboBoxLessons.SelectedIndexChanged += new System.EventHandler(this.comboBoxLessons_SelectedIndexChanged);
            // 
            // comboBoxStudents
            // 
            this.comboBoxStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(146)))));
            this.comboBoxStudents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxStudents.Font = new System.Drawing.Font("Roboto", 10F);
            this.comboBoxStudents.ForeColor = System.Drawing.Color.White;
            this.comboBoxStudents.FormattingEnabled = true;
            this.comboBoxStudents.Location = new System.Drawing.Point(119, 196);
            this.comboBoxStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxStudents.Name = "comboBoxStudents";
            this.comboBoxStudents.Size = new System.Drawing.Size(507, 28);
            this.comboBoxStudents.TabIndex = 1;
            this.comboBoxStudents.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudents_SelectedIndexChanged);
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.textBoxGrade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGrade.Font = new System.Drawing.Font("Roboto", 9F);
            this.textBoxGrade.Location = new System.Drawing.Point(119, 272);
            this.textBoxGrade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(133, 19);
            this.textBoxGrade.TabIndex = 2;
            // 
            // textBoxType
            // 
            this.textBoxType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.textBoxType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxType.Font = new System.Drawing.Font("Roboto", 9F);
            this.textBoxType.Location = new System.Drawing.Point(493, 272);
            this.textBoxType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(133, 19);
            this.textBoxType.TabIndex = 3;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.textBoxWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWeight.Font = new System.Drawing.Font("Roboto", 9F);
            this.textBoxWeight.Location = new System.Drawing.Point(307, 272);
            this.textBoxWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(133, 19);
            this.textBoxWeight.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Font = new System.Drawing.Font("Roboto", 9F);
            this.textBoxDescription.Location = new System.Drawing.Point(119, 341);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(508, 69);
            this.textBoxDescription.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.label1.Location = new System.Drawing.Point(302, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Add grade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Roboto", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(120, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Choose Lesson";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Roboto", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(120, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Choose Student";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Roboto", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(120, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Grade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Roboto", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(40)))));
            this.label5.Location = new System.Drawing.Point(303, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Weight";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Roboto", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(40)))));
            this.label6.Location = new System.Drawing.Point(489, 247);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Roboto", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(40)))));
            this.label7.Location = new System.Drawing.Point(120, 316);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Description";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(146)))));
            this.AddButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(146)))));
            this.AddButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.AddButton.BorderRadius = 0;
            this.AddButton.BorderSize = 0;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.ForegroundColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(239, 443);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(120, 43);
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
            this.QuitButton.BorderRadius = 0;
            this.QuitButton.BorderSize = 0;
            this.QuitButton.FlatAppearance.BorderSize = 0;
            this.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(146)))));
            this.QuitButton.ForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(146)))));
            this.QuitButton.Location = new System.Drawing.Point(373, 443);
            this.QuitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(120, 43);
            this.QuitButton.TabIndex = 15;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
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
            this.XButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(146)))));
            this.XButton.ForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(146)))));
            this.XButton.Location = new System.Drawing.Point(676, 13);
            this.XButton.Margin = new System.Windows.Forms.Padding(4);
            this.XButton.Name = "XButton";
            this.XButton.Size = new System.Drawing.Size(41, 29);
            this.XButton.TabIndex = 17;
            this.XButton.Text = "X";
            this.XButton.UseVisualStyleBackColor = false;
            this.XButton.Click += new System.EventHandler(this.XButton_Click);
            // 
            // FormAddGrade
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(730, 530);
            this.Controls.Add(this.XButton);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAddGrade";
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
        private Interface.CustomButton XButton;
    }
}