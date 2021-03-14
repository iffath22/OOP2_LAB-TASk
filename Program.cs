using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            Department d1 = new Department("Computer Science and Engineering", "CSE");
            Student S1 = new Student("Iffath Jahan Jothi", "110011", 3.50f);
            S1.showDetails();
        }
    }
}

