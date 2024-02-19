using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2NET
{

    public class Solution
    {
        //public int RemoveDuplicates(int[] nums)
        //{
        //    List<int> num = new List<int>(nums);
        //    int i = 0;
        //    while (i < num.Count)
        //    {
        //        for (int j = i + 1; j < num.Count; j++)
        //        {
        //            if (nums[i] == nums[j])
        //            {
        //                num.RemoveAt(i);
        //                i = 0;
        //                break;
        //            }
        //        }
        //        i++;
        //    }

        //    return num.Count;
        //}

        // 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            int j = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                // Console.WriteLine(nums[i] + " <-num i    numj ->" + nums[j]);
                if (nums[j] != nums[i])
                {
                    nums[++j] = nums[i];
                }
            }

            return j + 1;
        }

        public int RemoveElement(int[] nums, int val)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            List<int> list = new List<int>(nums);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == val)
                {
                    list.RemoveAt(i);
                    i = 0;
                }
            }
            return list.Count;
        }


        ////("sadbutsad", "sad") 
        ////leetcode   leeto
        ////mississippi  issip
        ////hello ll
        //public int StrStr(string haystack, string needle)
        //{
        //    int a = 0;
        //    int output = -1;

        //    string zbor = "";
        //    bool voopstoGoNema = false;

        //    for (int i = 0; i < haystack.Length; i++)
        //    {
        //        bool jaima = false;
        //        for (int j = a; j < needle.Length; j++)
        //        {
        //            if (haystack[i] == needle[j])
        //            {
        //                jaima = true;
        //                break;
        //            }
        //            else
        //            {
        //                voopstoGoNema = true;
        //            }
        //        }

        //        if (jaima)
        //        {
        //            zbor += haystack[i];
        //            a++;
        //        }
        //        else
        //        {
        //            if (voopstoGoNema == false)
        //            {
        //                if (i > 0)
        //                {
        //                    i = i - 1;

        //                }
        //                if (zbor == needle)
        //                {
        //                    // list.Add(zbor);
        //                    output = i - needle.Length + 1;
        //                }

        //                zbor = "";
        //                a = 0;
        //            }

        //        }
        //    }
        //    return output;
        //}

        //https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/submissions/1147725200/

        // iragriagrianec  agrian     i  
        //("sadbutsad", "sad") 
        //leetcode   leeto
        //mississippi  issip
        //hello ll
        public int StrStr(string haystack, string needle)
        {
            int output = -1;
            if (needle.Length > haystack.Length)
            {
                return output;
            }
            else if (needle.Length == 0)
            {
                if (haystack == needle)
                {
                    output = 0;
                    return output;
                }
                else
                {
                    return output;
                }
            }
            else
            {

                int temp = 0;
                string gonajdov = "";
                List<int> list = new List<int>();
                for (int i = 0; i < haystack.Length; i++)
                {
                    bool find = false;
                    for (int j = temp; j < needle.Length; j++)
                    {
                        if ((i + j) < haystack.Length)
                        {
                            if (haystack[i + j] != needle[j])
                            {
                                break;
                            }
                            find = true;
                            gonajdov += haystack[i + j];
                        }
                    }

                    if (find)
                    {
                        if (gonajdov == needle)
                        {
                            Console.WriteLine(gonajdov + " " + i);
                            output = i;
                            break;
                        }

                        gonajdov = "";
                    }


                }
            }

            //  Console.WriteLine(gonajdov);
            return output;
        }

        public int SearchInsert(int[] nums, int target)
        {
            int output = 0;
            if (nums.Length == 1)
            {
                if (target > nums[0])
                {
                    output = 1;

                }

            }
            else
            {

                bool found = false;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == target) { output = i; found = true; break; }
                }
                if (!found)
                {
                    for (int i = 1; i < nums.Length; i++)
                    {
                        if (nums[i - 1] < target && target < nums[i])
                        {
                            output = i;
                        }
                        else if (target > nums[i])
                        {
                            output = i + 1;
                        }
                    }
                }

            }


            return output;
        }

        //public int LengthOfLastWord(string s)
        //{
        //    List<string> list = new List<string>();
        //    List<string> resultList = new List<string>();
        //    list = s.Split(' ').ToList();
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        bool delete = false;
        //        //for (int j = 0; j < list[i].Length; j++)
        //        //{
        //            if (list[i] == "")
        //            {
        //                delete = true;

        //               // break;
        //            }
        //      //  }
        //        if (delete)
        //        {
        //            list.RemoveAt(i);
        //            i = 0;

        //        }
        //  //      Console.WriteLine(list[i]);
        //    }

        //    //foreach (string l in list)
        //    //{
        //    //    Console.WriteLine(l);
        //    //}

        //    return list[list.Count - 1].Length;
        //}

        public int LengthOfLastWord(string s)
        {
            List<string> list = new List<string>();
            List<string> resultList = new List<string>();
            list = s.Split(' ').ToList();
            for (int i = 0; i < list.Count; i++)
            {
                bool delete = false;
                if (list[i] == "")
                {
                    delete = true;
                }
                if (delete)
                {
                    list.RemoveAt(i);
                    i = 0;
                }
            }

            return list[list.Count - 1].Length;
        }

        public string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }

        public int[] PlusOne(int[] digits)
        {
            int lastItem = digits.Last() + 1;
            string last = lastItem.ToString();
            // Console.WriteLine(last);
            List<int> array = new List<int>();
            if(digits.Length > 0)
            {
                for (int i = 0; i < digits.Length-1; i++)
                {
                    //int number = int.Parse(last[i].ToString());
                    array.Add(digits[i]);
                }
            }
         
            if (lastItem > 9)
            {
                for (int i = 0; i < last.Length; i++)
                {
                    int number = int.Parse(last[i].ToString());   
                    array.Add(number);
                }
            }
            else
            {
                array.Add(lastItem);
            }

            int[] result = array.ToArray();

            //foreach (int i in result)
            //{
            //    Console.WriteLine(i);   
            //}   
            return result;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();


            ////////////////////////// 0 _  1 _   _  2  _  3  _  4
            //int[] nums1 = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            //int[] nums1 = new int[] {  1, 1, 2 };
            // solution.RemoveDuplicates(nums1);
            //   Console.WriteLine(solution.RemoveDuplicates(nums1)+ " reshenie");

            //  int[] nums1 = new int[] { 3, 2, 2, 3 };
            //Console.WriteLine(solution.RemoveElement(nums1,2) +" reshenie"); 

            //Console.WriteLine(solution.StrStr("sadbutsad", "sad") + " reshenie");
            //Console.WriteLine(solution.StrStr("a", "a") + " reshenie");
            //SearchInsert(int[] nums, int target)
            //int[] nums = new int[] { 1, 3, 5, 6 };
            //Console.WriteLine(solution.SearchInsert(nums,0));

            //string s = "   fly me   to   the moon  ";
            //Console.WriteLine(solution.LengthOfLastWord(s));

            // Console.WriteLine(solution.StringToBinary("12")); 
            int[] digits ={ 1,2,3,10 };
            Console.WriteLine(solution.PlusOne(digits));
        }
    }
}

