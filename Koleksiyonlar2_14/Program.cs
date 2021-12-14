using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyonlar2_14
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            //list.Add("Ayse");
            //list.Add(2);
            //list.Add(true);
            //list.Add('A');
            
            //Console.WriteLine(list[1]);

            //foreach (var item in list)
              //  Console.WriteLine(item);
            
            //AddRange
            Console.WriteLine("****** ADD RANGE *****");
            //string[] renkler = {"kirmizi", "sari", "yesil"};
            List<int> sayilar = new List<int>() {1, 8, 3, 7, 9, 92, 5};
            //list.AddRange(renkler);
            list.AddRange(sayilar);

            foreach (var item in list)
                Console.WriteLine(item);
            
            list.Sort();
            foreach (var item in list)
                Console.WriteLine(item);
            
            Console.WriteLine(list.BinarySearch(9));
            
            list.Reverse();
            
            foreach (var item in list)
                Console.WriteLine(item);
            
            list.Clear();
            
            foreach (var item in list)
                Console.WriteLine(item);
        }
    }
}