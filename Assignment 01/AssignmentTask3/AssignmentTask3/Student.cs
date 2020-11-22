using System;

namespace AssignmentTask3
{
    class Student
    {
        string name;
        int id;
        double CGPA;
        public Student(String name, int id, double CGPA)
        {
            this.name = name;
            this.id = id;
            this.CGPA = CGPA;
        }
        public string ShowName()
        {
            return this.name;
        }
        public int showId()
        {
            return this.id;
        }
        public double showCGPA()
        {
            return this.CGPA;
        }
        public double showAverage(Student ob1, Student ob2)
        {
            return ((ob1.CGPA + ob2.CGPA) / 2);
        }
    }
}
