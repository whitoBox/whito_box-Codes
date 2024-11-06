#week11_2
#클래스 안에 만들면 method

class Human: 
    def __init__(self): #매개변수 , parameter,local var
        name = "김요한" #local
        self.name = "김인하" #attr, member/instance vala 
        self.age = 20
        
h = Human()
print(h.name)

h2 = Human()
print(h2.name)
# -여기를 지점으로 Human 인스턴스는 생성자의 갯수(2) 2개만 있다.
'''
1단게 human() 생성자 호출
2단계 __new__() 메소드 자동 호출
      Human 인스턴스 생성
3단계 __init__() 메소드 자동 호출
      2단계에서 만든 인스턴스를 전달해줌.
4단계 해당 인스턴스의 참조를 반환.
'''



h.name = "박인하"
h2.name = "최인하"

print(id(h), id(h2))
print(type(h) == type(h2))
print(h.name == h2.name)
print(h.age == h2.age)
