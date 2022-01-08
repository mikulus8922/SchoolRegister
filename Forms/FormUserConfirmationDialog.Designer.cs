
namespace School.Forms
{
    partial class FormUserConfirmationDialog
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
            this.XButton = new School.Interface.CustomButton();
            this.YesButton = new School.Interface.CustomButton();
            this.NoButton = new School.Interface.CustomButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.XButton.Location = new System.Drawing.Point(358, 13);
            this.XButton.Margin = new System.Windows.Forms.Padding(4);
            this.XButton.Name = "XButton";
            this.XButton.Size = new System.Drawing.Size(41, 29);
            this.XButton.TabIndex = 18;
            this.XButton.Text = "X";
            this.XButton.UseVisualStyleBackColor = false;
            this.XButton.Click += new System.EventHandler(this.XButton_Click);
            // 
            // YesButton
            // 
            this.YesButton.BackColor = System.Drawing.Color.White;
            this.YesButton.BackgroundColor = System.Drawing.Color.White;
            this.YesButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.YesButton.BorderRadius = 0;
            this.YesButton.BorderSize = 0;
            this.YesButton.FlatAppearance.BorderSize = 0;
            this.YesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YesButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(40)))));
            this.YesButton.ForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(40)))));
            this.YesButton.Location = new System.Drawing.Point(69, 220);
            this.YesButton.Margin = new System.Windows.Forms.Padding(4);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(150, 43);
            this.YesButton.TabIndex = 20;
            this.YesButton.Text = "Yes, I want to quit";
            this.YesButton.UseVisualStyleBackColor = false;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.BackColor = System.Drawing.Color.Transparent;
            this.NoButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.NoButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.NoButton.BorderRadius = 0;
            this.NoButton.BorderSize = 0;
            this.NoButton.FlatAppearance.BorderSize = 0;
            this.NoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoButton.ForeColor = System.Drawing.Color.White;
            this.NoButton.ForegroundColor = System.Drawing.Color.White;
            this.NoButton.Location = new System.Drawing.Point(233, 220);
            this.NoButton.Margin = new System.Windows.Forms.Padding(4);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(120, 43);
            this.NoButton.TabIndex = 19;
            this.NoButton.Text = "No, I don\'t";
            this.NoButton.UseVisualStyleBackColor = false;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(216)))), ((int)(((byte)(210)))));
            this.label1.Location = new System.Drawing.Point(45, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Are you sure you want to quit?";
            // 
            // FormUserConfirmationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(412, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.XButton);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUserConfirmationDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUserConfirmationDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Interface.CustomButton XButton;
        private Interface.CustomButton YesButton;
        private Interface.CustomButton NoButton;
        private System.Windows.Forms.Label label1;
    }
}