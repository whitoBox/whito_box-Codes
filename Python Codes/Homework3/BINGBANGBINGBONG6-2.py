nums = [int(input(f"{i+1}번째:")) for i in range(5)]
nums.reverse()
for i in nums:
    print(i,"",end="")
nums.sort()
print()
for i in nums:
    print(i,"",end="")
nums.reverse()
print()
for i in nums:
    print(i,"",end="")

