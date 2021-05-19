arr = [4,3,1,2]
arr[0], arr[arr[0]-1]=arr[arr[0]-1],arr[0]
print(arr[arr[0]-1])
print(arr)


def sum(x):
    res = 0

    for i in range(x):
        
        res += i
    return res


        
print(sum(4))


a = 7
b = 7
while False:
    a = 3
    b = 4
print(b-a)   



def n(x):
    for i in range(5,x):
        print(i + 2)
        return
n(10)        