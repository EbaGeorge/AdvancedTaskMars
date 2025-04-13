using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart2.AssertHelpers
{
    public class AboutMeAssertHelpers
    {

        public static void AssertAboutMeSuccess(String expected, String actual)
        {

            Assert.That(expected == actual);
        }
    }
}
