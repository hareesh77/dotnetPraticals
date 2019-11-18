using System;

namespace DemoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] BubbleSort = new string[10];
            Console.WriteLine("Enter a Value and press Enter, To stop enter stop...");
            string input;int inputIndex = 0;
            do
            {

                input = Console.ReadLine();
                if (input != "stop" && inputIndex < 10)
                {
                    BubbleSort[inputIndex] = input;
                    inputIndex++;
                }
                
            } while (input != "stop" && inputIndex<10);
            String SortType = "Descending";
            for (int k = 0; k < BubbleSort.Length; k++)
                Console.Write(BubbleSort[k] + " ");
            Console.WriteLine("");
            for (int i = 0; i < BubbleSort.Length; i++)
            {
                for (int j = i + 1; j < BubbleSort.Length; j++)
                {
                    if (BubbleSortClass.CompareValues(BubbleSort[i], BubbleSort[j], SortType))
                    {
                        BubbleSortClass obj = new BubbleSortClass(BubbleSort);
                        obj.SwapValues(i, j);
                        BubbleSort = obj.BubbleSortArray;
                    }
                    for (int k = 0; k < BubbleSort.Length; k++)
                        Console.Write(BubbleSort[k] + " ");
                    Console.WriteLine("");
                }
            }

        }
        //Human Uday = new Human("Uday", new DateTime(1995,7,16));
        //Human Basha = new Human(new DateTime(1997,9,29));

    }
}