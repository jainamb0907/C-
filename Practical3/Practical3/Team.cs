using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Practical3
{
    internal class Team : Sponsor
    {
        string teamName = "Titans";

        public string printInfo()
        {
            string concateString = string.Concat(owner, teamName);
            //Better
            concateString = $"concat owner and teamName: {owner} {teamName}";
            return concateString;
        }
    }
}
