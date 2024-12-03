from user import user1 as User
import os

def usernames(names):
    data = []
    for name in names:
        data.append(name.id)
    return data

def newuser(usernames): 
    print("[회원 정보 등록]")
    userid = input("아이디:").strip()
    if userid in usernames:
        print("동일한 아이디가 있습니다.")
        return
    
    sex = input("성별 (M:남자 F:여자):").strip().upper()
    if not (sex == "M" or sex == "F"):
        print("입력이 잘못되었습니다")
        return
    try:
        height = float(input("신장(m):").strip())
        if height > 10:
            print("신장 입력이 잘못되었습니다.")
    except:
        print("신장입력이 잘못되었습니다.")
        return
    
    try:
        weight = int(input("체중(kg):").strip())
    except:
        print("체중 입력이 잘못되었습니다.")
        return
    
    user = User(userid,sex,height,weight)
    print(f"입력한 정보를 바탕으로 계산한 BMI 수치: {user.bmi():.2f}")
    
    users.append(user)

def edituser():
    if len(users) == 0:
        print("수정할 회원이 없습니다.")
        return
    
    print("[회원 정보 수정]")
    find_user = input("아이디:").strip()

    edit_user = 0
    for i,user in enumerate(users):
        if user.id == find_user:
            edit_user = user
            index = i

    if edit_user:
        print(f"현재 신장 : {edit_user.height}")
        try:
            height = float(input("수정 신장(m):").strip())
            edit_user.height = height
        except:
            print("입력이 잘못되었습니다.")
            return
        print(f"현재 체중 : {edit_user.weight}")
        try:
            weight = int(input("체중(kg):").strip())
            edit_user.weight = weight
        except:
            print("체중 입력이 잘못되었습니다.")
            return
        print(f"입력한 정보를 바탕으로 계산한 BMI 수치: {edit_user.bmi():.2f}")
        users[index].height = edit_user.height
        users[index].weight = edit_user.weight
    else:
        print("회원정보가 없습니다.")
    
def viewall():
    if len(users) == 0:
        print("상태를 보여줄 회원이 없습니다.")
        return
    print("[전체 상태 조회]")

    muser = []
    fuser = []
    for user in users:
        if user.sex == 'M':
            muser.append(user)
        else:
            fuser.append(user)
            
    print('='*30)
    print("[남성]")
    for i,user in enumerate(muser):
        print(f"[{i+1}] 아이디:{user.id} 신장: {user.height} 체중: {user.weight}"
              f"BMI: {user.bmi():.2f}")
        print("도표:",end="")
        print("*"*int(user.bmi()))
        print()
    print()
    print("[여성]")
    for i,user in enumerate(fuser):
        print(f"[{i+1}] 아이디:{user.id} 신장: {user.height} 체중: {user.weight}"
              f"BMI: {user.bmi():.2f}")
        print("도표:",end="")
        print("*"*int(user.bmi()))
        print()
    print('='*30)
    print(f"총 {len(users)}의 정보입니다") 
    

def file():
    mydir = "c://202444029"
    if not os.path.exists(mydir):
        os.mkdir(mydir)
        
    fullfile = os.path.join(mydir,"bmilist.txt")
    return fullfile
    
def end():
    if len(users) == 0:
        print("저장할 정보가 없습니다.")
        return 
    
    fullfile = file()
    with open(fullfile, 'w') as f:
        for user in users:
            f.write(user.save()+"\n")
    print(f"{len(users)}건의 데이터를 저장했습니다.")

def recover():    
    fullfile = file()
    if not os.path.exists(fullfile):
        print("복원할 데이터가 없습니다.")
        
    if os.path.exists(fullfile):
        if len(users) > 0:
            print("기존 자료와의 충돌이 발생할 수 있으므로 복원할 수 없습니다.")
            return

    length = 0
    with open(fullfile, 'r') as f:
        for line in f:
            RL = line.split("/")
            height = RL[2].strip()
            weight = RL[3].strip()
            user = User(RL[0],RL[1],float(height),int(weight))            
            users.append(user)
            length = length + 1
    print(f"{length}건의 데이터를 복원했습니다")
    
users = []
while True:
    print("#"*30)
    print("A. 기존자료복원")
    print("B. 회원등록")
    print("C. 정보수정")
    print("D. 전체조회")
    print("Q. 종료 빛 회원정보 저장")
    print("#"*30)
    choice = input(">").strip().upper()

    if choice == 'A':
        recover()
    elif choice == 'B':
        newuser(usernames(users))
    elif choice == 'C':
        edituser()
    elif choice == 'D':
        viewall()
    elif choice == 'Q':
        end()
        break
    
print("프로그램을 종료합니다.")
