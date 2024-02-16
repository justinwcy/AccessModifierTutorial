using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierLibrary
{
    internal static class AnotherClassUtility
    {
        public static void PrintToConsole()
        {
            var temp = new AccessModifierClassHelper("sampleString");
            temp.PublicDemo();
            temp.InternalDemo();
            temp.ProtectedInternalDemo();
        }
    }
}
