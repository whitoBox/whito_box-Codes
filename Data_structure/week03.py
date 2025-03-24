def return_int(list1,list2):
    s1 = set(list1)
    s2 = set(list2)
    #list3 = list(s1.intersection(s2)) #intersection는 set에서 교집합을 구해주는 매소드
    list3 = s1 & s2
    return list3

list1 = [2,43,48,62,64,28,3]
list2 = [1,28,42,70,2,10,62,31,4,14]

print(return_int(list1,list2))