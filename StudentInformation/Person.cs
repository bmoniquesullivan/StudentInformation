/***************************************************************
* Student: Barbara Sullivan                                    *
* Instructor: Dr. Jerry Mamo                                   *
* Class: CIST 2341 – C# Programming – 60485 – Summer 2019      * 
* Lab #12 - Inheritance - Part 1                               *
****************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformation
{
    public class Person
    {
        //Declare properties
        public String name;
        public String address;
        public String phone;
        public String email;

        //Create an empty constructor to initialize all properties
        public Person()
        {
            name = "";
            address = "";
            phone = "";
            email = "";
        }

        //Create a constructor to accept all properties
        public Person(String Pname, String Paddress, String Pphone, String Pemail)
        {
            name = Pname;
            address = Paddress;
            phone = Pphone;
            email = Pemail;
        }

        //Create All Setters and Getter
        public string getName() { return name; }
        public void setName(String Pname) { name = Pname; }

        public string getAddress() { return address; }
        public void setAddress(String Paddress) { address = Paddress; }

        public string getPhone() { return phone; }
        public void setPhone(String Pphone) { phone = Pphone; }

        public string getEmail() { return email; }
        public void setEmail(String Pemail) { email = Pemail; }

        //Create Display Method        
        public void DisplayPerson()
        {
            Console.WriteLine("Name: " + getName());
            Console.WriteLine("Address: " + getAddress());
            Console.WriteLine("Phone: " + getPhone());
            Console.WriteLine("E-mail: " + getEmail());
        }



    }
}
