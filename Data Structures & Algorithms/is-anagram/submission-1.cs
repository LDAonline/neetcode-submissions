public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        Dictionary<char, int> firstStringDict = new Dictionary<char, int>();
        Dictionary<char, int> secondStringDict = new Dictionary<char, int>();
        foreach(char character in s)
        {
            if (!firstStringDict.TryAdd(character, 1)){
                var occurences = firstStringDict[character];
                occurences++;
                firstStringDict[character] = occurences;
            }
        }
        foreach(char character in t)
        {
            if (!firstStringDict.ContainsKey(character)){
                return false;
            }

            if (!secondStringDict.TryAdd(character, 1)){
                var occurences = secondStringDict[character];
                occurences++;
                secondStringDict[character] = occurences;
            }
        }


        foreach (var kvp in firstStringDict)
        {
            secondStringDict.TryGetValue(kvp.Key, out var value);
            if (kvp.Value != value){
                return false;
            }
        }

        return true;


    }
}
