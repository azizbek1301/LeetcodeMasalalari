

public class Solution
{
    //public string IntToRoman(int num)
    //{
    //    var romanNumbers = new Dictionary<int, string>()
    //    {
    //        { 1000, "M" },
    //        { 900, "CM" },
    //        { 500, "D" },
    //        { 400, "CD" },
    //        { 100, "C" },
    //        { 90, "XC" },
    //        { 50, "L" },
    //        { 40, "XL" },
    //        { 10, "X" },
    //        { 9, "IX" },
    //        { 5, "V" },
    //        { 4, "IV" },
    //        { 1, "I" }
    //    };

    //    string result=string.Empty;

    //    foreach (var item in romanNumbers.OrderByDescending(x=>x.Key))
    //    {
    //        while(num>=item.Key)
    //        {
    //            result += item.Value;
    //            num-=item.Key;
    //        }
    //    }
    //    return result;
    //}


    
    private static readonly string[] minglar = { "","M","MM","MMM"};
    private static readonly string[] yuzlar = { "","C","CC","CCC","CD","D","DC","DCC","DCCC","CM"};
    private static readonly string[] onlar = { "","X","XX","XXX","XL","L","LX","LXX","LXXX","XC"};
    private static readonly string[] birlar = { "","I","II","III","IV","V","VI","VII","VIII","IX"};

    public string IntToRoman(int n)
    {
        return minglar[n / 1000] + yuzlar[n % 1000 / 100] + onlar[n % 100 / 10] + birlar[n%10];
    }
   
}