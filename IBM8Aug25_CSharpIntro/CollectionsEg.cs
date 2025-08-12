using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM8Aug25_CSharpIntro
{
    internal class CollectionsEg
    {
        static void Main()
        { 
        

           // List<string> list = new List<string>();
            List<string> list = new List<string>() {"Ganesh","Mahesh","Dinesh" };

            list.Add("Suresh");

            foreach (var name in list)
            {
                Console.WriteLine(  name);
            }

            Console.WriteLine(list[1]);

            list.Remove("Suresh");
            list.RemoveAt(1);
            

            Dictionary<string,string> dict = new Dictionary<string,string>();
            dict.Add("1001", "Ganesh");



            foreach (var item in dict)
            {
                Console.WriteLine( $"{item.Key}={item.Value}"  );
            }



            List<Employee> employees = new List<Employee>() {

             new Employee( ) { EmpID=1, EmpName="Ganesh" },
              new Employee( ) { EmpID=2, EmpName="Mahesh" },
              new Employee( ) { EmpID=3, EmpName="Dinesh" },
              new Employee( ) { EmpID=4, EmpName="Ramesh" },

            };


            employees.Add(new Employee( ) { EmpID=1234, EmpName="Ganesh" });

        }
    }
}
