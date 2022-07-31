using System;

namespace OrderArray
{
    internal class Program
    {
        static int[] myArray = { 1, 2, 1, 3, 3, 1, 2, 1, 5, 1, 3, 5, 5, 5 };

        static void Main(string[] args)
        {
            int cant = myArray.Length - 1;
            Array.Sort(myArray);

            int mayor = myArray[cant];
            int ant = 0;

            for (int i = 0; i < mayor; i++)
            {
                int act = i + 1; 
                string ast = "";

                if (act > ant)
                {
                    foreach (int v in myArray)
                    {
                        if (v == act)
                        {
                            ast = ast + "*";
                        }
                    }
                }

                Console.WriteLine((i + 1).ToString() + ": " + ast);

                ant = myArray[i];
            }
        }
    }
}
