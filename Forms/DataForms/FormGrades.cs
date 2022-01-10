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
    public partial class FormGrades : Form
    {

        DataTable grades;
        DataTable classes;
        DataTable students;
        //DataTable lessons;

        GradesLogic gradesLogic = new GradesLogic();
        ClassesLogic classesLogic = new ClassesLogic();
        StudentsLogic studentsLogic = new StudentsLogic();
        //LessonsLogic lessonsLogic = new LessonsLogic();


        int selectedIndex;

        public FormGrades()
        {
            InitializeComponent();
        }

        private void FormGrades_Load(object sender, EventArgs e)
        {
            comboBoxClasses.Items.Clear();
            classes = classesLogic.ValidateGetClasses();
            for (int i = 0; i < classes.Rows.Count; i++)
            {
                comboBoxClasses.Items.Add(classes.Rows[i].Field<string>("Name"));
            }

            grades = gradesLogic.ValidateGetTeacherGrades(UserData.teacherID);
            DataTable gradesData = grades.Copy();
            gradesData.Columns.RemoveAt(8);
            gradesData.Columns.RemoveAt(8);
            gradesData.Columns.RemoveAt(8);

            dataGridView.DataSource = gradesData;
        }

        private void comboBoxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectedIndex = comboBoxClasses.SelectedIndex;
            int classID = classes.Rows[selectedIndex].Field<int>("ClassID");
            students = studentsLogic.ValidateGetStudents(classID);

            grades = gradesLogic.ValidateGetClassTeacherGrades(classID, UserData.teacherID);
            DataTable gradesData = grades.Copy();
            gradesData.Columns.RemoveAt(8);
            gradesData.Columns.RemoveAt(8);
            gradesData.Columns.RemoveAt(8);
            dataGridView.DataSource = gradesData;

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

            ModifyButton.Enabled = true;
            DeleteButton.Enabled = true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            FormAddGrade formAddGrade = new FormAddGrade();
            formAddGrade.Show();
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            int gradeID = grades.Rows[selectedIndex].Field<int>("GradeID");

            int grade = int.Parse(textBoxGrade.Text);
            int weight = int.Parse(textBoxWeight.Text);
            string type = textBoxType.Text;
            string description = textBoxDescription.Text;


            if (!gradesLogic.ValidateEditGrade(gradeID, grade, weight, type, description))
            {
                FormErrorDialog formErrorDialog = new FormErrorDialog();
                formErrorDialog.Show();
            }


            grades = gradesLogic.ValidateGetTeacherGrades(UserData.teacherID);
            DataTable gradesData = grades.Copy();
            gradesData.Columns.RemoveAt(8);
            gradesData.Columns.RemoveAt(8);
            gradesData.Columns.RemoveAt(8);
            dataGridView.DataSource = gradesData;


            ModifyButton.Enabled = false;
            DeleteButton.Enabled = false;

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int gradeID = grades.Rows[selectedIndex].Field<int>("GradeID");

            if (!gradesLogic.ValidateRemoveGrade(gradeID))
            {
                FormErrorDialog formErrorDialog = new FormErrorDialog();
                formErrorDialog.Show();
            }



            grades = gradesLogic.ValidateGetTeacherGrades(UserData.teacherID);
            DataTable gradesData = grades.Copy();
            gradesData.Columns.RemoveAt(8);
            gradesData.Columns.RemoveAt(8);
            gradesData.Columns.RemoveAt(8);
            dataGridView.DataSource = gradesData;

            ModifyButton.Enabled = false;
            DeleteButton.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            FormGrades_Load(sender, e);
        }
    }
}
