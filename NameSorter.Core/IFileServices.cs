using System.Collections.Generic;

namespace NameSorter.Core
{
    /// <summary>
    /// Provides an abstraction for reading and writing text files.
    /// </summary>
    public interface IFileService
    {
        IEnumerable<string> ReadLines(string path);
        void WriteLines(string path, IEnumerable<string> lines);
    }
}