age =21
name ="정석"
a= "이름:%s 나이:%d" % (name, age)
print(a)

"""
a= "이름:{0} 나이:{1}" .format(name, age)
print(a)
"""

number = 3
day = "삼일"
c = "나는{0}개의 사과를 먹고{1}동안 아팠어요".format(number,day)
print(c)

intro = "내 이름은 {name}입니다. 나이는 {age}살 입니다."
print(intro)
intro = f"내 이름은 {name}입니다. 나이는 {age}살 입니다."
print(intro)
intro = f"내 이름은 {name}입니다. 나이는 {age+1}살 입니다."
print(intro)
