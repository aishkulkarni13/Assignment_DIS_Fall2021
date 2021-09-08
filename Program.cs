using System;
using System.Collections.Generic;

namespace Assignment_1
{
    class Program
    {
        //Question 1
        static public Boolean HalvesAreAlike(string s)
        {
            string s1 = s.Substring(0, s.Length / 2);
            string s2 = s.Substring(s.Length / 2);
            int vowelsCOunt1 = 0;
            int vowelsCount2 = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == 'a' || s1[i] == 'e' || s1[i] == 'i' || s1[i] == 'o' || s1[i] == 'u')
                {
                    vowelsCOunt1++;
                }
                if (s2[i] == 'a' || s2[i] == 'e' || s2[i] == 'i' || s2[i] == 'o' || s2[i] == 'u')
                {
                    vowelsCount2++;
                }

            }
            if (vowelsCOunt1 == vowelsCount2)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        //Question 2
        static public Boolean CheckIfPangram(string s)
        {
            {
                string alphabets = "abcdefghijklmnopqrstuvwxyz";
                int counter = 0;
                foreach (char c in alphabets)
                {
                    foreach (char d in s.ToLower())
                    {
                        if (c == d)
                        {
                            counter++;
                            break;
                        }
                    }
                }
                if (counter == 26)
                    return true;
                else
                    return false;

            }
        }

        //Question 3
        static public int MaximumWealth(int[,] arr)
        {

            int highest = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int total = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    total = total + arr[i, j];
                }
                if (highest < total)
                {
                    highest = total;
                }
            }
            return highest;
        }

        //Question 4
        static public int NumJewelsInStones(string jewels, string stones)
        {
            int counter = 0;

            try
            {
                foreach (char c in stones)
                {
                    if (jewels.Contains(c))
                    {
                        counter++;
                    }

                }
                return counter;

            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }
        }

        //Question 5
        static public string RestoreString(string word2, int[] indices)
        {
            try
            {
                {
                    var alpha_list = new List<char>();
                    foreach (char c in word2)
                    {
                        alpha_list.Add(c);
                    }

                    int count = 0;
                    foreach (char c in word2)
                    {
                        alpha_list[indices[count]] = c;
                        count++;
                    }

                    string finalstring = string.Join("", alpha_list);
                    return finalstring;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }


        //Question 6
        static public int[] CreateTargetArray(int[] nums, int[] index)
        {
            var target_list = new List<int>(nums.Length);
            if (nums.Length == index.Length && nums.Length >= 1 && nums.Length <= 100 && index.Length >= 1 && index.Length <= 100)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] >= 0 && nums[i] <= 100 && index[i] >= 0 && index[i] <= i)
                    {
                        target_list.Insert(index[i], nums[i]);
                    }
                }
            }
            int[] target_array = target_list.ToArray();
            return target_array;
        }
        static void Main(string[] args)
        {

            //Question 1
            Console.WriteLine("Q1 : Enter the string:");
            string s = Console.ReadLine();

            if (s.Length % 2 == 0 && s.Length >= 2 && s.Length <= 1000)
            {
                bool pos = HalvesAreAlike(s);
                if (pos)
                {
                    Console.WriteLine("Both Halfs of the string are alike");
                }
                else
                {
                    Console.WriteLine("Both Halfs of the string are not alike");
                }

            }
            else
            {
                Console.WriteLine("The length of string is not even. Please enter a string with even length. Thank you");
            }

            Console.WriteLine();

            //Question 2:
            Console.WriteLine(" Q2 : Enter the string to check for pangram:");
            string s1 = Console.ReadLine();
            bool flag = CheckIfPangram(s1);
            if (flag)
            {
                Console.WriteLine("Yes, the given string is a pangram");
            }
            else
            {
                Console.WriteLine("No, the given string is not a pangram");
            }
            Console.WriteLine();

            //Question 3:
            int[,] arr = new int[,] { { 1, 2, 3 }, { 3, 2, 1 } };
            int Wealth = MaximumWealth(arr);
            Console.WriteLine("Q3:");
            Console.WriteLine("Richest person has a wealth of {0}", Wealth);
            Console.WriteLine();


            //Question 4:
            string jewels = "aa";
            string stones = "aaabbbb";
            Console.WriteLine("Q4:");
            int num = NumJewelsInStones(jewels, stones);
            Console.WriteLine("the number of stones you have that are also jewels are {0}", num);

            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            string word2 = "aaiougrt";
            int[] indices = { 4, 0, 2, 6, 7, 3, 1, 5 };
            string rotated_string = RestoreString(word2, indices);
            Console.WriteLine("The Final string after rotation is " + rotated_string);
            Console.WriteLine();


            //Quesiton 6:
            Console.WriteLine("Q6: ");
            int[] nums = { 0, 1, 2, 3, 4 };
            int[] index = { 0, 1, 2, 2, 1 };
            int[] target = CreateTargetArray(nums, index);
            Console.WriteLine("Target array  for the Given array's is:");
            for (int i = 0; i < target.Length; i++)
            {
                Console.Write(target[i] + "\t");
            }
            Console.WriteLine();

        }
    }
}
