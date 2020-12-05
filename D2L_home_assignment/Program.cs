using System;
using System.Collections.Generic;

namespace D2L_home_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>();
            list1.Add("Allison");
            list1.Add("Bob");
            list1.Add("Zack");
            list1.Add("Ashish");
            list1.Add("karishma");

            List<string> list2 = new List<string>();
            list2.Add("Allison");
            list2.Add("Ashish");
            list2.Add("Harry");
            list2.Add("Johnson");
            list2.Add("Zack");
            list2.Add("Ankit");

            uniqueList(list1, list2);
            
            
            Console.ReadLine();
        }

        
        public static void uniqueList(List<string> list1, List<string> list2)
        {
            //adding Both lists
            list1.AddRange(list2);

            //Sorting List alphabetically.
             bubbleSort(list1);

            //search element using binary search agorithm
            for (int i = 0; i < list1.Count; i++)
            {

                int elementIndex = binarySearch(list1, i, list1[i]);
                //Duplicate element found
                if (elementIndex != -1)
                {
                    list1.RemoveAt(elementIndex);
                }
            }
            foreach (string element in list1)
            {
                Console.WriteLine(element);
            }

            
            
        }

        public static int binarySearch(List<string> list, int leftIndex, String element)
        {
            int middleIndex = 0;
            int rightIndex = list.Count - 1;
            while(leftIndex < rightIndex)
            {
                

                //Getting middle Index;
                if((leftIndex + rightIndex) % 2 == 0)
                {
                    middleIndex =  (leftIndex + rightIndex) / 2;
                }
                else
                {
                    middleIndex = 1 + (leftIndex + rightIndex) / 2;

                }

                int result = element.CompareTo(list[middleIndex]);

                //Check if element is present at middle Index;
                if(result == 0)
                {
                    return middleIndex; 
                }

                //if result is greater than 0;
                //ignore the left part;
                //make left index next to middle index;
                if(result > 0)
                {
                    leftIndex = middleIndex + 1;
                }


                //if result is less than 0;
                //ignore the right part;
                //make right index previous to middle index;
                if (result < 0)
                {
                    rightIndex = middleIndex - 1;
                }



            }
            //if no element found
            return -1;
        }
        

        public static void bubbleSort(List<string> list)
        {
            string temp;
            for(int i = 0; i < list.Count - 1; i++)
            {
                for(int j = i + 1; j < list.Count; j++)
                {
                    
                    if(list[i].CompareTo(list[j]) > 0){
                        //swap the element
                        temp = list[j];
                        list[j] = list[i];
                        list[i] = temp;
                    }
                }
            }
        }

        
    }
}
