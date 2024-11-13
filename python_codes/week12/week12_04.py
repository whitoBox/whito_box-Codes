#12_04.py
#이거 시험에 나올꺼임 야아아아아아아아아아ㅏㅇ

def test():
    raise NotImplementedError("test() 미구현")

while True:
    try:
        dvd = int(input('분자:'))
        dvs = int(input('분모:'))
        print(dvd/dvs)
        test()
    except ValueError as ve:
        print("정수만 입력해 주세요.." + str(ve))
    except ZeroDivisionError:
        print("0으로 나눌순 없어요..")
    except Exception as e:
        print("error:" + str(e))
    finally:
        print("마무리")


