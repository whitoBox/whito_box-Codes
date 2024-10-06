scores = {'A':[49,43,49],
          'B':[80,60,82],
          'C':[20,85,48],
          'D':[100,30,50],
          'E':[80,90,100]}
avrs = [sum(i)/len(i) for i in scores.values()]
print(avrs)
