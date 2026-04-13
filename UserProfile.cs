using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoePart1._1
{
    internal class UserProfile
    {
        // Automatic Property
        public string Name { get; set; }

        public UserProfile(string name)
        {
            Name = name;
        }
    }
}
