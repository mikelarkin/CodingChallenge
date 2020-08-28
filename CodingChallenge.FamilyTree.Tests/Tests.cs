using System;
using Given.Common;
using NUnit.Framework;

namespace CodingChallenge.FamilyTree.Tests
{
    [TestFixture]
    public class TreeTests
    {
        [TestCase(1)]
        [TestCase(33)]
        [TestCase(22)]
        public void if_the_person_exists_the_result_should_be_their_birthday(int index)
        {
            var tree = FamilyTreeGenerator.Make();
            var result = new Solution().GetBirthMonth(tree, "Name" + index);
            result.ShouldEqual(DateTime.Now.AddDays(index - 1).ToString("MMMM"));
        }

        [Test]
        public void if_the_person_is_not_a_descendant_of_the_starting_person_the_result_should_be_empty()
        {
            // I added this test case because it make sense that if you pass a starting person (node) that's where the search
            // should begin -- which is part of what makes the tree structure valuable.  We don't need to search the whole tree
            // every time
            var tree = FamilyTreeGenerator.Make();

            // Look for an descendant
            var result = new Solution().GetBirthMonth(tree.Descendants[0].Descendants[0], "Name2");
            result.ShouldEqual("");
        }

        [Test]
        public void if_the_person_does_not_exist_in_the_tree_the_result_should_be_empty()
        {
            var tree = FamilyTreeGenerator.Make();
            var result = new Solution().GetBirthMonth(tree, "Jeebus");
            result.ShouldEqual("");
        }
    }
}
