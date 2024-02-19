using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNET
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            bool isDone = false;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        //Console.WriteLine($"{i} i {j}"); 
                        isDone = true;
                        break;
                    }
                }
                if (isDone) { break; }
            }
            return result;
        }

        public bool IsPalindrome(int x)
        {
            string xAsString = x.ToString();
            int lenghtOfx = xAsString.Length;
            int reverseStart = 1;
            string result = "";
            bool isPalindrome = false;

            for (int i = 0; i < lenghtOfx; i++)
            {
                char start = xAsString[i];
                for (int j = lenghtOfx - reverseStart; j >= 0; j--)
                {
                    char end = xAsString[j];
                    reverseStart++;
                    if (start == end)
                    {
                        result += xAsString[i];
                        break;
                    }
                    break;
                }
            }

            if (result == xAsString)
            {
                isPalindrome = true;
            }
            return isPalindrome;
        }

        public bool HalvesAreAlike(string s)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int firstHalf = 0; int secoundHalf = 0;
            int half = s.Length / 2;
            bool isHalvesAreAlike = false;

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (s[i] == vowels[j])
                    {
                        if (i < half)
                        {
                            firstHalf++;
                        }
                        else
                        {
                            secoundHalf++;
                        }
                    }
                }
            }

            if (firstHalf == secoundHalf)
            {
                isHalvesAreAlike = true;
            }
            return isHalvesAreAlike;
        }

        //public int RomanToInt(string s)
        //{
        //    Dictionary<char, int> symbol = new Dictionary<char, int>
        //        {
        //            {'I', 1},
        //            {'V', 5},
        //            {'X', 10},
        //            {'L', 50},
        //            {'C', 100},
        //            {'D', 500},
        //            {'M', 1000}
        //        };

        //    int result = 0;
        //    for (int i = s.Length - 1; i >= 0; i--)
        //    {
        //        if (i > 0)
        //        {
        //            switch (s[i - 1])
        //            {
        //                case 'I':
        //                    if (s[i] == 'V')
        //                    {
        //                        result += 4;
        //                        i--;
        //                    }
        //                    else if (s[i] == 'X')
        //                    {
        //                        result += 9;
        //                        i--;
        //                    }
        //                    else
        //                    {
        //                        if (symbol.ContainsKey(s[i]))
        //                        {
        //                            result += symbol[s[i]];
        //                        }
        //                    }
        //                    break;
        //                case 'X':
        //                    if (s[i] == 'L')
        //                    {
        //                        result += 40;
        //                        i--;
        //                    }
        //                    else if (s[i] == 'C')
        //                    {
        //                        result += 90;
        //                        i--;
        //                    }
        //                    else
        //                    {
        //                        if (symbol.ContainsKey(s[i]))
        //                        {
        //                            result += symbol[s[i]];
        //                        }
        //                    }
        //                    break;
        //                case 'C':
        //                    if (s[i] == 'D')
        //                    {
        //                        result += 400;
        //                        i--;
        //                    }
        //                    else if (s[i] == 'M')
        //                    {
        //                        result += 900;
        //                        i--;
        //                    }
        //                    else
        //                    {
        //                        if (symbol.ContainsKey(s[i]))
        //                        {
        //                            result += symbol[s[i]];
        //                        }
        //                    }
        //                    break;

        //                default:
        //                    if (symbol.ContainsKey(s[i]))
        //                    {
        //                        result += symbol[s[i]];
        //                    }
        //                    break;
        //            }
        //        }
        //        else
        //        {
        //            if (symbol.ContainsKey(s[i]))
        //            {
        //                result += symbol[s[i]];
        //            }
        //        }
        //    }
        //    return result;
        //}

        public int RomanToInt(string s)
        {
            Dictionary<char, int> romanNumbersDictionary = new Dictionary<char, int>()
        {
            {'I', 1},{'V', 5},{'X', 10},{'L', 50},{'C', 100},{'D', 500},{'M', 1000}
        };

            if (s.Length == 1) { return romanNumbersDictionary[s[0]]; }

            int sum = 0;
            int lastNumber = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                int number = romanNumbersDictionary[s[i]];
                if (number >= lastNumber)
                {
                    sum += number;
                    lastNumber = number;
                }
                else
                {
                    sum -= number;
                }
            }
            return sum;
        }

        public string LongestCommonPrefix(string[] strs)
        {

            if (strs.Length == 0)
            {
                return "";
            }
            Array.Sort(strs);

            string prefix = "";
            for (int i = 0; i < strs[0].Length; i++)
            {
                char c = strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (i >= strs[j].Length || strs[j][i] != c)
                    {
                        return prefix;
                    }
                }
                prefix += c;
            }
            return prefix;
        }
        //static bool Contain(char c,string str)
        //{
        //    string reverse="";
        //    switch (c) { 
        //        case '{': reverse += "}";break;
        //        case '(': reverse += ")"; break;
        //        case '[': reverse += "]"; break;

        //        case '}': reverse += "{"; break;
        //        case ')': reverse += "{"; break;
        //        case ']': reverse += "["; break;
        //    }

        //    str.Contains(c);    
        //}
        public bool IsValid(string s)
        {
            if (s.Length % 2 == 0)
            {
                Stack<char> stackOpen = new Stack<char>();
                Stack<char> stackClose = new Stack<char>();
                bool isValid = false;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[0] == '(' || s[0] == '{' || s[0] == '[')
                    {
                        if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                        {
                            stackOpen.Push(s[i]);
                        }
                        else if (s[i] == ')' || s[i] == '}' || s[i] == ']')
                        {
                            if (stackOpen.Count > 0)
                            {
                                char test = stackOpen.Peek();
                                if (s[i] == ')')
                                {
                                    char newTest = '(';
                                    if (test != newTest)
                                    {
                                        isValid = true;
                                        break;
                                    }
                                }
                                else if (s[i] == ']')
                                {
                                    char newTest = '[';
                                    if (test != newTest)
                                    {
                                        isValid = true;
                                        break;
                                    }
                                }
                                else if (s[i] == '}')
                                {
                                    char newTest = '{';
                                    if (test != newTest)
                                    {
                                        isValid = true;
                                        break;
                                    }
                                }
                                stackOpen.Pop();
                            }
                            else
                            {
                                stackClose.Push(s[i]);
                            }
                        }

                    }
                    else
                    {
                        return false;
                    }

                }

                if(stackClose.Count > 0 || stackOpen.Count > 0)
                {
                    return false;
                }

                if (isValid)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            else
            {
                return false;
            }

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            //int[] nums = new int[4] { 2, 7, 11, 15 };
            //int target = 9;
            //int[] nums = new int[3] { 3, 2, 4 };
            //int target = 6;
            //int[] nums = new int[2] { 3, 3 };
            //int target = 6;

            //Solution solution = new Solution();

            //int[] result = solution.TwoSum(nums, target);

            ////// Print the result to the console
            //Console.WriteLine("[" + result[0] + "," + result[1] + "]");
            //int[] result = new int[2];
            //bool isDone = false;
            //for (int i = 0; i < nums.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        if ((nums[i] + nums[j]) == target)
            //        {
            //            result[0] = i;
            //            result[1] = j;
            //            //Console.WriteLine($"{i} i {j}"); 
            //            isDone = true;
            //            break;
            //        }
            //    }
            //    if (isDone) { break; }
            //}

            //int x = 1221;
            //string xAsString = x.ToString();
            //int lenghtOfx=xAsString.Length;
            //string start = "";
            //string end = "";

            //for (int i = 0; i < lenghtOfx; i++)
            //{
            //  //  char start = xAsString[i];  

            //    System.Diagnostics.Debug.WriteLine($"VREDNOST: {xAsString[i]}  POZICIJA {i}");
            //    for(int j = lenghtOfx - 1;j >= 0; j--)
            //    {
            //        //char end= xAsString[j];
            //        System.Diagnostics.Debug.WriteLine($"VREDNOST: {xAsString[j]}  POZICIJA {j}");
            //        //if (start== end)
            //        //{
            //        //    Console.WriteLine(xAsString[i]);
            //        //    break;
            //        //}
            //    }  
            //}

            //int x = 10;
            //string xAsString = x.ToString();
            //int lenghtOfx = xAsString.Length;
            //int reverseStart = 1;
            //string result = "";
            //bool isPalindrome=false;

            //for (int i = 0; i < lenghtOfx; i++)
            //{
            //    char start = xAsString[i];
            //    System.Diagnostics.Debug.WriteLine($"VREDNOST na i: {xAsString[i]}  POZICIJA {i}");
            //    for (int j = lenghtOfx- reverseStart; j >= 0; j--)
            //    {
            //        char end = xAsString[j];    

            //        reverseStart++;
            //        //char end= xAsString[j];
            //        System.Diagnostics.Debug.WriteLine($"VREDNOST na j: {xAsString[j]}  POZICIJA {j}");
            //       // Console.WriteLine(xAsString[j]);

            //        if (start == end)
            //        {          
            //            result += xAsString[i];
            //            break;
            //        }

            //        break;
            //    }
            //}

            //if(result == xAsString)
            //{
            //    isPalindrome = true;    
            //    Console.WriteLine(xAsString);
            //}

            //string s = "book";
            //char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            //int firstHalf = 0; int secoundHalf = 0;
            //int half = s.Length / 2;
            //bool isHalvesAreAlike = false;

            //if (s.Length % 2 == 0)
            //{
            //    //string firstHalf=s.Substring(0, s.Length/2);
            //    //string secoundHalf = s.Substring(0, s.Length / 2);
            //    //Console.WriteLine(firstHalf);
            //    //Console.WriteLine(secoundHalf);

            //    for (int i = 0; i < s.Length; i++)
            //    {
            //        for (int j = 0; j < vowels.Length; j++)
            //        {
            //            if (s[i] == vowels[j])
            //            {
            //                if (i < half)
            //                {
            //                    firstHalf++;
            //                }
            //                else
            //                {
            //                    secoundHalf++;
            //                }
            //            }
            //        }
            //    }

            //    if (firstHalf == secoundHalf)
            //    {
            //        isHalvesAreAlike = true;
            //    }
            //    else
            //    {
            //        isHalvesAreAlike = false;
            //    }

            //   Console.WriteLine(isHalvesAreAlike+" "+firstHalf+" "+secoundHalf);

            // Console.WriteLine(solution.HalvesAreAlike(s));


            ////////////0123456
            //string s = "III";
            //Dictionary<char, int> symbol = new Dictionary<char, int>
            //    {
            //        {'I', 1},
            //        {'V', 5},
            //        {'X', 10},
            //        {'L', 50},
            //        {'C', 100},
            //        {'D', 500},
            //        {'M', 1000}
            //    };

            //int result = 0;
            //for (int i = s.Length - 1; i >= 0; i--)
            //{
            //  //  Console.WriteLine(i + "  na red vrednost->" + s[i]);
            //    if (i > 0)
            //    {
            //        switch (s[i - 1]) {
            //            case 'I':
            //                if (s[i] =='V')
            //                {
            //                    result += 4;
            //                    i--;
            //                }
            //                else if (s[i] == 'X')
            //                {
            //                    result += 9;
            //                    i--;
            //                }
            //                else
            //                {
            //                    if (symbol.ContainsKey(s[i]))
            //                    {
            //                        result += symbol[s[i]];
            //                    }
            //                }
            //                break;
            //            case 'X':
            //                if (s[i] == 'L')
            //                {
            //                    result += 40;
            //                    i--;
            //                }
            //                else if (s[i] == 'C')
            //                {
            //                    result += 90;
            //                    i--;
            //                }
            //                else
            //                {
            //                    if (symbol.ContainsKey(s[i]))
            //                    {
            //                        result += symbol[s[i]];
            //                    }
            //                }
            //                break;
            //            case 'C':
            //                if (s[i] == 'D')
            //                {
            //                    result += 400;
            //                    i--;
            //                }
            //                else if (s[i] == 'M')
            //                {
            //                    result += 900;
            //                    i--;
            //                }
            //                else
            //                {
            //                    if (symbol.ContainsKey(s[i]))
            //                    {
            //                        result += symbol[s[i]];
            //                    }
            //                }
            //                break;

            //            default:
            //                if (symbol.ContainsKey(s[i]))
            //                {                          
            //                    result += symbol[s[i]];
            //                }
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        if (symbol.ContainsKey(s[i]))
            //        {
            //            result += symbol[s[i]];
            //        }
            //    }
            //}
            //Console.WriteLine(result+" output");


            //for (int i = s.Length-1; i >= 0; i--)
            //{
            //    Console.WriteLine(i+"  na red vrednost->" + s[i]);
            //    if (i > 0)
            //    {
            //        //switch
            //        if(s[i-1] == 'I')
            //        {

            //            i--;
            //        }
            //        else
            //        {
            //            Console.WriteLine(s[i] + " " + s[i - 1]);
            //            if (symbol.ContainsKey(s[i]))
            //            {

            //            }
            //        }
            //    }
            //}

            //string s = "MCMXCIV";
            //Console.WriteLine(solution.RomanToInt(s));

            //string[] strs = new string[] { "flower", "flow", "flight" };
            //string[] strs = new string[] { "dog","racecar","car" };

            //Console.WriteLine(solution.LongestCommonPrefix(strs));
            // Console.WriteLine(prefix);

            string s = "(){{";
            Console.WriteLine(solution.IsValid(s));

        }


    }
}
