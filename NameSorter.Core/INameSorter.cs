using System.Collections.Generic;

namespace NameSorter.Core
{
    /// <summary>
    /// Defines a contract for sorting collections of names.
    /// </summary>
    public interface INameSorter
    {
        IEnumerable<string> Sort(IEnumerable<string> names);
    }
}