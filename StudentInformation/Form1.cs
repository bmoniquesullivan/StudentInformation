/***************************************************************
* Student: Barbara Sullivan                                    *
* Instructor: Dr. Jerry Mamo                                   *
* Class: CIST 2341 – C# Programming – 60485 – Summer 2019      * 
* Lab #12 - Inheritance - Part 2                               *
****************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Declare Student Reference as a Global Variable
        Student s1;
       

        //Event Click for Fill Button
        private void btn_fill_Click(object sender, EventArgs e)
        {
            //Throw Exception to Handle Empty TextFields
            try
            {
                s1 = new Student(Int32.Parse(txt_id.Text), txt_name.Text, txt_address.Text, txt_email.Text, txt_phone.Text, txt_major.Text, Double.Parse(txt_gpa.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("You need to enter all fields to proceed. Try Again");

            }
            //Clear TextBoxes after entering data
            txt_id.Clear();
            txt_name.Clear();
            txt_address.Clear();
            txt_email.Clear();
            txt_phone.Clear();
            txt_major.Clear();
            txt_gpa.Clear();
            MessageBox.Show("Student Added");
        }
        //Event Click for Display Button
        private void btn_display_Click(object sender, EventArgs e)
        {
           
            s1.Display();
            
        }
    }
}

