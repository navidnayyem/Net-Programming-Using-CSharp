using System;

struct StudentInfo{ 
    public int studentid; 
    public string studentname; 
    public string studentcontact; 
};

namespace _4thTask_Structure
{
    class Structure
    {
        static void Main(string[] args)
        {
            StudentInfo Student1; /* Declare Student1 */
            StudentInfo Student2; /* Declare Student2 */

            /* Student1 specification */
            Student1.studentid = 1;
            Student1.studentname = "Navid";
            Student1.studentcontact = "01724463611";

            /* Student2 specification */
            Student2.studentid = 2;
            Student2.studentname = "Nayyem";
            Student2.studentcontact = "01614463611";

            /* print Student1 info */
            Console.WriteLine("Student1 studentid : {0}", Student1.studentid); 
            Console.WriteLine("Student1 studentname : {0}", Student1.studentname); 
            Console.WriteLine("Student1 studentcontact : {0}\n", Student1.studentcontact);
            
            /* print Student2 info */
            Console.WriteLine("Student2 studentid : {0}", Student2.studentid);
            Console.WriteLine("Student2 studentname : {0}", Student2.studentname);
            Console.WriteLine("Student2 studentcontact : {0}", Student2.studentcontact);
            Console.ReadLine();
        }
    }
}
