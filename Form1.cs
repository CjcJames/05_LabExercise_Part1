﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class Form1 : Form
    {
        public static string fileName;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fileName = txtStudentNo.Text + ".txt";
            string getStudentNo = "Student No.: " + txtStudentNo.Text;
            string getName = "Full Name: " + txtLname.Text + ", " + txtFname.Text + ", " + txtMi.Text + ". ";
            string getProgram = "Program: " + cbProgram.Text;
            string getGender = "Gender: " + cbGender.Text;
            string getAge = "Age: " + txtAge.Text;
            string getBirthday = "Birthday: " + dtpBirthday.Text;
            string getContact = "Contact No.: " + txtContact.Text;
            
            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            fileName)))
            {
                outputFile.WriteLine(getStudentNo);
                Console.WriteLine(getStudentNo);
                outputFile.WriteLine(getName);
                Console.WriteLine(getName);
                outputFile.WriteLine(getProgram);
                Console.WriteLine(getProgram);
                outputFile.WriteLine(getGender);
                Console.WriteLine(getGender);
                outputFile.WriteLine(getAge);
                Console.WriteLine(getAge);
                outputFile.WriteLine(getBirthday);
                Console.WriteLine(getBirthday);
                outputFile.WriteLine(getContact);
                Console.WriteLine(getContact);
            }
        }
    }
}
