// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{ 
    static void Main()
    {
        Console.WriteLine("enter some characters");
        string characters = (Console.ReadLine());

        List<char> list = new List<char>(characters);
        Console.WriteLine($"Your input is:{string.Join(' ',list)}");
        // h e l l o p e 

       
        for(int i = 0;i < list.Count;i++)
        {
            int freqCount = 1;
            int k = 0;
            bool alreadyCounted = false;
            while (k < i)
            {
                if (list[i] == list[k])
                {
                    alreadyCounted = true;
                    break;
                }
                    
            k++;
            }
          if(alreadyCounted == false)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        freqCount++;
                    }

                }
                Console.WriteLine($"Frequency count of {list[i]} is {freqCount}");
            }
                     
            
        }
        Console.ReadLine();
    }

}
