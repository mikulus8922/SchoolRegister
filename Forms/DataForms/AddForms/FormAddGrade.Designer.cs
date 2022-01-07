
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxLessons
            // 
            this.comboBoxLessons.FormattingEnabled = true;
            this.comboBoxLessons.Location = new System.Drawing.Point(98, 70);
            this.comboBoxLessons.Name = "comboBoxLessons";
            this.comboBoxLessons.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLessons.TabIndex = 0;
            this.comboBoxLessons.SelectedIndexChanged += new System.EventHandler(this.comboBoxLessons_SelectedIndexChanged);
            // 
            // comboBoxStudents
            // 
            this.comboBoxStudents.FormattingEnabled = true;
            this.comboBoxStudents.Location = new System.Drawing.Point(98, 126);
            this.comboBoxStudents.Name = "comboBoxStudents";
            this.comboBoxStudents.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStudents.TabIndex = 1;
            this.comboBoxStudents.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudents_SelectedIndexChanged);
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.Location = new System.Drawing.Point(379, 81);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(100, 20);
            this.textBoxGrade.TabIndex = 2;
            this.textBoxGrade.Text = "Grade";
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(379, 127);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(100, 20);
            this.textBoxType.TabIndex = 3;
            this.textBoxType.Text = "Type";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(515, 81);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeight.TabIndex = 4;
            this.textBoxWeight.Text = "Weight";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(515, 127);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescription.TabIndex = 5;
            this.textBoxDescription.Text = "Description";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(168, 370);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "buttonAdd";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(531, 370);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(75, 23);
            this.buttonQuit.TabIndex = 7;
            this.buttonQuit.Text = "buttonQuit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // FormAddGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxGrade);
            this.Controls.Add(this.comboBoxStudents);
            this.Controls.Add(this.comboBoxLessons);
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
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonQuit;
    }
}