# Convert a number to hexidecimal
public class Solution {
    public string ToHex(int num) {
        // handle edge cases
        if (num == 0) {
            return "0";
        }
        
        string result = string.Empty;
        int count = 0;
        
        // Use f as mask to check every 4 bits from right to left.
        // when shift negative number to the right, C# adds 1 to fill in left part.
        // We need to use variable count to avoid infinite loop here.
        while(num != 0 && count < 8) {
            count ++;
            
            // save the result
            int tempNum = num & 15;
            result = GetHex(tempNum) + result;

            // Move to next 4 bits on left
            num = num >> 4;
        }
        
        return result;
    }
    
    public char GetHex(int num) {
        if (num >= 0 && num <= 9) {
            return (char)(num + '0');
        } else {
            return (char)((num - 10) + 'a');
        }
    }
}
