using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM8Aug25_CSharpIntro
{



    delegate int DlgDemo(int a, int b);
    // int(int,int)


    internal class DelegateEgConsumer
    {

        static void Main()
        {

            MathProvider obj = new MathProvider();

          //  DlgDemo fptr = new DlgDemo(obj.Add); // 1.0
            DlgDemo fptr = obj.Add; // 2.0 DTI

            fptr += obj.Multi;

            // 2.0 Anon Method/Block

            fptr += delegate (int x, int y) { return x + y; };


            // 3.0 LAMBDA Expression 
            // explicitly typed arg
            fptr +=  (int x, int y) => { return x + y; };

            fptr += ( x,  y) => { return x + y; };

            fptr += (x, y) => x + y; 


            Console.WriteLine( fptr(100,200) );

            Console.ReadKey();

        
        }


    }




    class MathProvider
    {

        public int Add(int a, int b) { return a + b; }
        public int Multi(int i, int j) { return i * j; }


    }

}
