using System.Security.Cryptography.X509Certificates;

namespace Assignment2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student();
            myStudent.StudentId = 1;
            myStudent.StudentFName = "William";
            Console.WriteLine($"StudentId is: {myStudent.StudentId}");
            Console.WriteLine($"Student first name is: {myStudent.StudentFName}");
        }



    }
        
    public class Student 
    {
        private int _studentId;

        public int StudentId 
        { 
            get { return _studentId; }
            set { _studentId = value; }

        }

        public string StudentFName { get; set; }

    }
     
     
    
}
