#include <iostream>
using namespace std;
int main()
{
    int a[1000];
    int i=0;
    while(cin.get()!= '\n')
    {
        cin >> a[i];
        i++;
    }
    for (int j=0, k=i-1; j<i/2; j++,k--)
    {
        int temp = a[j];
        a[j] = a[k];
        a[k] = temp;
    }
    for(int j=0; j<i; j++)  cout << a[j] << " ";
    return 0;
}
