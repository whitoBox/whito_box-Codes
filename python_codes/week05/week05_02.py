#week 05_02

toeic = int(input("toeic:"))
age = int(input("age:"))
temp = int(input("temp:"))
height = int(input("height:"))

a = toeic>=800 and age<30
b = toeic>=800 or age<30
c = temp <10 or temp > 28

d = not (age==30) and toeic<600
#d = age!=30) and toeic<600

e = height >= 120 and height<=160
#e = 120 <= height <= 160

print(a,b,c,d,e)
