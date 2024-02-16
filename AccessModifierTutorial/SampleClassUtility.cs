using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifierLibrary;

namespace AccessModifierTutorial
{
    internal static class SampleClassUtility
    {
        public static void PrintToConsole()
        {
            var temp = new AccessModifierClassHelper("sample");
            temp.PublicDemo();
            
        }
    }
}
