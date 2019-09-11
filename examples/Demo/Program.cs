﻿using Coldairarrow.Util;
using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            new IdHelperBootstrapper()
                //设置WorkerId
                .SetWorkderId(1)
                .Boot();

            Console.WriteLine($"WorkerId:{IdHelper.WorkerId},Id:{IdHelper.GetId()}");

            Console.ReadLine();
        }
    }
}
