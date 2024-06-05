using _05_06_2024;
using System.Globalization;
using System.Text;

//Student student = new Student("Sabir", "Mehdiyev", 20, 80);
//Console.WriteLine(student.GetInfo());
//Console.ReadLine();

//Teacher teacher = new Teacher("Teymur", "Nebiyev", 28, 2500);

//string text2 = "hello";
//text2 = "hello world";
//int[] arr1 = { 1, 2, 3 };
//int[] arr2 = { 1, 2, 3 };
//Console.WriteLine(text1);
//Console.WriteLine(text2);
//arr1 = arr2;
//arr1[0] = 5;
//Console.WriteLine(arr1[0]);
//Console.WriteLine(arr2[0]);
//Console.WriteLine(arr1 == arr2);
//Console.WriteLine(text1 == text2);

//string[] texts = { "salam", "sagol" };
//string[] texts2 = { "salam", "test" };
//Console.WriteLine(texts[0] == texts2[0]);
string text1 = "HELLO";

//Console.WriteLine(text1.Length);
//Console.WriteLine(text1.Contains("h"));
//Console.WriteLine(text1.IndexOf("a"));
//Console.WriteLine(text1.LastIndexOf("l"));
//Console.WriteLine(text1.ToUpper());
//Console.WriteLine(text1.ToLower());
//CultureInfo cultureInfo = new CultureInfo("en-US");
//Console.WriteLine(text1.Replace("l", "m"));
//Console.WriteLine(text1.Replace("l", "m", true, cultureInfo));
//Console.WriteLine(text1.Trim());
//string result = string.Concat(text1, " world");
//Console.WriteLine(result);
//Console.WriteLine(text1 += " world");

Console.WriteLine(Reverse(text1));
//hello
//string Reverse(string text)
//{
//    string result = "";
//    for (int i = text.Length - 1; i >= 0; i--)
//    {
//        result += text[i];
//    }
//    return result;
//}

string Reverse(string text)
{
    StringBuilder result = new StringBuilder(); 
    for (int i = text.Length - 1; i >= 0; i--)
    {
        result.Append(text[i]);
    }
    return result.ToString();
}