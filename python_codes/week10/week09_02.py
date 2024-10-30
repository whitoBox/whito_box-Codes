#week10_02.py 개더워어어어어어어어어어어어어어어어어어어

myFile = "d:\\202444029A\\JohnKim_02.txt"
scores = {}

f = open(myFile,'a')

while True:
    scores['k'] = int(input("kor:"))
    scores['m'] = int(input("mat:"))
    scores['e'] = int(input("eng:"))

    data = ""
    for k,v in scores.items():
        if data:
            data += '|'
        data += f"{k},{v}"
    f.write(f"{data}\n")
    if "y" ==input("종료(y)").strip().lower():
        break
    
f.close()

"""
myFile = "d:\\202444029A\\JohnKim_01.txt"
scores = {}

f = open(myFile,'a')

while True:
    scores['k'] = int(input("kor:"))
    scores['m'] = int(input("mat:"))
    scores['e'] = int(input("eng:"))

    for k,v in scores.items():
        f.write(f"{k},{v}\n")
    if "y" ==input("종료(y)").strip().lower():
        break
    
f.close()
"""


"""
myFile = "d:\\202444029A\\JohnKim_01.txt"

scores = {'k':10, 'm':100, 'e':50}

f = open(myFile,'a')

for k,v in scores.items():
    f.write(f"{k},{v}\n")

f.close()
"""
