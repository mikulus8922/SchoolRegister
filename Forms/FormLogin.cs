﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using School.Logics;
using School.Forms.UserForms;
using System.Runtime.InteropServices;


namespace School.Forms
{
    public partial class FormLogin : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

       

        SystemUsersLogic systemUsersLogic = new SystemUsersLogic();
        TeachersLogic teachersLogic = new TeachersLogic();
        StudentsLogic studentsLogic = new StudentsLogic();
        ParentsLogic parentsLogic = new ParentsLogic();

        DataTable user;
        DataTable teacher;
        DataTable student;
        DataTable parent;

        public FormLogin()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }


        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click_1(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            string passowrdHash = GetHash(SHA256.Create(), password);

            user = systemUsersLogic.ValidateGetUser(login, passowrdHash);

            if (user.Rows.Count == 0)
            {
                //wypisz blad
            }
            else
            {
                Data.UserData.userID = user.Rows[0].Field<int>("ID");

                if (user.Rows[0].Field<bool>("IsAdmin") == true)
                {
                    Data.UserData.isAdmin = true;
                    this.Hide();
                    FormAdmin formAdmin = new FormAdmin();
                    formAdmin.FormClosed += (s, args) => this.Close();
                    formAdmin.Show();
                }
                else
                {
                    teacher = teachersLogic.ValidateGetTeacherID(Data.UserData.userID);
                    student = studentsLogic.ValidateGetStudentID(Data.UserData.userID);
                    parent = parentsLogic.ValidateGetParentID(Data.UserData.userID);

                    if (teacher.Rows.Count == 1)
                    {
                        Data.UserData.isTeacher = true;
                        Data.UserData.teacherID = user.Rows[0].Field<int>("ID");
                        this.Hide();
                        TeacherForm formTeacher = new TeacherForm();
                        formTeacher.FormClosed += (s, args) => this.Close();
                        formTeacher.Show();
                        return;
                    }
                    if (student.Rows.Count == 1)
                    {
                        Data.UserData.isStudent = true;
                        Data.UserData.studentID = user.Rows[0].Field<int>("ID");
                        this.Hide();
                        FormStudent formStudent = new FormStudent();
                        formStudent.FormClosed += (s, args) => this.Close();
                        formStudent.Show();
                        return;
                    }
                    if (parent.Rows.Count == 1)
                    {
                        Data.UserData.isParent = true;
                        Data.UserData.parentID = user.Rows[0].Field<int>("ID");
                        this.Hide();
                        FormParent formParent = new FormParent();
                        formParent.FormClosed += (s, args) => this.Close();
                        formParent.Show();
                        return;
                    }
                }
            }
        }
    }
}
