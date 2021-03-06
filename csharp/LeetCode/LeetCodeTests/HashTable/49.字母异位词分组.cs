﻿using System;
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
            var countResult = _solution.GroupAnagrams_Count(strs).Select(x => x.ToArray()).ToArray();
            var sortResult = _solution.GroupAnagrams_Sort(strs).Select(x => x.ToArray()).ToArray();
            var primeResult = _solution.GroupAnagrams_Prime(strs).Select(x=> x.ToArray()).ToArray();

            IEqualityComparer<string[][]> comparer = new Comparer();

            Assert.Equal(countResult, assert, comparer);
            Assert.Equal(sortResult, assert, comparer);
            Assert.Equal(primeResult, assert, comparer);
        }
    }
}
