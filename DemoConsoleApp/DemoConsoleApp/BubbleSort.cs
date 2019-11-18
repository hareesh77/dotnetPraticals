using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsoleApp
{
   
    class BubbleSortClass
    {
        public string[] BubbleSortArray = { };        
        public BubbleSortClass(String[] obj)
        {
            BubbleSortArray = obj;
        }
        public static bool CompareValues(String Value1, String Value2, String SortType)
        {
            bool output= false;
            if(SortType == "Ascending" || SortType=="Descending")
            {
                if(SortType == "Ascending")
                {
                    if (String.Compare(Value1, Value2) == 1)
                        output = true;
                }
                else
                {
                    if (String.Compare(Value1, Value2) == -1)
                        output = true;
                }
            }
            else
            {
                throw new Exception("SortOrder not Correct");
            }
            return output;
        }

        public void SwapValues(int position1, int position2)
        {
            String SwapVariable;
            SwapVariable = BubbleSortArray[position1];
            BubbleSortArray[position1] = BubbleSortArray[position2];
            BubbleSortArray[position2] = SwapVariable;

        }
    }
}
