using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifierLibrary;

namespace AccessModifierTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var accessModifier = new AccessModifierClassHelper("Print this");

            accessModifier.PublicDemo();
        }
    }
}
