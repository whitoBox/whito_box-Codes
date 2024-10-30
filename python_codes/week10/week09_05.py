#week10_05.py MAMAAAAAAAAAAAAAA JUST KILLED A MAN. 
import os

myPath = "d:\\202444029A"
myFile = "JohnKim_02.txt"

if False == os.path.exists(myPath):
    os.mkdir(myPath)#운영체제에서os 디렉토리를 만든다

myFullFile = myPath +"\\" +myFile

if os.path.exists(myFullFile):
    with open(myFullFile, 'r')as f:
        lines = f.readlines()

        score_list = []
        for line in lines:
            sub_score_list = line.strip().split('|')
            dict_scores = {}

            for sub_score in sub_score_list:
                score = sub_score.split(',') 
                dict_scores[score[0]] = int(score[1])
            
            if dict_scores:
                score_list.append(dict_scores)
    print(score_list)


