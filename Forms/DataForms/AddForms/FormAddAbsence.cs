using School.Data;
using School.Logics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School.Forms.DataForms.AddForms
{
    public partial class FormAddAbsence : Form
    {
        DataTable lessons;
        DataTable students;

        LessonsLogic lessonsLogic = new LessonsLogic();
        StudentsLogic studentsLogic = new StudentsLogic();
        AbsencesLogic absencesLogic = new AbsencesLogic();

        int lessonID;
        int studentID;
        int classID;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
           );


        public FormAddAbsence()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void FormAddGrade_Load(object sender, EventArgs e)
        {
            lessons = lessonsLogic.ValidateGetTeacherLessons(UserData.teacherID);

            for (int i = 0; i < lessons.Rows.Count; i++)
            {
                comboBoxLessons.Items.Add(lessons.Rows[i].Field<string>("Name") + " " + lessons.Rows[i].Field<DateTime>("Date"));
            }
        }

        private void comboBoxLessons_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxStudents.Items.Clear();

            int comboBoxIndex = comboBoxLessons.SelectedIndex;
            lessonID = lessons.Rows[comboBoxIndex].Field<int>("LessonID");
            classID = lessons.Rows[comboBoxIndex].Field<int>("ClassID");

            students = studentsLogic.ValidateGetStudents(classID);
            for (int i = 0; i < students.Rows.Count; i++)
            {
                comboBoxStudents.Items.Add(students.Rows[i].Field<string>("FirstName") + " " + students.Rows[i].Field<string>("LastName"));
            }
        }

        private void comboBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            int comboBoxIndex = comboBoxStudents.SelectedIndex;
            studentID = students.Rows[comboBoxIndex].Field<int>("StudentID");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            bool isExcused = checkBoxIsExcused.Checked;
            string description = textBoxDescription.Text;

            absencesLogic.ValidateAddAbsence(studentID, lessonID, isExcused, description);

            checkBoxIsExcused.Checked = false;
            textBoxDescription.Text = "";
            comboBoxStudents.Items.Clear();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
