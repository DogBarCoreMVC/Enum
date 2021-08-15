using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Month thisMonth = Month.August;

            int showIndexThisMonth = (int)thisMonth;

            Console.WriteLine(showIndexThisMonth + "\n");//แสดงผลออกมาเป็นตัวเลขของเดือน August

            Console.WriteLine((int)Month.Decenber + "\n");//แสดงผลออกมาเป็นตัวเลขของเดือน

            Month strThisMonth = (Month)2;

            Console.WriteLine(strThisMonth + "\n");
        }
    }
}
