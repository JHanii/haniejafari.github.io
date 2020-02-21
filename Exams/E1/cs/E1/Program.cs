using System;

namespace E1
{
    class Program
    {
		
        class Student
        {
            long sum = 0;
            int i = 0;
            public void Grades(int []Gr, int []We)
            {
                foreach (int item in Gr)
                {
                    sum += We[i]* item;
                    i+=We[i];
                }

            }
            public double avg()
            {
                double av = sum/i;
                return av;
            }
        }
        static void Main(string[] args)
        {
            
            var S = new Student();
			S.Grades(new int[] {11,18,20,14} , new int[] {3,2,3,4});
            double q = S.avg();
            Console.WriteLine(q);
        }
    }
}

