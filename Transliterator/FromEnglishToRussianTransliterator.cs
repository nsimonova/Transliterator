using System.Collections.Generic;
using System.Text;

namespace Transliterator
{
    public class FromEnglishToRussianTransliterator
    {
        public FromEnglishToRussianTransliterator()
        {
            tree = new InvertedIndexTree();
            foreach (var relation in relations)
            {
                tree.Add(relation.Key, relation.Value);
            }
        }

        public string Transliterate(string englishText)
        {
            StringBuilder sb = new StringBuilder();
            int index = 0;
            while (index < englishText.Length)
            {
                var letter = tree.SearchMaxOccurence(englishText, ref index);
                sb.Append(letter);
            }

            return sb.ToString();
        }


        private Dictionary<string, char> relations = new Dictionary<string, char>
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
                                                         };

        private InvertedIndexTree tree;
    }
}