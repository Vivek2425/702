using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQAPP
{
    class Program 
    {

        static void Main1(string[] args)
        {
            int[] Data = { 10, 20, 1, 5, 40, 50, 40, 60, 11 };
            var filterData = from i in Data
                             where i < Data.Average()
                             select i;
            foreach(var i in filterData)
            {
                Console.WriteLine(i + " ");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            try
            {
                List<Students> student = new List<Students>();
                student.Add(new Students { Id = 101, Name = "vivek", Rollno = 25, Discription = "nothing" });
                student.Add(new Students { Id = 102, Name = "vihan", Rollno = 26, Discription = "hello" });
                student.Add(new Students { Id = 103, Name = "viren", Rollno = 27, Discription = "hey" });
                var filterData1 = from data in student
                                 where data.Name == "vivek"
                                 select data;
                var filterData = from data in student
                                 where data.Name.Contains("a")
                                 select data;
                if (filterData.Count() == 0)
                {
                    throw new myException("Null Exception..!!" +
                        "No Data found");
                }
                else
                {
                    foreach (var i in filterData)
                    {
                       Console.WriteLine(i);
                    }
                }
            }
            catch (myException e)
            {
                Console.WriteLine("User define Exception caught: " + e.Message);
            }
            Console.ReadKey();
        }
    }
}
