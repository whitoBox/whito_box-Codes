#week10_03.py 개더워어어어어어어어어어어어어어어어어어어

myFile = "d:\\202444029A\\JohnKim_02.txt"

f = open(myFile, 'r')

#type1
'''
d = f.read()
print(d)
'''
#type2
'''
while True:
    d = f.readline()
    if not d:
        break
    print(d.strip())
'''
#type3
d = f.readlines() #줄단위로 리스트를 만듦
for line in d:
    print(line.strip())


f.close()
