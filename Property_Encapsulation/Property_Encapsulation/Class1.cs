using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Property_Encapsulation
{
    class Person
    {

        //Method 2
        public string Name    // property
        { get; set; }
    }

    class DemoEncap
    {

        // private variables declared these can only be accessed by public methods of class
        private string studentName;
        private int studentAge;

        // using accessors to get and set the value of studentName
        public string Name
        {

            get
            {
                return studentName;
            }

            set
            {
                studentName = value;
            }

        }

        // using accessors to get and set the value of studentAge
        public int Age
        {

            get
            {
                return studentAge;
            }

            set
            {
                studentAge = value;
            }

        }


    }

}




