﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLibrary;

namespace School_forms_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_1_pushToTest_Click(object sender, EventArgs e)
        {
            var testSchool = new School();
            testSchool.Name = textName.Text;
            testSchool.Address = textAddress.Text;
            testSchool.City = textCity.Text;
            testSchool.Department = textDepartment.Text;
            testSchool.Phone = textPhone.Text;

            try
            {

                testSchool.TwitterAddress = textTwitter.Text;
                MessageBox.Show(testSchool.ToString());

            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
