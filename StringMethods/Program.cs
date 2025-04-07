class Program
{
    public static void Main(string[] args)
    {
        string str = "RAKSHITH";
        string str1 = "Datalyzer";
        string str2 = "GEC Hassan";
        string str3 = " GEC ";
        int len = str.Length;
        int len1 = str1.Length;
        int len2= str2.Length;
        bool result = string.IsNullOrEmpty(str);
        bool result1 = string.IsNullOrEmpty(str1);  
        bool result2 = string.IsNullOrEmpty(str2);
        Console.WriteLine("string is empty or not");
        Console.WriteLine(result);
        
        Console.WriteLine("length of string");
        Console.WriteLine(len);
        
        
        Console.WriteLine("string is whitespace or not");
        Console.WriteLine(result1);
        
        
        Console.WriteLine("string is whitespace or not");
        Console.WriteLine(result2);
        
        bool result3 = string.IsNullOrWhiteSpace(str2);
        Console.WriteLine("string is whitespace or not");
        Console.WriteLine(result3);
        
        Console.WriteLine(str.Contains("RAKS"));

        Console.WriteLine(str1.StartsWith("Data"));

        Console.WriteLine(str2.StartsWith("Hassan"));

        Console.WriteLine(str1.LastIndexOf("a"));

        Console.WriteLine(str.IndexOf("R"));

        Console.WriteLine(str.ToUpper());

        Console.WriteLine(str3.Trim());

        Console.WriteLine(str3.TrimStart());

        Console.WriteLine(str3.TrimEnd());

        Console.WriteLine(str1.Replace("Data", "Datalyzer"));

        Console.WriteLine(str1.Substring(0, 4));
        
        Console.WriteLine(str2.Split(" "));

    }
}