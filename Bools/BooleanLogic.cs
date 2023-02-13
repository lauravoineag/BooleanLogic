namespace ConsoleApp2;

public class Solution {
    public bool CalculateSolution(string input)
    {
        bool hasChar = false;
        bool hasDigit = false;
        bool hasSpecial = false;
        bool hasSpace = false;
        string specials = "[@_!#$%^&*()<>?/|}{~:]";
        
        if(input.Length<6)
        {
            return false;
        }

        foreach(var item in input)
        {
            
            if(char.IsDigit(item))
            {
                hasDigit = true;
            }

            if (Char.IsWhiteSpace(item))
            {
                hasSpace = true;
            }
            if (char.IsLetter(item))
            {
                hasChar = true;
            }
            
            if (specials.Contains(item))
            {
                hasSpecial = true;
            }
        }
        return true;
    }
}