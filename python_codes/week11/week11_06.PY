#week11_6

class Human:
    def __init__(self):
        self.name ="김김김"
        self.age = 20
        
    def func(self, name, age):
        self.name = name
        print(age)

h = Human()
print(h.name)
print(h.age)


h = Human()
h.func("김미영",20)
print(h.name)
print(h.age)
