using System;

namespace CodingChallenge.FamilyTree
{
    public class Solution
    {
        // Search using recursion
        public string GetBirthMonth(Person person, string descendantName)
        {
            // Check to see if the name we're looking for is the current person
            if (person.Name == descendantName)
            {
                return person.Birthday.ToString("MMMM");
            }

            string result = "";
            for (int i = 0; result == "" && i < person.Descendants.Count; i++)
            {
                result = GetBirthMonth(person.Descendants[i], descendantName);
            }

            return result;
        }
    }
}