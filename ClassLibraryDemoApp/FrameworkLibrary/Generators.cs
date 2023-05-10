using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkLibrary
{
    public class Generators
    {

        public string WelcomeMessage(string prefix, string lastname)
        {
            return $"Welcome to our demo application {prefix} {lastname}!";
        }

        public string FarewellMessage(string prefix, string lastname)
        {
            return $"We hope you enjoyed your visit. Thank you {prefix} {lastname}";
        }
    }
}
