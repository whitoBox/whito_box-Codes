import random

class credit_card:
    def __init__(self, name, limit):
        self.name = name
        self.limit = limit

    def use_card(self,amount):
        if self.limit - amount < 0:
            print("한도초과")
        else:
            self.limit = self.limit - amount
            print("잔액:",self.limit)

def gen_limit():
    limit = random.randint(1,10) * 500000
    return limit


card_datas = []
while True:
    print("make card 1")
    print("use card 2")
    choice = int(input(":").strip())

    if choice == 1:
        name = input("card name:")
        limit = gen_limit()
        print("your card limit is:",limit,"won")
        card_datas.append(credit_card(name,limit))
    
