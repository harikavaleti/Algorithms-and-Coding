using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;


namespace Module1_SelfAssessment
{
    class UProgram : IDisposable
    {
        public Degree degree { get; set; }
        public string programName { get; set; }
        public Student student { get; set; }
        private static string text { get; set; }

        public bool disposed = false;

        public UProgram program { get; set; }


        public UProgram(string name)
        {
            programName = name;
        }

       ~UProgram()
        {
            Dispose(false);     
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing) 
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    program.Dispose();
                }
            }         
          disposed = true;
        }

        public string getdName()
            {
                return degree.Name;
            }
        
       

        static void Main(string[] args)
        {
            Student s1 = new Student("john", 1);
            Student s2 = new Student("Roy", 2);
            Student s3 = new Student("Zen");
            Student s4 = new Student("Shan");
            Student s5 = new Student("paraj", 3);
            Student s6 = new Student("raj", 4);

             Teacher t1 = new Teacher("kom");
             Teacher t2 = new Teacher("Xar");

             List<Student> studentList = new List<Student>();
             List<Teacher> teacherList = new List<Teacher>();

             studentList.Add(s1);
             studentList.Add(s2);
             studentList.Add(s3);
             studentList.Add(s4);
             studentList.Add(s5);
             studentList.Add(s6);

             teacherList.Add(t1);
             teacherList.Add(t2);

             Course course1 = new Course("Programming with C#");
             course1.studentList = studentList;
             course1.teacherList = teacherList;

             Degree degree = new Degree("Bachelor",3);
             degree.course = course1;

            UProgram program = new UProgram("Information Technology");
            program.degree = degree;

            Console.WriteLine($"You have been applied for {program.programName} in {program.getdName()} Degree of course {program.degree.getcName()}. \n Total {studentList.Count()} number of students applied for the course.");

                StreamReader streamReaderObject = null;
                try
                {
                    streamReaderObject = new StreamReader("file12.txt");

                    String contents = streamReaderObject.ReadToEnd();

                    Console.WriteLine("The file has {0} text elements.", new StringInfo(contents).LengthInTextElements);
                    Console.WriteLine("Contents of File = " + contents);
                     streamReaderObject.Close();
                }

                catch (FileNotFoundException)
                {
                    Console.WriteLine("The file cannot be found.");

                }
                finally
                {

                    if (streamReaderObject != null)
                    {
                       streamReaderObject.Dispose();
                    }

                }

            string rootPath = @"C:\Users\Admin\Downloads\Music";
            var files = Directory.GetFiles(rootPath,"*", SearchOption.AllDirectories);
            foreach(string file in files)
            {
                Console.WriteLine(file);
            }
          }
    }
}
