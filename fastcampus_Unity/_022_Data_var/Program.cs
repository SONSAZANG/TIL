﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_Data_var
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 100;
            var b = 3.1231231231234124123f;
            var c = 3.123123123123123123123123123m;
            var d = 'H';
            var e = 'i';
            var f = "World!";
            var g = false;

            Console.WriteLine("type: {0}, a: {1}", a.GetType(), a);
            Console.WriteLine("type: {0}, b: {1}", b.GetType(), b);
            Console.WriteLine("type: {0}, c: {1}", c.GetType(), c);
            Console.WriteLine("type: {0}, g: {1}", g.GetType(), g);

            Console.WriteLine("{0}{1} {2}", d, e, f);

            // 불가: 반드시 선언과 동시에 초기화
            // var noInitialVar;

            var num = 0;
            num = 100;

            Console.WriteLine("num: " + num);
        }
    }
}
