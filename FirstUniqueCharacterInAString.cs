namespace Algoritmos;
public static class FirstUniqueCharacterInAString
{
    //given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.
    //s consists of only lowercase English letters.

    public static int FirstUniqChar(string s)
    {
        var charArray = s.ToLower().ToCharArray();
        var index = -1;

        for (int i = 0; i < charArray.Length; i++)
        {
            var countCharacters = charArray.Count(x => x == charArray[i]);

            if (countCharacters == 1)
            {
                index = i;
                break;
            }
        }

        Console.WriteLine(index);
        return index;
    }

}
