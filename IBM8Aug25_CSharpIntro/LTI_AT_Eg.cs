using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM8Aug25_CSharpIntro
{
    internal class LTI_AT_Eg
    {
  static dynamic d = 123;
        static void Main()
        {

            var i = 100;

            i = 3242;


         
            d = "";
            d = "abc";
            //  d.lhfkfjsdhghsfdghskdf();


            var obj = new Employee{ EmpID=1000, EmpName="Ganesh" };

            var obj1 = new  { EmpID = 1000, EmpName = "Ganesh" };

            var obj2 = new { EmpID = 1000, EmpName = "Ganesh" };

            var obj3 = new {  EmpName = "Ganesh", EmpID = 1000 };


            Console.WriteLine(  obj.GetType());
            Console.WriteLine(obj1.GetType());
            Console.WriteLine(obj2.GetType());
            Console.WriteLine(obj3.GetType());



        }

    }
}
