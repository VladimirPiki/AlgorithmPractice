using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            int b = 6405;
            int c = 95;
            string stringC = c.ToString();

            List<string> vkupnaLista = new List<string>();
            List<int> broevi = new List<int>();

            for (int i = a; i <= b; i++)
            {
                string stringAB = i.ToString();

                int j1 = 0;
                bool found = false;
                string saveInt = "";

                for (int k = 0; k < stringC.Length; k++)
                {
                    for (int j = j1; j < stringAB.Length; j++)
                    {
                        if (stringAB[j] == stringC[k])
                        {
                            found = true;
                            j1 = j + 1;
                            saveInt += stringC[k];
                            break;
                        }
                        else
                        {
                            found = false;
                        }
                    }
                }

                if (found && saveInt == stringC)
                {
                    vkupnaLista.Add(stringAB);
                    broevi.Add(i);
                }
            }

            Console.WriteLine(broevi.Count + " reshenie");


        }
    }
}
