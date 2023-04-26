using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Practical3
{
    internal class Laptop
    {
        // using accessors to get and set the value of laptop Brand
        public string Brand { get; set; }

        // private variables declared these can only be accessed by public methods of class
        private long Model_no;

        // using accessors to get and set the value of Model number
        public long Model
        {
            get { return Model_no; }
            set { Model_no = value; }
        }

        public void LaptopDetails()
        {
            Console.WriteLine("Laptop Brand: " + Brand);

            Console.WriteLine("Model number of laptop: " + Model);
        }

        public void MotherBoardInfo()
        {
            Console.WriteLine("MotherBoard Information");
        }
    }
}
