#week 05_02

socnum = input("주민")

if a= '-' in socnum:
    gender = int(socnum[7])%2
else:
    gender = int(socnum[6])%2

if gender ==0:
    msg ="여"

else:
    msg ="남"

print(f"성별:{msg}")
