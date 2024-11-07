using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Unesite brojeve odvojene razmacima:");
        string input = Console.ReadLine();
    
        string[] inputWithoutSpaces = input.Split(' ');
        int[] nums = Array.ConvertAll(inputWithoutSpaces, int.Parse);
    
        List<int> currPerms = new List<int>();
        List<bool> usedNums = new List<bool>(new bool[nums.Length]);
    
        Console.WriteLine("Permutacije su:");
        GeneratePerms(currPerms,usedNums,nums);

    }

    static void GeneratePerms(List<int> currPerms, List<bool> usedNums, int[] nums)
    {
        if (currPerms.Count == nums.Length)
        {
            Console.WriteLine(string.Join(", ", currPerms));
            return;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (usedNums[i]==false)
            {
                usedNums[i] = true;
                currPerms.Add(nums[i]);
                GeneratePerms(currPerms,usedNums,nums);
                currPerms.RemoveAt(currPerms.Count - 1);
                usedNums[i] = false;
            }
        }
    }
}
