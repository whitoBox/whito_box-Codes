print("*"*30,
      "[1]팝콘 - 5000원",
      "[2]나쵸 - 4000원",
      "[3]핫도그 - 3500원",
      "[4]음료 - 2000원",
      "주문을 끝내려면 [0]을 입력하세요","*"*30,sep="\n")
menus = [5000,4000,3500,2000]
total = 0
while(1):
    menu = input("메뉴:")
    if(not menu.isdecimal() or int(menu)<0 or int(menu)>4):
        print("메뉴선택을 다시 하세요\n")
        continue
    if(int(menu)==0):
        break
    many = int(input("수량:"))
    print()
    total += menus[int(menu)-1]*many
print(f"{"="*30} \n금액의 합계는 {total}입니다.")
