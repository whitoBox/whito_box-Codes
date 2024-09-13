"""
print(len("a"))
print("aba".count("a"))
#print("a".len()) #특정 자료형 안에만 있는 메소드
#print(count("a"))
#print((1).count('1'))

print("123".index('1'))
print([1,2.5,3].index(3)) #"."은 ~의 것 이라고 해석 해면 됨
"""

test = "I am a BOY."

print(test.count("a"))
print(test.count("A"))

print(test.find("a"))
print(test.find("q"))
print(test.find("am"))
print(test.find("qm"))

print(test.index("a"))
#print(test.index("q"))
print(test.index("am"))
if "qm" in test:
    print(test.index("qm"))
else:
    print("x")

print(test.upper())
print(test.lower())
print(test.title())
print(test.capitalize())
print("/".join(test)) #시험에 나옴

test2 = "  JMT University  "
print("|" + test2.strip() + "|")#공백 제거
print("|" + test2.lstrip() + "|")
print("|" + test2.rstrip() + "|")

print(test2.replace("University","High School"))#원래 문자열은 바뀌지 않음
print(test2)

print(test2.split())#문자열 조각조각내어 버림 
print(test2.split("i"))#스플릿은 리스트가 반
