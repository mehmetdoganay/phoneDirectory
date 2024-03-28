using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phoneDirectory
{
    public class Person
    {
        public int phoneNumber;
        public string name;
        public string surName;


        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Name 
        {  
            get { return name; } 
            set {  name = value; } 
        }

        public string SurName
        {
            get { return surName; }
            set { surName = value; }
        }
    }
}
