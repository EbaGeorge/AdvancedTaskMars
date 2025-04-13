using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart2.AssertHelpers
{
    public class LoginAssertHelpers
    {
        public static void AssertValidateLoginSuccessMessage(String expected, String actual)
        {

            Assert.That(expected == actual);
        }
    }
}
