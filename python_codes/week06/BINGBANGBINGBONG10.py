people = {}
while(1):
    name = input("이름:")
    if(not bool(name)):
        break
    number = input("연락처:")
    people[name] = number
print("=====연락처목록=====")
for i in people.items():
    print(f"{i[0]} : {i[1]}")
