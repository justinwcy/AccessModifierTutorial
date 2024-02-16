using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierLibrary
{
    public class AccessModifierClassHelper
    {
        private string _sampleString;
        public AccessModifierClassHelper(string sampleString)
        {
            _sampleString = sampleString;
        }

        public void PublicDemo()
        {
            PrivateDemo();
        }

        private void PrivateDemo()
        {
            Console.Write(_sampleString);
        }

        internal void InternalDemo()
        {
            PrivateDemo();
        }

        protected void ProtectedDemo()
        {
            PrivateDemo();
        }

        protected internal void ProtectedInternalDemo()
        {
            PrivateDemo();
        }

        private protected void PrivateProtectedDemo()
        {
            PrivateDemo();
        }
    }
}
