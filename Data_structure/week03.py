def return_int(list1,list2):
    #list3 = [v for v in list1 if v in list2]
    list3 = []
    for v in list1:
        if v in list2:
            list3.append(v)
    return list3

list1 = [2,43,48,62,64,28,3]
list2 = [1,28,42,70,2,10,62,31,4,14]

print(return_int(list1,list2))