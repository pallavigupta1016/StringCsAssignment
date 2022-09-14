namespace StringAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine(str);
            Console.WriteLine(str[12]);
            string str1 = "is";
            Console.WriteLine(str.Contains(str1));
            string str2 = " and killed it";
            string str3 = str.Insert(str.Length,str2);
            Console.WriteLine(str3);
            Console.WriteLine(str.EndsWith("dogs"));
            string str4 = "The quick brown Fox jumps over the lazy Dog";
            Console.WriteLine(str==str4);
            string str5= "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
            Console.WriteLine(str == str5);
            Console.WriteLine(str.Length);
            string str6 = str.Replace("The", "A");
            Console.WriteLine(str6);
            string[] subs=str.Split(' ');
            foreach(var i in subs)
                Console.WriteLine(i);
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.IndexOf('a'));
            Console.WriteLine(str.LastIndexOf('e'));
            Console.WriteLine(@"I WANDER'D lonely as a cloud
That floats on high o'er vales and hills,
When all at once I saw a crowd,
A host, of golden daffodils;
Beside the lake, beneath the trees,
Fluttering and dancing in the breeze.");
            Console.WriteLine("Enter home directory of tomcat server");
            string path = Console.ReadLine();
            string newPath = @"WebApps/MyApps/Images" + path;
            Console.WriteLine(newPath);
        }
    }
}