using System.Collections.Generic;
using System.Linq;

namespace NameSorter.Core
{
    /// <summary>
    /// Default implementation of INameSorter that sorts names by last name,
    /// then by given names in ascending order.
    /// </summary>
    public class DefaultNameSorter : INameSorter
    {
        public IEnumerable<string> Sort(IEnumerable<string> names)
        {
            if (names == null) return Enumerable.Empty<string>();

            return names
                .Select(n => n.Trim())
                .Where(n => !string.IsNullOrWhiteSpace(n))
                .OrderBy(n =>
                {
                    var parts = n.Split(' ');
                    return parts.Last(); // Last name
                })
                .ThenBy(n =>
                {
                    var parts = n.Split(' ');
                    return string.Join(" ", parts.Take(parts.Length - 1)); // Given names
                });
        }
    }
}