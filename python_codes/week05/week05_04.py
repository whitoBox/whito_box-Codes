#week 05_04
score = int(input("score:"))

if score>=90:
    print("A")
elif score>=80:
    print("B")
else:#중첩 if문
    print("why you so dumb")
    if score>=70:
        print("C")
    elif score>=60:
        print("D")
    else:
        print("F")

