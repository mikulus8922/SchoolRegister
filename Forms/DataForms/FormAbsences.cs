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

        //DataTable grades;
        DataTable classes;
        //DataTable students;
        //DataTable lessons;
        DataTable absences;

        GradesLogic gradesLogic = new GradesLogic();
        ClassesLogic classesLogic = new ClassesLogic();
        //StudentsLogic studentsLogic = new StudentsLogic();
        //LessonsLogic lessonsLogic = new LessonsLogic();
        AbsencesLogic absencesLogic = new AbsencesLogic();


        int selectedIndex;

        public FormAbsences()
        {
            InitializeComponent();
        }

        private void FormAbsences_Load(object sender, EventArgs e)
        {
            comboBoxClasses.Items.Clear();

            classes = classesLogic.ValidateGetClasses();

            for (int i = 0; i < classes.Rows.Count; i++)
            {
                comboBoxClasses.Items.Add(classes.Rows[i].Field<string>("Name"));
            }


            absences = absencesLogic.ValidateGetTeacherAbsences(UserData.teacherID);

            DataTable absencesData = absences.Copy();
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

            DataTable absencesData = absences.Copy();
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
            textBoxDescription.Text = row.Cells[6].Value.ToString();

            ModifyButton.Enabled = true;
            DeleteButton.Enabled = true;
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            FormAddAbsence formAddAbsence = new FormAddAbsence();
            formAddAbsence.Show();
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            int absenceID = absences.Rows[selectedIndex].Field<int>("AbsenceID");

            bool isExcused = checkBoxIsExcused.Checked;
            string description = textBoxDescription.Text;


            if (!absencesLogic.ValidateEditAbsence(absenceID, isExcused, description))
            {
                FormErrorDialog formErrorDialog = new FormErrorDialog();
                formErrorDialog.Show();
            }



            absences = absencesLogic.ValidateGetTeacherAbsences(UserData.teacherID);
            DataTable absencesData = absences.Copy();
            absencesData.Columns.RemoveAt(7);
            absencesData.Columns.RemoveAt(7);
            absencesData.Columns.RemoveAt(7);
            dataGridView.DataSource = absencesData;

            ModifyButton.Enabled = false;
            DeleteButton.Enabled = false;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int absenceID = absences.Rows[selectedIndex].Field<int>("AbsenceID");

            if (!absencesLogic.ValidateRemoveAbsence(absenceID))
            {
                FormErrorDialog formErrorDialog = new FormErrorDialog();
                formErrorDialog.Show();
            }



            absences = absencesLogic.ValidateGetTeacherAbsences(UserData.teacherID);
            DataTable absencesData = absences.Copy();
            absencesData.Columns.RemoveAt(7);
            absencesData.Columns.RemoveAt(7);
            absencesData.Columns.RemoveAt(7);
            dataGridView.DataSource = absencesData;

            ModifyButton.Enabled = false;
            DeleteButton.Enabled = false;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            FormAbsences_Load(sender, e);
        }
    }
}
