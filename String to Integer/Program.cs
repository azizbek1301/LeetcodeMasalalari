public class Solution
{
    public int MyAtoi(string str)
    {
        int result = 0;
        int sign = 1;
        int i = 0;
        int n = str.Length;

        // Skip leading whitespace
        while (i < n && char.IsWhiteSpace(str[i]))
        {
            i++;
        }

        // Check for sign
        if (i < n && (str[i] == '+' || str[i] == '-'))
        {
            sign = str[i] == '+' ? 1 : -1;
            i++;
        }

        // Convert digits
        while (i < n && char.IsDigit(str[i]))
        {
            int digit = str[i] - '0';

            // Check for overflow
            if ((result > int.MaxValue / 10) || (result == int.MaxValue / 10 && digit > 7))
            {
                return sign == 1 ? int.MaxValue : int.MinValue;
            }

            result = result * 10 + digit;
            i++;
        }

        // Return result considering sign
        return result * sign;
    }

}
