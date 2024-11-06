#week11_7
class Point:
    def __init__(self,x=0.0,y=0.0):
        self.x = x
        self.y = y

    def __str__(self):#무조건 문자열로 반환해야 함
         #기본이 타입(클래스), 인스턴트의 위치)
        #클래스 선언하면 그냥 기본적으로 존제하는 것 
        return f"({self.x}, {self.y})"
    
p = Point()
p.x = 10.1
p.y = 20.2
print(p.x,p.y)
print(p)
print(1)
print(10.1)

p = Point(10.1, 20.2)





class Rect:
    def  __init__(self,x=0.0,y=0.0,w=0.0,h=0.0):
        self.x = x
        self.y = y
        self.width = w
        self.height = h
    
r = Rect()
print(r.x, r.y, r.width, r.height)


#코딩은 이렇게 해라 **
class Subject:
    def __init__(self,num,sub,teach=None):
        self.num = num
        self.sub = sub
        self.teach = teach
        self.score = None

class Student:
    def __init__(self,name,id,dept,year):
        self.name = name
        self.id = id
        self.dept = dept
        self.year = year
        #매개변수 4개 필요,필수

class Rect2:
    def __init__(self, w, h, P=Point()):
        self.P = P #이렇게 다른 클래스를 클래쓰에 쓸수 있다.
        self.w = w
        self.h = h

class Rect3:
    def __init__(self,sp=Point(), ep=Point()):
        self.sp = sp
        self.ep = ep
        
r = Rect3()
print(r.sp.x, r.sp.y)
print(r.ep.x, r.ep.y)


