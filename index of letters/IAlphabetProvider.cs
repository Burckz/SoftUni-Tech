using System.Collections.Generic;

namespace index_of_letters
{
    internal interface IAlphabetProvider
    {
        IEnumerable<char> GetAlphabet();
    }
}