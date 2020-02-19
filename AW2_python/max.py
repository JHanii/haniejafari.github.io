def max(a):
    m = a[0]
    for i in a:
        if i>m:
            m = i
    return m
print(max([5, 4, 8, 9, 0]))