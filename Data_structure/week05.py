def check_par(expression : str) -> bool: #실무에서 보기 편하라고 넣는거
    stack = []
    for letter in expression:
        if letter == "(":
            stack.append(letter)
        if letter == ")":
            if len(stack) == 0:
                return False
            else:
                stack.pop()
    return len(stack) == 0 #return value : True or False

print(check_par("2+3)"))