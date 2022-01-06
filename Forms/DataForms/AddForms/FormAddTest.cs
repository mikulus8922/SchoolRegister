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
            lessons = lessonsLogic.ValidateGetTeacherLessons(UserData.teacherID);
            for (int i = 0; i < lessons.Rows.Count; i++)
            {
                comboBoxLessons.Items.Add(lessons.Rows[i].Field<string>("Name") + " " + lessons.Rows[i].Field<DateTime>("Date"));
            }
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            selectedIndex = comboBoxLessons.SelectedIndex;
            lessonID = lessons.Rows[selectedIndex].Field<int>("LessonID");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string description = textBoxDescription.Text;

            testsLogic.ValidateAddTest(lessonID, description);

            textBoxDescription.Text = "";
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
