#04_06

price = [2000,3000,3500]
name = ['아메리카노','카페라떼','카푸치노']
amount = []
sales =0
i = 0
while i < len(price):
    print(f"{name[i]}({price[i]}원)")
    num = input("잔:").strip()
    if num:
        amount.append(int(num))
    else:
        amount.append(0)

    sales += amount[i] * price[i]
    i+=1

print(f"\n총 매출액: {sales}원")
