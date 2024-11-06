#week11_4
#창문열어줘 창문열어줘 창문열어줘 창문열어줘 창문열어줘 창문열어줘

class Student:
    def __init__(self):
        self.id = str()
        self.name = str()
        self.dept = str()
        self.year = int()

students = []
for i in range(3):
    print("[" + str((i+1)) + "]")
    s = Student()
    s.id = input("학번:")
    s.name = input("이름:")
    s.dept = input("학과:")
    s.year = int(input("생년(yyyy):"))
    students.append(s)

for i in students: #type(i) => Student    
    print(i.name)

#동일한 학번이 들어오면?
#list 가 아닌Dick 로 구성하기
#
#

