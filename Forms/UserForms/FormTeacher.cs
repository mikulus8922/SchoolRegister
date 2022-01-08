using School.Data;
using School.Forms.DataForms;
using School.Logics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace School.Forms.UserForms
{
    public partial class FormTeacher : Form
    {
        SystemUsersLogic systemUsersLogic = new SystemUsersLogic();


        public FormTeacher()
        {
            InitializeComponent();
        }

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            DataTable users = systemUsersLogic.ValidateGetUser(UserData.userID);
            Console.WriteLine(users.Rows[0].Field<string>("FirstName"));
            string name = users.Rows[0].Field<string>("FirstName");


            labelHello.Text = $"{name} !";
        }

        private void AbsencesButton_Click(object sender, EventArgs e)
        {
            this.panelFormLoader.Controls.Clear();
            FormAbsences formAbsences = new FormAbsences() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formAbsences.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(formAbsences);
            formAbsences.Show();
        }

        private void GradesButton_Click(object sender, EventArgs e)
        {
            this.panelFormLoader.Controls.Clear();
            FormGrades formGrades = new FormGrades() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formGrades.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(formGrades);
            formGrades.Show();
        }

        private void TestsButton_Click(object sender, EventArgs e)
        {
            this.panelFormLoader.Controls.Clear();
            FormTests formTests = new FormTests() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formTests.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(formTests);
            formTests.Show();
        }

        private void LessonsButton_Click(object sender, EventArgs e)
        {
            this.panelFormLoader.Controls.Clear();
            FormLessons formLessons = new FormLessons() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formLessons.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(formLessons);
            formLessons.Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            /*            UserData.reset();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();*/

        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            FormUserConfirmationDialog dialog = new FormUserConfirmationDialog();
            dialog.Show();
        }

        private void XButton_Click(object sender, EventArgs e)
        {
            FormUserConfirmationDialog dialog = new FormUserConfirmationDialog();
            dialog.Show();
        }
    }
}
