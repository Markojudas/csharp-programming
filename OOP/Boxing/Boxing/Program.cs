using System;
using System.Collections;
using System.Collections.Generic;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1); //boxing happens since int is a primative type
            list.Add("Mosh"); //string is a class so boxing does not happen
            list.Add(DateTime.Today); //boxing happens

            //better to use generic list
            var anotherList = new List<int>();
            var names = new List<string>();

            names.Add("requires a string");
            anotherList.Add(2);
            
        }
    }
}
