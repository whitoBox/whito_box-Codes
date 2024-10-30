#week10_01.py

myFile = "d:\\202444029A\\JohnKim.txt"

#열시
#f = open(myFile,'w') #쓰기모드 write
#f = open(myFile,'a') #추가모드 append

#쓰기 /읽기
#f.write("김요한\n")#파일에 '김요한'적기
#print(f.read())


#닫기
#f.close()

f = open(myFile,'r')
print(f.read())
f.close()
