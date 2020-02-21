#include <iostream>
using namespace std;
class Student
    {
        public :
        int sum=0;
        int G[100];
        int W[100];
        void grades(int i,int q)
        {
            G[i] = q;
        }
        void weights(int i,int d)
        {
            W[i] = d;
        }
        int Avg(int sizee, int a)
        {
            for(int i=0; i<sizee; i++)
            {
                sum += G[i]*W[i];
            }
            return sum/a;
        }
    };
int main()
{
    int a=0;
    int k=0;
    Student st;
    int b;
    while(cin.get() != '\n')
    {
        cin >> b;
        st.grades(k,b);
        k++;
    }
    int i=0;
    int c;
    while(cin.get() != '\n')
    {
        cin >> c;
        a += c;
        st.weights(i,c);
        i++;
    }
    cout << st.Avg(k,a);
    return 0;
}
