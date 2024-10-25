#5번 문제 >:(
print("+++구구단 프로그램+++")

while(1):
    nu = input("\n구구단-단수(1~9):")
    if(nu.title()=='Q'):
        break;
    if(int(nu)>9 or int(nu)<2):
        print("입력한 '단'이 범위를 벗어납니다.")
        continue;
    for i in range(1,10):
        print(f"{i} * {nu} = {i*int(nu)}")
print("[종료]")
        
