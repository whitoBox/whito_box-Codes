class Node: #링크드 리스트에 들어갈 하나의 노드
    def __init__(self, data, link = None):
        self.data = data
        self.link = link

class LinkedList:
    def __init__(self):
        self.head = None

    def append(self,data):
        if not self.head : #링크드 리스트가 비어 있으면
            self.head = Node(data)
            return
        current = self.head
        while current.link:
            current = current.link
        current.link = Node(data)

    def serch(self,target):
        current = self.head
        while current.link:
            if current.data == target:
                return f"{target},found"
            else:
                current= current.link
            current = current.link
        return f"{target}, not found"

    def __str__(self):
        node = self.head
        out_text = ""
        while node is not None:
            out_text = out_text + str(node.data) + " -> "
            node = node.link
        return out_text + "Null"


ll = LinkedList()
ll.append(8)
ll.append(10)
ll.append(-9)
print(ll.serch(100))
print(ll.serch(10))
print(ll)