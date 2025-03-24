def mv_zeros(a_list):
    zindex = 0
    for index, n in enumerate(a_list):
        if n != 0:
            a_list[zindex] = n
            if zindex != index:
                a_list[index] = 0
            zindex += 1
    return (a_list)

lst = [8, 0, 3, 0, 12]
mv_zeros(lst)
print(lst)=====