using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceSearchLibraryConsoleApplication
{
    public interface ISearch
    {
        List<string> GetSearchResult(string searchPhrase);
    }
}