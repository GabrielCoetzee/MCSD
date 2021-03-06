﻿using System;

namespace Chapter2
{
    class Types2
    {
        [Flags]
        enum Days
        {
            None = 0x0,
            Sunday = 0x1,
            Monday = 0x2,
            Tuesday = 0x4,
            Wednesday = 0x8,
            Thursday = 0x10,
            Friday = 0x20,
            Saturday = 0x40
        }

        Days readingDays = Days.Monday | Days.Saturday;

        public static void Run()
        {
            var str = (Days.Monday | Days.Wednesday).ToString();
            Console.WriteLine(str);
        }
    }
}
// output
// Monday, Wednesday