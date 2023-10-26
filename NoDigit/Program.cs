string str = Console.ReadLine();
string result = String.Empty;
string pattern = "0123456789";

foreach (char item in str)
{
    if (char.IsDigit(item))
    {
        pattern = pattern.Replace(item.ToString(), "");
    }
}

if (pattern.Length == 0)
{
    Console.WriteLine("NO");
}
else
{
    Console.WriteLine(pattern);
}