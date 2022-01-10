using School.Data;
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

namespace School.Forms.DataForms.AddForms
{
    public partial class FormAddTest : Form
    {
        DataTable lessons;

        LessonsLogic lessonsLogic = new LessonsLogic();
        TestsLogic testsLogic = new TestsLogic();

        int selectedIndex;

        int lessonID;

        public FormAddTest()
        {
            InitializeComponent();
        }

        private void FormAddTest_Load(object sender, EventArgs e)
        {
            comboBoxLessons.Items.Clear();
            lessons = lessonsLogic.ValidateGetTeacherLessons(UserData.teacherID);
            for (int i = 0; i < lessons.Rows.Count; i++)
            {
                comboBoxLessons.Items.Add(lessons.Rows[i].Field<string>("Class") + " " + lessons.Rows[i].Field<DateTime>("Date"));
            }
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            selectedIndex = comboBoxLessons.SelectedIndex;
            lessonID = lessons.Rows[selectedIndex].Field<int>("LessonID");
        }


        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string description = textBoxDescription.Text;

            if( !testsLogic.ValidateAddTest(lessonID, description))
            {
                FormErrorDialog formErrorDialog = new FormErrorDialog();
                formErrorDialog.Show();
            }

            textBoxDescription.Text = "";
        }

        private void XButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
