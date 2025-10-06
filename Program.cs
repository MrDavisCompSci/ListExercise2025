// Console template
using System;
class Program
{
    static void Main()
    {
        // Declare an empty list
        List<string> clothes = new List<string>();

        // len(clothes)
        Console.WriteLine($"Count: {clothes.Count}");

        // append(“socks”)
        clothes.Add("socks");

        // append(“shoes”)
        clothes.Add("shoes");

        // append(“hat”)
        clothes.Add("hat");

        // append(“socks”)
        clothes.Add("socks");

        // count(“socks”)
        // method 1
        int sockCount = 0;
        for (int i = 0; i < clothes.Count; i++)
        {
            if (clothes[i] == "socks")
            {
                sockCount++;
            }
        }
        // method 2
        sockCount = 0;
        foreach (string s in clothes)
        {
            if (s == "socks")
            {
                sockCount++;
            }
        }

        Console.WriteLine($"sockCount: {sockCount}");
        // index(“shoes”)
        Console.WriteLine(clothes.IndexOf("shoes"));

        // len(clothes)
        Console.WriteLine(clothes.Count);

        // insert(2, “gloves”)
        clothes.Insert(2, "gloves");


        // remove(“socks”)
        clothes.Remove("socks");

        // remove(“shirt”)
        clothes.Remove("shirt");

        // append(“socks”)
        clothes.Add("socks");

        // append(“shorts”)
        clothes.Add("shorts");

        // len(clothes)
        Console.WriteLine(clothes.Count);

        // index(“gloves”)
        Console.WriteLine(clothes.IndexOf("gloves"));
    }
}

