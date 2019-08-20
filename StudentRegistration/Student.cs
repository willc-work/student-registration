using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    class Student
    {
        String firstname;
        String lastName;
        String phoneNumber;
        String address;
        String course;
        String gender;
        String file_path;

        public string FirstName { get => firstname; set => firstname = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public string Course { get => course; set => course = value; }
        public string Gender { get => gender; set => gender = value; }
        public string File_path { get => file_path; set => file_path = value; }
    }
}
