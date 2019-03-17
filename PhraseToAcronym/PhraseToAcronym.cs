using System;
using System.Linq;
using System.Xml;

namespace PhraseToAcronym
{
    public static class PhraseToAcronym
    {
        public static string MakeAcronym(string phrase)
        {
            return string.IsNullOrEmpty(phrase) ? "" : ParsePhrase(ReplaceDash(phrase)).ToUpper();
        }

        public static string ParsePhrase(string phrase)
        {
            string[] phraseArray = phrase.Split(' ');
            string acronym = string.Empty;

            foreach (var word in phraseArray)
            {
                acronym += word.First();
            }

            return acronym;
        }

        public static string ReplaceDash(string phrase)
        {
            return phrase.Replace("-", " ");
        }
    }
}
