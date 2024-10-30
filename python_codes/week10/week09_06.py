#week10_06.py HELP ME. YELLO MONKEY

class Score:
    def __init__(self,k,e,m):#magic methon
        self.kor = k
        self.eng = e
        self.mat = m
    def avg(self):
        return (self.kor+self.eng+self.mat)/3#스코어에 avg라는 함수를 내가 만든 거임
    
scores3 = Score(1,2,3)
print(scores3.kor,scores3.avg())#실제 모양 scores3.avg(scores3)
scores3.kor = 100
print(scores3.kor,scores3.avg())

'''
scores1 = [10,20,30]
scores2 = {'k':10, 'm':20, 'e'30}

def average_list(datas):
    return sum(datas)/len(datas)

def average_dict(datas):
    return sum(datas.values())/len(datas)


print(average_list(scores1))
print(average_dict(scores2))
'''
