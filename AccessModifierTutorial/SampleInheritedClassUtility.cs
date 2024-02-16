using AccessModifierLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierTutorial
{
    internal class SampleInheritedClassUtility : AccessModifierClassHelper
    {
        public SampleInheritedClassUtility(string sampleString) : base(sampleString)
        {

        }
        public void PrintToConsole()
        {
            base.ProtectedInternalDemo();
            base.PublicDemo();
            base.ProtectedDemo();

        }
    }
}
