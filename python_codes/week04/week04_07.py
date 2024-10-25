#04_07

t1 = ()
t2 = tuple()
t3 = (1)
t4 = (1,)
t5 = (1,2,3)
t6 = 1,2,3
t7 = (1,2,3,(4,5))

print(t1,type(t1))
print(t2,type(t2))
print(t3,type(t3))
print(t4,type(t4))
print(t5,type(t5))
print(t6,type(t6))
print(t7,type(t7))

print(t7[-1][1])
