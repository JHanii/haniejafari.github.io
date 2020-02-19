using System;

namespace cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.Readline(s);
            var []list = var.pars(s);
            reverse([]list);
            static void reverse(var [] list)
            {
                for(int i=0, j=list.length -1; i<list.length/2; i++ , j--)
                {
                    var temp = list[i];
                    list[i] = list[j];
                    list[j] = list[i];
                }
            }
            static void Print()
            {
                for (int i=0; i<list.length; i++)   System.Console.Writeline(list[i]);
            }
            System.Console.ReadKey();
        }
    }
    
}
