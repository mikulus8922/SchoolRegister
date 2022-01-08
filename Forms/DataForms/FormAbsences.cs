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
        DataTable absences;

        GradesLogic gradesLogic = new GradesLogic();
        ClassesLogic classesLogic = new ClassesLogic();
        StudentsLogic studentsLogic = new StudentsLogic();
        LessonsLogic lessonsLogic = new LessonsLogic();
        AbsencesLogic absencesLogic = new AbsencesLogic();


        int selectedIndex;

        public FormAbsences()
        {
            InitializeComponent();
        }

        private void FormAbsences_Load(object sender, EventArgs e)
        {
            classes = classesLogic.ValidateGetClasses();

            for (int i = 0; i < classes.Rows.Count; i++)
            {
                comboBoxClasses.Items.Add(classes.Rows[i].Field<string>("Name"));
            }


            absences = absencesLogic.ValidateGetTeacherAbsences(UserData.teacherID);

            DataTable absencesData = absences;
            absencesData.Columns.RemoveAt(7);
            absencesData.Columns.RemoveAt(7);
            absencesData.Columns.RemoveAt(7);
            dataGridView.DataSource = absencesData;
        }

        private void comboBoxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectedIndex = comboBoxClasses.SelectedIndex;
            int classID = classes.Rows[selectedIndex].Field<int>("ClassID");

            absences = absencesLogic.ValidateGetTeacherClassAbsences(UserData.teacherID, classID);

            DataTable absencesData = absences;
            absencesData.Columns.RemoveAt(7);
            absencesData.Columns.RemoveAt(7);
            absencesData.Columns.RemoveAt(7);
            dataGridView.DataSource = absencesData;

        }


        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedIndex = dataGridView.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView.Rows[selectedIndex];
            checkBoxIsExcused.Checked = bool.Parse(row.Cells[5].Value.ToString());
            textBoxDescription.Text = row.Cells[7].Value.ToString();

            buttonModify.Enabled = true;
            buttonDelete.Enabled = true;
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            int absenceID = absences.Rows[selectedIndex].Field<int>("AbsenceID");

            bool isExcused = checkBoxIsExcused.Checked;
            string description = textBoxDescription.Text;


            bool message = absencesLogic.ValidateEditAbsence(absenceID, isExcused, description);

            Console.WriteLine(message);

            absences = absencesLogic.ValidateGetTeacherAbsences(UserData.teacherID);
            DataTable absencesData = absences;
            absencesData.Columns.RemoveAt(7);
            absencesData.Columns.RemoveAt(7);
            absencesData.Columns.RemoveAt(7);
            dataGridView.DataSource = absencesData;

            buttonModify.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int absenceID = absences.Rows[selectedIndex].Field<int>("AbsenceID");

            bool message = absencesLogic.ValidateRemoveAbsence(absenceID);

            Console.WriteLine(message);

            absences = absencesLogic.ValidateGetTeacherAbsences(UserData.teacherID);
            DataTable absencesData = absences;
            absencesData.Columns.RemoveAt(7);
            absencesData.Columns.RemoveAt(7);
            absencesData.Columns.RemoveAt(7);
            dataGridView.DataSource = absencesData;

            buttonModify.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddGrade formAddAbsence = new FormAddGrade();
            formAddAbsence.Show();
        }
    }
}
