using System.Collections.Generic;

namespace Transliterator.Russian
{
    public class FromLatinToRussianTransliterator : FromLatinToAnotherLanguageTransliterator
    {
        public FromLatinToRussianTransliterator(IEnumerable<KeyValuePair<string, char>> transliterationTable) : base(transliterationTable)
        {
        }

        public FromLatinToRussianTransliterator()
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
                       }
                )
        {}
    }
}