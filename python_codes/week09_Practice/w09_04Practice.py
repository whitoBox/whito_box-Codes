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
        print()
        print_data(j)


def analyze_dict(datas):
    for k,v in datas.items():
        print(k,":",end='')
        for k1,v1 in enumerate(v):
            print(f" [{k1}]{v1}",end='')
        print()
        print_data(v)


def print_data(datas):
    print("sum",sum(datas))
    print("max",max(datas))
    print("min",min(datas))
    print("avg",sum(datas)/len(datas))

def analyze_score(datas):
    if isinstance(datas, list):
        analyze_list(datas)
    elif isinstance(datas, dict):
        analyze_dict(datas)
    else:
        print("판독불가")


analyze_score(data2)
print("########################")
analyze_score(data3)
