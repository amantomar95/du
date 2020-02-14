using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_reverse
{

    // Iterative C# program to reverse an 
    // array 


    class GFG
    {

        /* Function to reverse arr[] from 
        start to end*/
        /*static void rvereseArray(int []arr,int start, int end) 
        { 
            int temp; 
		
            while (start < end) 
            { 
                temp = arr[start]; 
                arr[start] = arr[end]; 
                arr[end] = temp; 
                start++; 
                end--; 
            } 
        }	 
	
         Utility that prints out an array on a line 
        static void printArray(int []arr, 
                                int size) 
        { 
            for (int i = 0; i < size; i++) 
                Console.Write(arr[i] + " "); 
		
            Console.WriteLine(); 
        } 
	
        // Driver function 
        public static void Main() 
        { 
            int []arr = {M,A,N,I,S,H}; 
            printArray(arr, 6); 
            rvereseArray(arr, 0, 5); 
            Console.Write("Reversed array is \n"); 
            printArray(arr, 6);
            Console.ReadLine();
        } 
      } 

    // This code is contributed by Sam007 

    //***************************************************************************************************************************************************
    
     }
      */


        /*  namespace StringReverse
               {
                 class Program
                   {
                     public static List<string> StrReverse(string str)
                      {
                         var input = new List<char>(str);
                         var strRev = new List<string>();
                         var j = 0;
                         for(var i = input.Count-1;i >= 0; i--)
                             {
                                var jh = input[i];
                                strRev.Add(input[i].ToString());
                                 j++;
                              }
                                 return strRev;
                        }
                              static void Main(string[] args)
                                   {
                                      Console.WriteLine("Please Enter a string");
                                      string input = Console.ReadLine();
                                       Console.Write("Reversed String is : ");
                                       foreach (var item in StrReverse(input))
                                        {
                                           Console.Write(item);
                                         }
                                      Console.WriteLine();
                                      Console.ReadLine();
                                
                        }
                    }
         */
        //***************************************************************************************************************************
        static class StringHelper
        {
            public static string ReverseString(string myStr)
            {
                char[] myArr = myStr.ToCharArray();
                Array.Reverse(myArr);
                return new string(myArr);
            }
        }

        class myProgram
        {
            static void Main()
            {
                Console.WriteLine(StringHelper.ReverseString("Manish"));
                Console.WriteLine(StringHelper.ReverseString("Suraj"));
                
                Console.ReadLine();
            }
        }
        //****************************************************************************************************************************
    }
}
 