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
    public partial class FormTests : Form
    {

        DataTable grades;
        DataTable classes;
        DataTable students;
        DataTable tests;
        DataTable lessons;

        GradesLogic gradesLogic = new GradesLogic();
        ClassesLogic classesLogic = new ClassesLogic();
        StudentsLogic studentsLogic = new StudentsLogic();
        TestsLogic testsLogic = new TestsLogic();
        LessonsLogic lessonsLogic = new LessonsLogic();

        int classID;

        int selectedIndex;

        public FormTests()
        {
            InitializeComponent();
        }

        private void FormTests_Load(object sender, EventArgs e)
        {

            lessons = lessonsLogic.ValidateGetTeacherLessons(UserData.teacherID);
            for (int i = 0; i < lessons.Rows.Count; i++)
            {
                comboBoxLessons.Items.Add(lessons.Rows[i].Field<string>("Name") + " " + lessons.Rows[i].Field<DateTime>("Date"));
            }

            Console.WriteLine(UserData.teacherID);

            tests = testsLogic.ValidateGetTeacherTests(UserData.teacherID);

            DataTable testsData = tests.Copy();
            testsData.Columns.RemoveAt(4);
            testsData.Columns.RemoveAt(4);
            testsData.Columns.RemoveAt(4);
            dataGridView.DataSource = testsData;
        }

        private void comboBoxLessons_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectedIndex = comboBoxLessons.SelectedIndex;
            int lessonID = lessons.Rows[selectedIndex].Field<int>("LessonID");

            tests = testsLogic.ValidateGetLessonTests(lessonID);

            DataTable testsData = tests.Copy();
            testsData.Columns.RemoveAt(4);
            testsData.Columns.RemoveAt(4);
            testsData.Columns.RemoveAt(4);
            dataGridView.DataSource = testsData;

        }


        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedIndex = dataGridView.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView.Rows[selectedIndex];
/*            textBoxGrade.Text = row.Cells[2].Value.ToString();
            textBoxWeight.Text = row.Cells[3].Value.ToString();
            textBoxType.Text = row.Cells[5].Value.ToString();*/
            textBoxDescription.Text = row.Cells[3].Value.ToString();

            Console.WriteLine(selectedIndex);

            buttonModify.Enabled = true;
            buttonDelete.Enabled = true;
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            int testID = tests.Rows[selectedIndex].Field<int>("TestID");


/*            int grade = int.Parse(textBoxGrade.Text);
            int weight = int.Parse(textBoxWeight.Text);
            string type = textBoxType.Text;*/
            string description = textBoxDescription.Text;


            bool message = testsLogic.ValidateEditTest(testID, description);

            Console.WriteLine(message);

            tests = testsLogic.ValidateGetTeacherTests(UserData.teacherID);
            DataTable testsData = tests.Copy();
            testsData.Columns.RemoveAt(4);
            testsData.Columns.RemoveAt(4);
            testsData.Columns.RemoveAt(4);
            dataGridView.DataSource = testsData;

            buttonModify.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int testID = tests.Rows[selectedIndex].Field<int>("TestID");

            bool message = testsLogic.ValidateRemoveTest(testID);

            Console.WriteLine(message);

            tests = testsLogic.ValidateGetTeacherTests(UserData.teacherID);
            DataTable testsData = tests.Copy();
            testsData.Columns.RemoveAt(4);
            testsData.Columns.RemoveAt(4);
            testsData.Columns.RemoveAt(4);
            dataGridView.DataSource = testsData;

            buttonModify.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddTest formAddTest = new FormAddTest();
            formAddTest.Show();
        }
    }
}
