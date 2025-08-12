using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM8Aug25_CSharpIntro
{
    internal class OOPEg
    {

        static void Main()
        { 


            Employee objEmp = new Employee();
            objEmp.EmpID = 1001; // Set
            Console.WriteLine(  objEmp.EmpID); // Get



            clsA objA = new ClsB();
            objA.Display();

            ClsB objB1 = (ClsB) objA;

            ClsB objB2 = objA as ClsB ;



            ClsB objB = new ClsC();
            objB.Display();


            Console.ReadKey();


        }


    }


   abstract class clsA 
    {

        //int Var_Defa = 100;
        //private   int Var_Prv = 100;
        //public   int Var_Pub = 100;

        //protected int Var_Ptd = 100;

        public abstract void Display();
        //{

        //    Console.WriteLine( "In Display of ClsA");
        
        //}
    }


    class ClsB:clsA
    {
        //public ClsB()
        //{
        //        this.Var_Ptd = 100;
        //}

        public sealed override void Display()
        {

            Console.WriteLine("In Display of ClsB");

        }


    }

    class ClsC : ClsB
    {
        //public ClsB()
        //{
        //        this.Var_Ptd = 100;
        //}

        //public override void Display()
        //{

        //    Console.WriteLine("In Display of ClsC");

        //}


    }

    interface IEmployee
    {
        int EmpID { get; set; }

        void Display();
    }

    class Employee : IEmployee,IDisposable
    {

        public Employee()
        {
                // mem / init

        }
        public Employee(int empid)
        {
            // mem / init
            _EmpID = empid;
        }


        public Employee(int empid, string empname):this(empid) 
        {
            // mem / init
            //_EmpID = empid;
            EmpName = empname;

        }



        private int _EmpID;

        public int EmpID
        {
            get { return _EmpID; }
            set { _EmpID = value; }
        }


        public string EmpName { get; set; }

        public void Display()
        {
            Console.WriteLine(  "In Display of Employee");
        }

        public void DisplayA() { }

        public void Dispose()
        {
            // res mgmt managed / unmanaged
        }

        ~Employee()
        {
            // res mgmt  unmanaged
        }

    }





}
