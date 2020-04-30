using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace LeetCodeTests.HashTable
{
    public partial class HashTableTest
    {
        [Theory]
        [InlineData(new [] { "eat", "tea", "tan", "ate", "nat", "bat" }, new []{ "ate", "eat", "tea" }, new []{ "nat", "tan" },new []{"bat"})]
        void GroupAnagrams(string[] strs,params string[][] assert)
        {
            var result = _solution.GroupAnagrams_HashTable(strs).SelectMany(x => x.ToArray());

            Assert.Equal(,assert);
        }
    }
}
