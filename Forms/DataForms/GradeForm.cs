﻿using School.Logics;
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
    public partial class GradeForm : Form
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

        public GradeForm()
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

            grades = gradesLogic.ValidateGetTeacherGrades(UserData.teacherID);
            dataGridView.DataSource = grades;
        }

        private void comboBoxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectedIndex = comboBoxClasses.SelectedIndex;
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


            bool message = gradesLogic.ValidateEditGrade(gradeID, grade, weight, type, description);

            Console.WriteLine(message);

            grades = gradesLogic.ValidateGetTeacherGrades(UserData.teacherID);
            dataGridView.DataSource = grades;


            ModifyButton.Enabled = false;
            DeleteButton.Enabled = false;

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int gradeID = grades.Rows[selectedIndex].Field<int>("GradeID");

            bool message = gradesLogic.ValidateRemoveGrade(gradeID);

            Console.WriteLine(message);

            grades = gradesLogic.ValidateGetTeacherGrades(UserData.teacherID);
            dataGridView.DataSource = grades;

            ModifyButton.Enabled = false;
            DeleteButton.Enabled = false;
        }
    }
}
