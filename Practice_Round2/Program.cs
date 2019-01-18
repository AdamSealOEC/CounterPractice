using System;
using System.Collections.Generic;

namespace Practice_Round2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> masterList = new List<string>();

            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    for (int k = 0; k < 11; k++)
                    {
                        for (int g = 0; g < 11; g++)
                        {
                            for (int h = 0; h < 11; h++)
                            {
                                int sum = k + i + j + g + h;
                                if (sum == 19)
                                {
                                    List<int> list = new List<int>();
                                    if (i!=0)
                                        list.Add(i);
                                    if (j != 0)
                                        list.Add(j);
                                    if (k != 0)
                                        list.Add(k);
                                    if (g != 0)
                                        list.Add(g);
                                    if (h != 0)
                                        list.Add(h);
                                    list.Sort();
                                    string foo = "";
                                    foreach (var number in list)
                                    {
                                        if (!foo.Contains(number.ToString()))
                                            foo += number.ToString() + ", ";
                                        else
                                        {
                                            foo = "";
                                            break;
                                        }
                                    }
                                    if (!masterList.Contains(foo) && foo!="")
                                    {
                                        masterList.Add(foo);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            //int count = 1;
            foreach (var list in masterList)
            {
                Console.WriteLine(list); //+ " - " + count);
                //count++;
            }
        }
    }
}
