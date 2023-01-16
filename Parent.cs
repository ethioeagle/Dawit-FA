using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectsample
{
    abstract class Parent : GrandParent
    {
        public string GetName()
        {
            return "Dawit";
        }
        public abstract string GetfullName();
        public abstract override int GetAge();

    }
}
