import array

array = array.array('f', [11,9, -77, 8])
for i in range(len(array)):
    print(f"{array[i]:6} {id(i)}")