using System;
using System.Collections;
using System.Collections.Generic;

namespace PatikaArrayList;

class Solution
{
    static void Main(string[] args)
    {
        //System.Collections
        ArrayList list = new ArrayList();
        list.Add("Ayşe");
        list.Add(7);
        list.Add(true);
        list.Add('C');
        
        System.Console.WriteLine(list[1]);

        System.Console.WriteLine("************** Add Range **************");
        string[] colors = {"yellow","blue","black","green"};
        List<int> numbers = new List<int>(){23,4,7,8,115};
        list.AddRange(colors);
        list.AddRange(numbers);

        System.Console.WriteLine("************** Sort **************");
        //list.Sort();

        foreach(var item in list)
        {
            System.Console.WriteLine(item);
        }

        //Binary  Search
        System.Console.WriteLine("************** Binary Search **************");
        list.BinarySearch(8);
    }
}
