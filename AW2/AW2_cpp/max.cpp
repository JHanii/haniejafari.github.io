#include <iostream>
using namespace std;
int main()
{
    int a[100*100];
    cin >> a[0];
    int m = a[0];
    int i=1;
    while(cin.get()!='\n')
    {
        cin >> a[i];
        if(a[i] > m)   m = a[i];
    }
    cout << m << endl;
    return 0;
}
