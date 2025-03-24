def dups(city):
    result = []
    a = set()

    for v in city:
        l1 = len(a)
        a.add(v)
        l2 = len(a)
        if l1 == l2: #증복 값이 들어옹
            result.append(v)
    return result
city = ['a','a','b','asf']
#city = set(city)
print(city)
print(dups(city))