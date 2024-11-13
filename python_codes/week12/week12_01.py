#12_01.py

class Subject: #Subject() => __new__() => __init__()
    def setGrade(self, grade):
        if grade != None and (grade < 0 or grade > 4.2):
            grade = None
        self.grade = grade
        
    def __init__(self, number, name, teacher='', grade=None):
        self.number = number
        self.name = name
        self.teacher = teacher
        self.setGrade(grade)
    
    def __str__(self): #무조건 문자열 리턴 :)
        return f"[{self.number},{self.name}]"

sub = Subject("CS0001","컴퓨터개론",grade=4.9)
#sub.grade = 4.9
sub.setGrade(4.9)
print(sub.grade)

sub = Subject("CS0001","컴퓨터개론",grade=4.9)
print(sub.grade)

sub = Subject("CS0001","컴퓨터개론")
print(sub)
print(sub.grade)

class Student:
    def totalScore(self,*subjects):
        if self.subjects:
            score = [sub.grade for sub in self.subjects if sub.grade!= None]
            if score:
                return sum(score) / len(score)
    
    def __init__(self, number, name, dept, birthyear, *subjects): 
         self.number = number
         self.name = name
         self.dept = dept
         self.birthyear = birthyear
         if subjects:
             self.subjects = list(subjects)
         else:
            self.subjects = []

    def __str__(self): 
        return f"[{self.number},{self.name}]"

s = Student("1",'john', 'computerinfo',2024)
print(s.totalScore())

s = Student("2",'kohn', 'computerinfo',2024
            ,Subject('cs0001', '파이썬')
            )
print(s.totalScore())

s = Student("3",'gohn', 'computerinfo',2024
            ,Subject('cs0001', '파이썬',grade = 4.0)
            ,Subject('cs0001', '자바스크립트',grade = 3.0)
            )
print(s.totalScore())





    
