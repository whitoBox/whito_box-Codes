class Node:
    def __init__(self,data):
        self.data = data
        self.link = None

class Stack:
    def __init__(self):
        self.top = None

    def push(self,data):
        node = Node(data)
        if self.top is None:
            self.top = node
        else:
            node.next = self.top
            self.top = node

    def pop(self):
        if self.top is None:
            return 'Error: Stack is empty'
        popped_node = self.top
        self.top = self.top.link
        return f"popped: ({popped_node.data})"

s1 = Stack()
#print(s1.pop())
s1.push("data_structure")
s1.push("database")
s1.push("thing")
#print(s1.pop())
#print(s1.pop())
for i in range(2):
    print(s1.pop())