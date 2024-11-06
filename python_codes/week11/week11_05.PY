#week11_5

class In:
    def test(self):
        print("In.Func()")

class Out:
    def test(self):
        print("Out.method()")

#안되면 주석
#test() 존제하지 않음
        
#In.test() 있는데 호출이 잘못됨
#Out.test() 이놈들은 무조건 인스턴스가 있어야 작동함

i = In()
o = Out()
s = "a"

#호출발법1: (실제로는 잘 안씀) 정식표현법
In.test(i)
Out.test(o)
str.upper(s)

#호출방법2:(실 사용 호출 방법) 약식표현법
i.test()
o.test()
s.upper()


In.test(o)
Out.test(i)
