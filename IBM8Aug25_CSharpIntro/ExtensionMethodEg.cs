using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM8Aug25_CSharpIntro
{
    internal class ExtensionMethodEg
    {

        static void Main()
        { 
            char c='A';

            IbmExtEg.IsValidEmpIDChar(c);

            c.IsValidEmpIDChar();


            Employee employee = new Employee();
            employee.IsValidEmpIDChar();
            string st = "";
            st.IsValidEmpIDChar();



        
        }


    }

    public static class IbmExtEg
    {

        public static bool IsValidEmpIDChar(this object  ch)
        {

            return true;
        }
    
    
    }




}
