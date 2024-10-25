#week09.04
data2 =[[1,2,3],[10,20],[11,12,13,14]]

data3 = {"김인하" : [1,2],
         "이인하" : [10,20,30,40,50,60,70],
         "송인하" : [11,12,13,14]}

def analyze_list(datas):
    for i,j in enumerate(datas):
        print(f"{i+1}번째:",end='')
        for k,l in enumerate(j):
            print(f"[{k}]{l}",end=' ')
            
        print(f"\nsum:{sum(j)}")
        print(f"max:{max(j)}")
        print(f"min:{min(j)}")
        print(f"avr:{sum(j)/len(j)}")


def analyze_dict(datas):
    for i in datas:#try items(),try making it simipler
        print(i,":",end='')
        for j in range(len(datas[i])):#try enumerate
            print(f" [{j}]{data3[i][j]}",end='')
        print()
        print("sum",sum(datas[i]))
        print("max",max(datas[i]))
        print("min",min(datas[i]))
        print("avg",sum(datas[i])/len(datas[i]))


def analyze_score(datas):
    if isinstance(datas, list):
        pass
    elif isinstance(datas, dict):
        pass
    else:
        print("판독불가")

analyze_list(data2)
print()
analyze_dict(data3)
analyze_score(4)
