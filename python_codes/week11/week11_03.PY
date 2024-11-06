#week11_3
#창문열어줘 창문열어줘 창문열어줘 창문열어줘 창문열어줘 창문열어줘
class Point:
    def __init__(self):
        self.x = float()
        self.y = float()

p = Point()

print(p.x,p.y)


class Rect:
    def  __init__(self):
        self.x = float()
        self.y = float()
        self.width = float(2)
        self.height = float(5)
    
r = Rect()
print(r.x, r.y, r.width, r.height)



class Subject:
    def __init__(self):
        self.num = str()
        self.sub = str()
        self.teach = str()
        self.score = float()

class Student:
    def __init__(self):
        self.name = str()
        self.id = str()
        self.dept = str()
        self.year = int()

class Rect2:
    def __init__(self):
        self.Point = Point() #이렇게 다른 클래스를 클래쓰에 쓸수 있다.
        self.width = float()
        self.height = float()

class Rect3:
    def __init__(self):
        self.sp = Point() 
        self.ep = Point()
r = Rect3()
print(r.sp.x, r.sp.y)
print(r.ep.x, r.ep.y)
