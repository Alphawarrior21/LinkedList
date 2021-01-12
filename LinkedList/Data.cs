using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
   public class Data
    {
        public string Name { get; set; }
        public Data(string name)
        {
            Name = name;
        }

    }
    public class SubDataFirst : Data
    {
        public int RollNumber { get; set; }
        

        public SubDataFirst(int rollNumber,string _name) : base(_name)
        {
            RollNumber = rollNumber;
        }
    }
}
