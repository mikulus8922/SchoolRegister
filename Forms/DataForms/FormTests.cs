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

namespace School.Forms.DataForms
{
    public partial class FormTests : Form
    {

        DataTable grades;
        DataTable classes;
        DataTable students;
        DataTable lessons;

        GradesLogic gradesLogic = new GradesLogic();
        ClassesLogic classesLogic = new ClassesLogic();
        StudentsLogic studentsLogic = new StudentsLogic();
        LessonsLogic lessonsLogic = new LessonsLogic();

        int selectedIndex;

        string whatToSelect = "all";

        public FormTests()
        {
            InitializeComponent();
        }

        private void FormGrades_Load(object sender, EventArgs e)
        {

            classes = classesLogic.ValidateGetClasses();
            for (int i = 0; i < classes.Rows.Count; i++)
            {
                comboBoxClasses.Items.Add(classes.Rows[i].Field<string>("Name"));
            }

            students = studentsLogic.ValidateGetStudents();
            for (int i = 0; i < students.Rows.Count; i++)
            {
                comboBoxStudents.Items.Add(students.Rows[i].Field<string>("FirstName") + " " + students.Rows[i].Field<string>("LastName"));
                comboBoxSelectStudent.Items.Add(students.Rows[i].Field<string>("FirstName") + " " + students.Rows[i].Field<string>("LastName"));

            }

            lessons = lessonsLogic.ValidateGetTeacherLessons(Data.UserData.teacherID);
            for (int i = 0; i < lessons.Rows.Count; i++)
            {
                comboBoxSelectLesson.Items.Add(lessons.Rows[i].Field<string>("Name") + " " + lessons.Rows[i].Field<DateTime>("Date"));
            }



            /*            grades = gradesLogic.ValidateGetGrades();
                        dataGridView.DataSource = grades;*/
        }

        private void comboBoxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxStudents.Items.Clear();
            comboBoxSelectStudent.Items.Clear();

            selectedIndex = comboBoxClasses.SelectedIndex;
            int classID = classes.Rows[selectedIndex].Field<int>("ClassID");
            students = studentsLogic.ValidateGetStudents(classID);
            for (int i = 0; i < students.Rows.Count; i++)
            {
                comboBoxStudents.Items.Add(students.Rows[i].Field<string>("FirstName") + " " + students.Rows[i].Field<string>("LastName"));
                comboBoxSelectStudent.Items.Add(students.Rows[i].Field<string>("FirstName") + " " + students.Rows[i].Field<string>("LastName"));

            }

            grades = gradesLogic.ValidateGetClassGrades(classID);
            dataGridView.DataSource = grades;
            whatToSelect = "class";

        }

        private void comboBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = comboBoxStudents.SelectedIndex;
            int studentID = students.Rows[selectedIndex].Field<int>("StudentID");

            grades = gradesLogic.ValidateGetStudentGrades(studentID);
            dataGridView.DataSource = grades;
            whatToSelect = "student";
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedIndex = dataGridView.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView.Rows[selectedIndex];
            textBoxGrade.Text = row.Cells[2].Value.ToString();
            textBoxWeight.Text = row.Cells[3].Value.ToString();
            textBoxType.Text = row.Cells[5].Value.ToString();
            textBoxDescription.Text = row.Cells[7].Value.ToString();
            comboBoxSelectStudent.SelectedIndex = comboBoxStudents.SelectedIndex;

            Console.WriteLine(selectedIndex);

            buttonModify.Enabled = true;
            buttonDelete.Enabled = true;
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            int gradeID = grades.Rows[selectedIndex].Field<int>("GradeID");


            int grade = int.Parse(textBoxGrade.Text);
            int weight = int.Parse(textBoxWeight.Text);
            string type = textBoxType.Text;
            string description = textBoxDescription.Text;


            bool message = gradesLogic.ValidateEditGrade(gradeID, grade, weight, type, description);

            Console.WriteLine(message);

            grades = gradesLogic.ValidateGetGrades();
            dataGridView.DataSource = grades;


            buttonModify.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int gradeID = grades.Rows[selectedIndex].Field<int>("GradeID");

            bool message = gradesLogic.ValidateRemoveGrade(gradeID);

            Console.WriteLine(message);

            grades = gradesLogic.ValidateGetGrades();
            dataGridView.DataSource = grades;

            buttonModify.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int studentID = students.Rows[comboBoxSelectStudent.SelectedIndex].Field<int>("StudentID");
            int lessonID = lessons.Rows[comboBoxSelectLesson.SelectedIndex].Field<int>("LessonID");
            int grade = int.Parse(textBoxGrade.Text);
            int weight = int.Parse(textBoxWeight.Text);
            string type = textBoxType.Text;
            string description = textBoxDescription.Text;

            Console.WriteLine("Student: " + studentID);
            Console.WriteLine("Lekcja: " + lessonID);
            Console.WriteLine("grade: " + grade);
            Console.WriteLine("weight: " + weight);
            Console.WriteLine("type: " + type);
            Console.WriteLine("description: " + description);


            gradesLogic.ValidateAddGrade(studentID, lessonID, grade, weight, type, description);
        }
    }
}
