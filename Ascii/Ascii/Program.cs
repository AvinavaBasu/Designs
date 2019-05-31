using System;
using System.Collections.Generic;
using System.Linq;

namespace Ascii
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    var listOfStrings = new List<string>();
        //    var countOfTests = Convert.ToInt32(Console.ReadLine());
        //    for (int i = 0; i <= countOfTests; i++)
        //    {
        //        var toBeConverted = Console.ReadLine();
        //        listOfStrings.Add(toBeConverted);
        //    }
        //    getAscii(listOfStrings);
        //}

        //static void getAscii(List<string> s)
        //{
        //    foreach (var stringMe in s)
        //    {
        //        var split = stringMe.ToCharArray();
        //        foreach (var item in split)
        //        {
        //            Console.Write((int)item);
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //using System;
        //using System.Collections.Generic;
        //using System.IO;
        //using System.Linq;
        //class CandidateCode
        //    {
        //        static void Main(String[] args)
        //        {
        //            int i, fact = 1, number;
        //            number = int.Parse(Console.ReadLine());
        //            for (i = 1; i <= number; i++)
        //            {
        //                fact = fact * i;
        //            }
        //            Console.Write(fact);
        //        }
        //    }


        static void Main(String[] args)
        {
            var listOfStrings = new List<string>();
            for (int i = 0; i <= 2; i++)
            {
                var toBeConverted = Console.ReadLine();
                listOfStrings.Add(toBeConverted);
            }

            var split = listOfStrings[0].ToCharArray();
            var dubplicates = new List<char>();
            foreach (var item in split)
            {
                var count = split.Count(x => x == item);
                if (count>1)
                {
                    dubplicates.Add(item);
                }
            }
            var newDub = dubplicates.Distinct();

            foreach (var item in newDub)
            {
                var result = listOfStrings[1].Contains(item) ? listOfStrings[1].Replace(item,' ') : listOfStrings[1];
            }
            
        }



}
}
