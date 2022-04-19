using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 8, 49, 17, 5 }; //Verilmis array
            int theLargest = arr[0]; //ilk elementi en boyuk olaraq qebul et!
            for (int i = 0; i < arr.Length; i++) //for dongusun qur
            {
                if (arr[i]>theLargest)        
                {
                    theLargest = arr[i];
                }
            }
            Console.WriteLine(theLargest);
               
            
          
           
        }
    }
}
