public class Solution {
    public bool IsValid(string s) {
        //Open ones add to stack - when you find a closed one, remove from stack if it matches:
        var characterArray = s.ToCharArray();
        var parenStack = new List<char>();
        foreach(var character in characterArray)
        {
            switch(character){
                case '(':
                case '[':
                case '{':
                    parenStack.Add(character);
                    break;
                case ')':
                    if (!SafeToContinue('('))
                    {
                        return false;
                    }
                    break;
                case ']':
                    if (!SafeToContinue('['))
                    {
                        return false;
                    }
                    break;
                case '}':
                    if (!SafeToContinue('{'))
                    {
                        return false;
                    }
                    break;
                default:
                    break;
                
            }
        }
        if (parenStack.Count == 0)
        {
            return true;
        }
        return false;

        bool SafeToContinue(char analysisChar)
        {
            if (parenStack.Count != 0 && parenStack[parenStack.Count - 1] == analysisChar)
            {
                parenStack.RemoveAt(parenStack.Count - 1);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
