mouth = int(input("인원:"))
pizza = int(input("피자 수량 (판):"))
pizza *= int(input("피자 조각 (판당):"))
print(f"결과: 인당 {pizza//mouth}조각, 남은 조각 {pizza%mouth}조각")
