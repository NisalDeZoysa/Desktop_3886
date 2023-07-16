using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Desktop01.Model
{
    public class Student_User
    {
        //creating blueprint of user

        public int Age { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public BitmapImage Image { get; set; }  

        public string  DateOfBirth{ get; set; }

        public Double GPA { get; set; }



        public String ImagePath
        {
            get { return $"/Model/Images/{Image}"; }
        }


        //overrided constructor
        public Student_User(int ageofstudent, string fname_stu, string lname_stu, string birthdate,BitmapImage  image )
        {
            Age = ageofstudent;
            FirstName = fname_stu;
            LastName = lname_stu;
            DateOfBirth = birthdate;
            Image = image;
        }



        public Student_User()
        {
        }
    }
}
