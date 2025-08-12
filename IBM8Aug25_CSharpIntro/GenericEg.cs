using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM8Aug25_CSharpIntro
{
    internal class GenericEg
    {


        static void Main()
        {

            Min<int>(1, 123);


            Console.WriteLine(  Min(100,200));
            Console.WriteLine(Min(500.100, 200.32));
            Console.WriteLine(Min<string>("xyz", 123.ToString()));

        }


        //static int Min( int a , int b) {

        //    if (a < b) { return a; } else return b;

        //}

        //static double  Min(double  a, double  b)
        //{

        //    if (a < b) { return a; } else return b;

        //}

        //static IComparable  Min(IComparable a, IComparable b)
        //{

        //    if (a.CompareTo(b) < 0) { return a; } else return b;

        //}


        static T Min<T>(T a, T b) where T:IComparable<T>
        {

            if (a.CompareTo(b) < 0) { return a; } else return b;

        }

        static TR GenericSyntaxEg<T1,T2,TR>(T1 a, T2 b) 
            where T1 : IComparable<T1>,new()
            where T2:IDisposable
            where TR : new()
        {

            TR obj= new  TR();


            return default(TR);

           // return new object();
           // return obj;


        }
    }
}
