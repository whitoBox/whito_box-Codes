people = {}
while(1):
    do = int(input("""
===============
[1]추가
[2]검색
[0]종료
===============
선택:"""))
    if(do == 0):#종료
        break
    if(do == 1):#추가
        print("추가 기능 수행")
        while(1):
            name = input("이름:")
            if(not bool(name)):
                break
            number = input("연락처:")
            people[name] = number
        print("=====연락처목록=====")
        for i in people.items():
            print(f"{i[0]} : {i[1]}")

    if(do == 2):#검색
        print("검색 기능 수행")
        name = input("이름:")
        if(people.get(name) == None):
            print("해당 이름의 연락처를 찾을 수없습니다.")
        else:
            print(f"{name}의 연락처:{people.get(name)}")
print("프로그램을 종료합니다.")
