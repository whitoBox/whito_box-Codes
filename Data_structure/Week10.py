class TreeNode:
	def __init__(self):
		self.left = None
		self.data = None
		self.right = None


def post_order(node):
    if node:
        post_order(node.left)
        post_order(node.right)
        print(node.data, end='-')

def in_order(node):
    if node:
        post_order(node.left)
        print(node.data, end='-')
        post_order(node.right)

def pre_order(node):
    if node:
        print(node.data, end='-')
        post_order(node.left)
        post_order(node.right)


def insert(root, value):
    new_node = TreeNode()
    new_node.data = value

    if root is None:  # 첫 번째 노드일때 처리
        return new_node

    current = root
    while True:
        if value < current.data:
            if current.left is None:
                current.left = new_node
                break
            current = current.left  # move
        else:
            if current.right is None:
                current.right = new_node
                break
            current = current.right  # move
    return root

def search(find_number):
    current = root
    while True:
        if find_number == current.data:
            return True
        elif find_number < current.data:
            if current.left is None:
                return False
            current = current.left
        else:
            if current.right is None:
                return False
            current = current.right

def delete(node, value):
    if node is None:
        return None

    if value < node.data:
        node.left = delete(node.left,value)
    elif value > node.data:
        node.right = delete(node.right,value)
    else:
         # 삭제할 노드 발견
         #자식이 없는 leaf노드거나 자식이 하나만 있는 경우
         if node.left is None:
             return node.right
         elif node.right is None:
             return node.left
        #자식이 2개인 경우
    return node

if __name__ == "__main__":
    numbers = [8, 15, 10, 3, 9, 14]
    root = None

    for number in numbers:
        root = insert(root, number)

    print("BST 구성 완료")
    post_order(root)  # 3 9 8 15 10
    print()
    # search_num = int(input("찾으려는 값:"))
    # if search(search_num):
    #     print(f"{search_num} 를 찾았습니다")
    # else:
    #     print(f"{search_num}가 없습니다")

    del_number = int(input("제어하고 싶은 값: "))
    root = delete(root, del_number)
    post_order(root)