using System.Collections.Generic;
using System.IO;

namespace NameSorter.Core
{
    /// <summary>
    /// Concrete implementation of IFileService using System.IO.
    /// </summary>
    public class FileService : IFileService
    {
        public IEnumerable<string> ReadLines(string path) => File.ReadLines(path);

        public void WriteLines(string path, IEnumerable<string> lines) =>
            File.WriteAllLines(path, lines);
    }
}