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
    public partial class FormLessons : Form
    {
        DataTable lessons;

        LessonsLogic lessonsLogic = new LessonsLogic();

        public FormLessons()
        {
            InitializeComponent();
        }

        private void FormTests_Load(object sender, EventArgs e)
        {
            Console.WriteLine(UserData.teacherID);

            lessons = lessonsLogic.ValidateGetTeacherLessons(UserData.teacherID);
            DataTable lessonsData = lessons.Copy();
            lessonsData.Columns.RemoveAt(6);
            lessonsData.Columns.RemoveAt(6);
            lessonsData.Columns.RemoveAt(6);
            dataGridView.DataSource = lessonsData;
        }
    }
}
