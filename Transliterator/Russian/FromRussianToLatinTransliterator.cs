using System.Collections.Generic;
using System.Linq;

namespace Transliterator.Russian
{
    public class FromRussianToLatinTransliterator : FromAnotherLanguageToLatinTransliterator
    {
        public FromRussianToLatinTransliterator(IDictionary<char, string> transliterationTable) : base(transliterationTable)
        {
        }

        public FromRussianToLatinTransliterator()
            : this(new Dictionary<string, char>
                       {
                           {"a", '�'},
                           {"b", '�'},
                           {"v", '�'},
                           {"g", '�'},
                           {"d", '�'},
                           {"e", '�'},
                           {"yo", '�'},
                           {"zh", '�'},
                           {"z", '�'},
                           {"i", '�'},
                           {"j", '�'},
                           {"k", '�'},
                           {"l", '�'},
                           {"m", '�'},
                           {"n", '�'},
                           {"o", '�'},
                           {"p", '�'},
                           {"r", '�'},
                           {"s", '�'},
                           {"t", '�'},
                           {"u", '�'},
                           {"f", '�'},
                           {"h", '�'},
                           {"c", '�'},
                           {"ch", '�'},
                           {"sh", '�'},
                           {"shh", '�'},
                           {"'", '�'},
                           {"y", '�'},
                           {"._", '�'},
                           {"e-", '�'},
                           {"yu", '�'},
                           {"ya", '�'},
                           {"_", '_'}
                       }.ToDictionary(x => x.Value, y => y.Key)
                )
        {}
    }
}