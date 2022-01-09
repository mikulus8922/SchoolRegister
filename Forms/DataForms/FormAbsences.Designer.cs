
namespace School.Forms.DataForms
{
    partial class FormAbsences
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.comboBoxClasses = new System.Windows.Forms.ComboBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.checkBoxIsExcused = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteButton = new School.Interface.CustomButton();
            this.ModifyButton = new School.Interface.CustomButton();
            this.AddButton = new School.Interface.CustomButton();
            this.ResetButton = new School.Interface.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.dataGridView.Location = new System.Drawing.Point(22, 125);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(930, 335);
            this.dataGridView.TabIndex = 11;
            this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
            // 
            // comboBoxClasses
            // 
            this.comboBoxClasses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(146)))));
            this.comboBoxClasses.DropDownWidth = 295;
            this.comboBoxClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxClasses.Font = new System.Drawing.Font("Roboto", 10F);
            this.comboBoxClasses.ForeColor = System.Drawing.Color.White;
            this.comboBoxClasses.FormattingEnabled = true;
            this.comboBoxClasses.Location = new System.Drawing.Point(21, 93);
            this.comboBoxClasses.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxClasses.Name = "comboBoxClasses";
            this.comboBoxClasses.Size = new System.Drawing.Size(295, 28);
            this.comboBoxClasses.TabIndex = 2;
            this.comboBoxClasses.SelectedIndexChanged += new System.EventHandler(this.comboBoxClasses_SelectedIndexChanged);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(40)))));
            this.textBoxDescription.Location = new System.Drawing.Point(21, 550);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(931, 62);
            this.textBoxDescription.TabIndex = 10;
            // 
            // checkBoxIsExcused
            // 
            this.checkBoxIsExcused.AutoSize = true;
            this.checkBoxIsExcused.BackColor = System.Drawing.Color.White;
            this.checkBoxIsExcused.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.checkBoxIsExcused.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxIsExcused.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIsExcused.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.checkBoxIsExcused.Location = new System.Drawing.Point(21, 474);
            this.checkBoxIsExcused.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxIsExcused.Name = "checkBoxIsExcused";
            this.checkBoxIsExcused.Size = new System.Drawing.Size(110, 24);
            this.checkBoxIsExcused.TabIndex = 13;
            this.checkBoxIsExcused.Text = "Is Excused";
            this.checkBoxIsExcused.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.label5.Location = new System.Drawing.Point(18, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 33);
            this.label5.TabIndex = 32;
            this.label5.Text = "Absences";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(40)))));
            this.label6.Location = new System.Drawing.Point(20, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Choose Class";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(21, 520);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Description";
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(146)))));
            this.DeleteButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(146)))));
            this.DeleteButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(146)))));
            this.DeleteButton.BorderRadius = 0;
            this.DeleteButton.BorderSize = 0;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.ForegroundColor = System.Drawing.Color.White;
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteButton.Location = new System.Drawing.Point(802, 474);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DeleteButton.Size = new System.Drawing.Size(150, 35);
            this.DeleteButton.TabIndex = 37;
            this.DeleteButton.Text = "Delete Absence";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ModifyButton
            // 
            this.ModifyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(146)))));
            this.ModifyButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(146)))));
            this.ModifyButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(146)))));
            this.ModifyButton.BorderRadius = 0;
            this.ModifyButton.BorderSize = 0;
            this.ModifyButton.FlatAppearance.BorderSize = 0;
            this.ModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifyButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.ModifyButton.ForeColor = System.Drawing.Color.White;
            this.ModifyButton.ForegroundColor = System.Drawing.Color.White;
            this.ModifyButton.Location = new System.Drawing.Point(635, 474);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(150, 35);
            this.ModifyButton.TabIndex = 36;
            this.ModifyButton.Text = "Modify Absence";
            this.ModifyButton.UseVisualStyleBackColor = false;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(146)))));
            this.AddButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(146)))));
            this.AddButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(146)))));
            this.AddButton.BorderRadius = 0;
            this.AddButton.BorderSize = 0;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.ForegroundColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(465, 474);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(150, 35);
            this.AddButton.TabIndex = 35;
            this.AddButton.Text = "Add Absence";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Transparent;
            this.ResetButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.ResetButton.BorderColor = System.Drawing.Color.Transparent;
            this.ResetButton.BorderRadius = 0;
            this.ResetButton.BorderSize = 0;
            this.ResetButton.FlatAppearance.BorderSize = 0;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.ResetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(146)))));
            this.ResetButton.ForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(146)))));
            this.ResetButton.Location = new System.Drawing.Point(331, 89);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(78, 30);
            this.ResetButton.TabIndex = 38;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // FormAbsences
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(970, 660);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxIsExcused);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.comboBoxClasses);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAbsences";
            this.Text = "FormGrades";
            this.Load += new System.EventHandler(this.FormAbsences_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox comboBoxClasses;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.CheckBox checkBoxIsExcused;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private Interface.CustomButton DeleteButton;
        private Interface.CustomButton ModifyButton;
        private Interface.CustomButton AddButton;
        private Interface.CustomButton ResetButton;
    }
}