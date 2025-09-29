using System.Collections.Generic;
using System.Linq;
using NameSorter.Core;
using Xunit;

namespace NameSorter.Tests
{
    public class DefaultNameSorterTests
    {
        [Fact]
        public void SortsByLastNameThenGivenNames()
        {
            INameSorter sorter = new DefaultNameSorter();

            var names = new List<string>
            {
                "Janet Parsons",
                "Vaughn Lewis",
                "Adonis Julius Archer",
                "Shelby Nathan Yoder",
                "Marin Alvarez",
                "London Lindsey",
                "Beau Tristan Bentley"
            };

            var sorted = sorter.Sort(names).ToList();

            var expected = new List<string>
            {
                "Marin Alvarez",
                "Adonis Julius Archer",
                "Beau Tristan Bentley",
                "Vaughn Lewis",
                "London Lindsey",
                "Janet Parsons",
                "Shelby Nathan Yoder"
            };

            Assert.Equal(expected, sorted);
        }

        [Fact]
        public void HandlesEmptyList()
        {
            INameSorter sorter = new DefaultNameSorter();

            var sorted = sorter.Sort(new List<string>());

            Assert.Empty(sorted);
        }

        [Fact]
        public void HandlesSingleName()
        {
            INameSorter sorter = new DefaultNameSorter();

            var names = new List<string> { "Only One" };

            var sorted = sorter.Sort(names).ToList();

            Assert.Single(sorted);
            Assert.Equal("Only One", sorted[0]);
        }
    }
}