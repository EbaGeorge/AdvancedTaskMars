using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart2.Model
{
    public class UpdateLanguage
    {
        public string Language { get; set; }
        public string LanguageLevel { get; set; }
        public string LanguageToBeUpdated {  get; set; }
        public string LanguageLevelToBeUpdated {  get; set; }
        public string ExpectedMessage { get; set; }
    }
}
