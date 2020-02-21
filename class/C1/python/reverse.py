def reverse(a):
    d = a.size
    for i in range(0,d/2):
        temp = a[i]
        a[i] = a[d-1-i]
        a[d-1-i] = temp
if __name__ == "__main__":
    a = [1,6,3,7]
    reverse(a)
    for i in a:
        print(a," "),