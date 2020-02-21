def max(n):
    maxi = n[0]
    for item in n:
        if item>maxi:
            maxi = item
    return maxi
print(max([8,6,9,1]))