scores = [[49, 80, 20, 100, 80],
           [43, 60, 85, 30, 90],
           [49, 82, 48, 50, 100]]
stuscores =[]
tsum = 0
for i,score in enumerate(scores[0]):
    tsum = 0
    for j,student in enumerate(scores):
        tsum += scores[j][i]
    stuscores.append(tsum/3)
print(stuscores)
