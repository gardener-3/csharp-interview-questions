namespace arrays_and_strings;

public class InterViewQuestions
{
    //Is Unique: Implement an algorithm to determine if a string has all unique characters. What if you
    //cannot use additional data structures?
    // the question to ask is should we support ascii or unicode. if ascii then limited to 128 or 256 ?
    public bool IsUnique(string testString)
    {
        var splitChars = testString.Replace(" ", "").ToCharArray();
        var resultArray = new int[128];
        foreach (var c in splitChars)
        {
            if (resultArray[(int)c] == 1){
                return false;
            }
            else
            {
                resultArray[(int)c] = 1;
            }
            
        }
        return true;
    }

    public bool CheckPermutation(string testString)
    {
        
        return false;
    }
}