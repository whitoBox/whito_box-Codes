shape = int(input("도형 선택(1: 사각, 2:삼각, 3:원):"))
if shape == 1:
    sqSize = int(input("가로 입력:"))
    sqSize *= int(input("세로 입력:"))
    print("도형의 넓이 :",sqSize,end="")
elif shape == 2:
    triSize = int(input("밑변 입력 :"))
    triSize = triSize * int(input("높이 입력 :")) / 2
    print("도형의 넓이 :",triSize,end="")
elif shape == 3:
    cirSize = int(input("반지름 입력 :"))
    print("도형의 넓이 :",cirSize*cirSize*3.14,end="")
else:
    print("잘못된 입력")
