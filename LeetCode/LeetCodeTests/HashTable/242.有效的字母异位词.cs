using System;
using System.Collections.Generic;
using System.Text;
using AutoFixture.Xunit2;
using Xunit;

namespace LeetCodeTests.HashTable
{
    public partial class HashTableTest
    {
        [Theory]
        [InlineData("anagram", "nagaram",true)]
        [InlineData("a", "b", false)]
        [InlineData("a","ab",false)]
        void IsAnagram(string s,string t,bool assert)
        {
            var dictionaryResult = _solution.IsAnagram_Dictionary(s, t);

            var sortResult = _solution.IsAnagram_Sort(s, t);

            Assert.Equal(dictionaryResult, assert);

            Assert.Equal(sortResult, assert);
        }

    }
}
