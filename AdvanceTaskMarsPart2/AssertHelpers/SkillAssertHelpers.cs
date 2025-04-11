using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart2.AssertHelpers
{
    public class SkillAssertHelpers
    {
        public static void AssertValidateSkillSuccessMessage(String expected, String actual)
        {

            Assert.That(expected == actual);
        }
    }
}
