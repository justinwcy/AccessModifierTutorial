using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierLibrary
{
    internal class AccessModifierInherited : AccessModifierClassHelper
    {
        public AccessModifierInherited(string sampleString) : base(sampleString)
        {
            
        }
        internal void PrintToConsole()
        {
            PrivateProtectedDemo();
            ProtectedInternalDemo();
            ProtectedDemo();
            InternalDemo();
            PublicDemo();
        }
    }
}
