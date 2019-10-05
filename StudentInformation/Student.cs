/***************************************************************
* Student: Barbara Sullivan                                    *
* Instructor: Dr. Jerry Mamo                                   *
* Class: CIST 2341 – C# Programming – 60485 – Summer 2019      * 
* Lab #12 - Inheritance - Part 2                               *
****************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformation
{
    public class Student : Person
    {
        //Declare and Initialize Properties
        private int id;
        private String major;
        private double gpa;

        
        //Create an empty constructor to initialize all properties 
        public Student()
        {
            id = 0;
            major = "";
            gpa = 0.0;
        }

        //Create a constructor to accept the properties 
        public Student(int studentId, String studentName, String studentAddress, String studentEmail, String studentPhone, String studentMajor, double studentGpa)
        {
            id = studentId;
            name = studentName;
            address = studentAddress;
            email = studentEmail;
            phone = studentPhone;
            major = studentMajor;
            gpa = studentGpa;
        }

        //Create All Setters and Getter
        public int getID() { return id; }
        public void setID(int studentId) { id = studentId; }

        public String getMajor() { return major; }
        public void setMajor(String studentMajor) { major = studentMajor; }

        public double getGPA() { return gpa; }
        public void setGPA(double studentGpa) { gpa = studentGpa; }

        //Create Display Method
        public void Display()
        {
            DisplayPerson();
            Console.WriteLine("Student ID: " + getID());
            Console.WriteLine("Student Major: " + getMajor());
            Console.WriteLine("Student GPA: " + getGPA());
            
        }
    }
}
