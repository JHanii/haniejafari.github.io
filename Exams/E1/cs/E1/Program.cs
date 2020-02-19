using System;

namespace E1
{
    class Program
    {
		
        class Student
        {
            double sum = 0;
            double []fs;
            int i = 0;
            public void Grades(double []Gr, int []We)
            {
                foreach (double item in Gr)
                {
                    int d = We[i];
                    sum += d* item;
                    i++;
                }

            }
            public double avg()
            {
                double av = sum/(i-1);
                return av;
            }
        }
        static void Main(string[] args)
        {
            
            var S = new Student();
			S.Grades(new double {11,18,20,14} , new int {3,2,3,4});
            double q = S.avg();
            Console.WriteLine(q);
        }
    }
}

