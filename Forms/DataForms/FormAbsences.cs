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
using School.Data;
using School.Forms.DataForms.AddForms;

namespace School.Forms.DataForms
{
    public partial class FormAbsences : Form
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

        public FormAbsences()
        {
            InitializeComponent();
        }

        private void FormGrades_Load(object sender, EventArgs e)
        {
            lessons = lessonsLogic.ValidateGetTeacherLessons(UserData.teacherID);

            for (int i = 0; i < classes.Rows.Count; i++)
            {
                comboBoxStudents.Items.Add(classes.Rows[i].Field<string>("Name"));
            }

            grades = gradesLogic.ValidateGetTeacherGrades(UserData.teacherID);
            dataGridView.DataSource = grades;
        }

        private void comboBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectedIndex = comboBoxStudents.SelectedIndex;
            int classID = classes.Rows[selectedIndex].Field<int>("ClassID");
            students = studentsLogic.ValidateGetStudents(classID);

            grades = gradesLogic.ValidateGetClassTeacherGrades(classID, UserData.teacherID);
            dataGridView.DataSource = grades;

        }


        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedIndex = dataGridView.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView.Rows[selectedIndex];
            textBoxGrade.Text = row.Cells[2].Value.ToString();
            textBoxWeight.Text = row.Cells[3].Value.ToString();
            textBoxType.Text = row.Cells[5].Value.ToString();
            textBoxDescription.Text = row.Cells[7].Value.ToString();

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

            grades = gradesLogic.ValidateGetTeacherGrades(UserData.teacherID);
            dataGridView.DataSource = grades;


            buttonModify.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int gradeID = grades.Rows[selectedIndex].Field<int>("GradeID");

            bool message = gradesLogic.ValidateRemoveGrade(gradeID);

            Console.WriteLine(message);

            grades = gradesLogic.ValidateGetTeacherGrades(UserData.teacherID);
            dataGridView.DataSource = grades;

            buttonModify.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddGrade formAddGrade = new FormAddGrade();
            formAddGrade.Show();

        }
    }
}
