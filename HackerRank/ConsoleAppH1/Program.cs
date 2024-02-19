using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'compareTriplets' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        List<int> result = new List<int>();
        int alice = 0;
        int bob = 0;
        for (int i = 0; i < 3; i++)
        {
            if (a[i] > b[i])
            {
                alice++;
            }
            else if (a[i] < b[i])
            {
                bob++;
            }
        }
        result.Add(alice);
        result.Add(bob);
        return result;
    }

    public static int simpleArraySum(List<int> ar)
    {
        int sum = 0;
        for (int i = 0; i < ar.Count; i++)
        {
            sum += ar[i];
        }
        return sum;
    }

    /* 
     Input (stdin)
10
1001458909 1004570889 1007019111 1003302837 1002514638 1006431461 1002575010 1007514041 1007548981 1004402249

Expected Output
10047338126
     */

    public static long aVeryBigSum(List<long> ar)
    {
        long result = 0;
        List<int> stepByStep = new List<int>();
        int vkZbir = 0;
        int momentalnaPozicja = 0;
        string reshenie = "";
        while (momentalnaPozicja < 10)
        {
            for (int i = 0; i < ar.Count; i++)
            {
                int number = int.Parse(ar[i].ToString()[momentalnaPozicja].ToString());
                vkZbir += number;

            }
            stepByStep.Add(vkZbir);
            vkZbir = 0;
            momentalnaPozicja++;
        }

        foreach (int i in stepByStep)
        {
            reshenie += i.ToString();
        }
        result = Int64.Parse(reshenie);
        return result;
    }

    //{ -4, 3, -9, 0, 4, 1 };

    /* 
     8
1 2 3 -1 -2 -3 0 0
n p n  n  p  n z z
    0
     Expected Output
0.375000
0.375000
0.250000
     */
    public static void plusMinus(List<int> arr)
    {
        int positive = 0; int negative = 0; int zero = 0;
        foreach (int i in arr)
        {
            if (i > 0) { positive++; } else if (i < 0) { negative++; } else { zero++; }
        }
        double resultPositive = (double)positive / (double)arr.Count;
        double resultNegative = (double)negative / (double)arr.Count;
        double resultZero = (double)zero / (double)arr.Count;
        Console.WriteLine($"{resultPositive:0.000000}");
        Console.WriteLine($"{resultNegative:0.000000}");
        Console.WriteLine($"{resultZero:0.000000}");
    }

    public static void staircase(int n)
    {
        int end = n - 1;
        string test = "";
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j >= end)
                {
                    test += "#";
                }
                else
                {
                    test += " ";
                }

            }
            Console.WriteLine(test);
            test = "";
            end--;
        }
    }

    public static int diagonalDifference(List<List<int>> arr)
    {
        int sumLeft = 0;
        int sumRight = 0;
        int positonLeft = 0;
        int positonRight = arr.Count - 1;
        for (int i = 0; i < arr.Count; i++)
        {
            for (int j = 0; j < arr.Count; j++)
            {
                if (j == positonLeft)
                {
                    sumLeft += arr[i][j];
                }
                if (j == positonRight)
                {
                    sumRight += arr[i][j];
                }
            }
            // Console.WriteLine($"{positonLeft}:positonLeft     {positonRight}:positonRight");

            positonLeft++;
            positonRight--;
        }
        // Console.WriteLine($"{sumLeft}:sumleft     {sumRight}:sumRight    {Math.Abs(sumLeft - sumRight)}: result");
        return Math.Abs(sumLeft - sumRight);
    }

    //140537896 243908675 670291834 923018467 520718469

    //1575456874 2357937445
    //   1575456874  -1937029851
    public static void miniMaxSum(List<int> arr)
    {
        long minResult = 0;
        long maxResult = 0;
        arr.Sort();
        for (int i = 0; i < arr.Count; i++)
        {
            if (i < arr.Count - 1)
            {
                minResult += arr[i];
            }
            if (i > 0)
            {
                maxResult += arr[i];
            }
        }
        Console.WriteLine($"{minResult} {maxResult}");
    }


    /* RESULT OF 4 AND 5
     * https://hr-testcases-us-east-1.s3.amazonaws.com/23074/input04.txt?response-content-type=text%2Fplain&X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAR6O7GJNX5DNFO3PV%2F20240118%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20240118T084338Z&X-Amz-Expires=7200&X-Amz-SignedHeaders=host&X-Amz-Signature=cc49ed83a56a7cccc740ef4f4cfb95f47c1b2a2201153e9e2c5d6a21b7ec61ea
     * 
     * https://hr-testcases-us-east-1.s3.amazonaws.com/23074/input05.txt?response-content-type=text%2Fplain&X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAR6O7GJNX5DNFO3PV%2F20240118%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20240118T082658Z&X-Amz-Expires=7200&X-Amz-SignedHeaders=host&X-Amz-Signature=9a9a854c2e7adce3fd825ba52ae56b55948a8fdf0f00fcd8f5f27dd1542ba68e
     
     */
    public static int birthdayCakeCandles(List<int> candles)
    {
        int result = 0;
        //long maxUnit = 0;
        long maxUnit =candles.Max();

        for (int i = 0; i < candles.Count; i++)
        {
            if (candles[i] == maxUnit)
            {
                result++;
            }
        }

        //var max = candles.Max();
        //var count = candles.Count(it => it == max);
        //  Console.WriteLine(count);
        return result;
    }

    public static string timeConversion(string s)
    {
        DateTime dateTime12 = DateTime.Parse(s);
        string result=dateTime12.ToString("HH:mm:ss");    
        return result;
    }

    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> result = new List<int>();

        for (int j = 0; j < grades.Count; j++)
        {
            for (int i = 40; i <= 100; i += 5)
            {
                if (grades[j] <= i)
                {
                   // Console.WriteLine(grades[j] + "  " + i);
                    //                    result.Add(grades[j]);
                    if (i - grades[j] <= 2)
                    {
                        result.Add(i);
                    }
                    else
                    {
                        result.Add(grades[j]);
                    }
                    break;
                }
            }
          
        }



        foreach (int r in result) { Console.WriteLine(r+" result"); }
        return result;
    }

    // 1  2  2  1  3        3
    //10 20 20 10 10 30 50 10 20
    public static int sockMerchant(int n, List<int> ar)
    {

        int result = 0;
        for(int i=0; i < ar.Count;i++)
        {
          //  Console.WriteLine(i + "  pozicija na i so vrednost " + ar[i]);
            
            for (int j=i+1;j< ar.Count-1; j++)
            {
                if (ar[i] == ar[j])
                {
                 //   Console.WriteLine(i+ " == i  vrednost   j == "+j);
                    result++;
                    ar.RemoveAt(j);
                    ar.RemoveAt(i);
                    i = -1;
                    break;
                }
            }
            //foreach(int left in ar)
            //{
            //    Console.WriteLine(left+"  ostanati");
            //}
        }
        return result;
    }

    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        int countApples = 0;
        int countOranges = 0;

        int appSum = 0;
        for (int app = 0; app < apples.Count; app++)
        {
            appSum = apples[app] + a;
            if (appSum >= s && appSum <= t)
            {
                countApples++;
            }
            appSum = 0;
        }

        int oraSum = 0;
        for (int ora = 0; ora < oranges.Count; ora++)
        {
            oraSum = oranges[ora] + b;
            if (oraSum >= s && oraSum <= t)
            {
                countOranges++;
            }
            oraSum = 0;
        }

        Console.WriteLine(countApples);
        Console.WriteLine(countOranges);
    }


    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
        if(x2 > x1 && v2 > v1)
        {
            return "NO";
        } 

        for(int i =0;i < 10000;i++)
        {
            x1 = x1 + v1;
            x2=x2 + v2;
            if(x1 == x2)
            {
                return "YES";
            }
        }

        return "NO";
    }
    // 9
    //10 5 20 20 4 5 2 25 1              2 4

    //10
    //3 4 21 36 10 28 35 5 24 42    4 0
    public static List<int> breakingRecords(List<int> scores)
    {
        List<int> records = new List<int>();
        int minScore = scores[0];
        int maxScore = scores[0];

        int minCount = 0;
        int maxCount = 0;
        for (int i = 1;i< scores.Count;i++) {
            if (scores[i] < minScore)
            {
                minScore = scores[i];
                minCount++;
            }

            if (scores[i] > maxScore)
            {
                maxScore = scores[i];
                maxCount++;
            }
        }
        records.Add(maxCount);
        records.Add(minCount);
        return records;
    }

    /*
     *STDIN           Function
-----           --------
6 3             n = 6, k = 3
1 3 2 6 1 2     ar = [1, 3, 2, 6, 1, 2]
                      1 2
                      1 2
                      3 6
                      2 1
                      1 2
    
    5

6 3
1 3 2 6 1 2
     */

    public static int divisibleSumPairs(int n, int k, List<int> ar)
    {
        int sum = 0;
        for(int i=0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int sumOfTwo = ar[i] + ar[j];
                //Console.WriteLine($"{ar[i]} + {ar[j]} = {sumOfTwo}");
                if (sumOfTwo % k == 0)
                {
                   // Console.WriteLine(ar[i] + "   " + ar[j]);
                    sum++;
                }
            }
        }

        return sum;
    }
}

class Solution
{
    public static void Main(string[] args)
    {

        //List<int> list = new List<int>() { 1, 2, 3, 4, 10, 11 };
        //Console.WriteLine(Result.simpleArraySum(list));

        //List<long> list = new List<long>() { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
        //Console.WriteLine(Result.aVeryBigSum(list));

        //List<int> list = new List<int>() { 1, 2, 3, - 1, - 2, - 3, 0, 0 };
        //Result.plusMinus(list);
        //Result.staircase(6);


        ////////// diagonalDifference /////////////
        //int n = Convert.ToInt32(Console.ReadLine().Trim());

        //List<List<int>> arr = new List<List<int>>();

        //for (int i = 0; i < n; i++)
        //{
        //    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        //}

        //int result = Result.diagonalDifference(arr);

        //Console.WriteLine(result);

        /////miniMaxSum
        //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        //Result.miniMaxSum(arr);

        //List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();
        //int result = Result.birthdayCakeCandles(candles);
        //Console.WriteLine(result + " result");

        //string s = Console.ReadLine();

        //string result = Result.timeConversion(s);

        //Console.WriteLine(result);

        //        List<int> grades = new List<int>() { 36,6,
        //98,
        //25,
        //97,
        //24,
        //25,
        //70,
        //50,
        //71,
        //30,
        //14,
        //28,
        //100,
        //3,
        //26,
        //61,
        //98,
        //50,
        //41,
        //5,
        //3,
        //28,
        //34,
        //0};
        //       // List<int> grades = new List<int>();

        //        //for (int i = 0; i < grades.Count; i++)
        //        //{
        //        //    int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
        //        //    grades.Add(gradesItem);
        //        //}

        //        List<int> result = Result.gradingStudents(grades);


        //int n = Convert.ToInt32(Console.ReadLine().Trim());

        //List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        //int result = Result.sockMerchant(n, ar);

        //Console.WriteLine(result+"  reshenie");


        //string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        //int s = Convert.ToInt32(firstMultipleInput[0]);

        //int t = Convert.ToInt32(firstMultipleInput[1]);

        //string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        //int a = Convert.ToInt32(secondMultipleInput[0]);

        //int b = Convert.ToInt32(secondMultipleInput[1]);

        //string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        //int m = Convert.ToInt32(thirdMultipleInput[0]);

        //int n = Convert.ToInt32(thirdMultipleInput[1]);

        //List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

        //List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

        //Result.countApplesAndOranges(s, t, a, b, apples, oranges);

        //string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        //int x1 = Convert.ToInt32(firstMultipleInput[0]);

        //int v1 = Convert.ToInt32(firstMultipleInput[1]);

        //int x2 = Convert.ToInt32(firstMultipleInput[2]);

        //int v2 = Convert.ToInt32(firstMultipleInput[3]);

        //string result = Result.kangaroo(x1, v1, x2, v2);
        //Console.WriteLine(result);

        //int n = Convert.ToInt32(Console.ReadLine().Trim());

        //List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        //List<int> result = Result.breakingRecords(scores);

        //foreach(int i in result) {
        //    Console.WriteLine(i);
        //}

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.divisibleSumPairs(n, k, ar);
        Console.WriteLine(result);

    }
}
