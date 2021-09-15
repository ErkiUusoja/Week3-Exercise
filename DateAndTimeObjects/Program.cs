using System;

namespace DateAndTimeObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime current = DateTime.Now;
            /* Console.WriteLine(current.Hour);
             Console.WriteLine(current.Minute);
             Console.WriteLine(current.Second);
             Console.WriteLine(current.Millisecond);*/
            Console.WriteLine(current.ToString("dddd dd MMMM"));
            Console.WriteLine(current.ToString());
            
                
        }
    }
}
