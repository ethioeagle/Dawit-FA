using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectsample
{
    class student : Parent
    {
        public override int GetAge()
        {
            return 35;
        }

        public override string GetfullName()
        {
            return "Dawit Alemu";
        }
    }
}
