using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class School
    {
        static List<SchoolBase> s = new List<SchoolBase>()
        { new SchoolBase(){SchoolName="Sri chaithanya",SchoolId=100,StudentName="Ram",StudentId=10},
         new SchoolBase(){SchoolName="Little Angels",SchoolId=200,StudentName="Sitha",StudentId=20},
         new SchoolBase(){SchoolName="Bramharshi",SchoolId=300,StudentName="Raj",StudentId=30},
         new SchoolBase(){SchoolName="JMJ",SchoolId=400,StudentName="Ravi",StudentId=40}
        };

        SchoolBase sb = new SchoolBase();
        public List<SchoolBase> DisplayAll()
        {
            return s.ToList();
        }
    }
}
