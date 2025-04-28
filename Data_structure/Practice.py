class tree_node():
    def __init__(self,data=None):
        self.data = data
        self.left = None
        self.right = None

def insert(root,data):
    data = tree_node(data)
    current = root
    if root.data is None:
        root = data
        return root

    while True:
        if data.data > current.data:
            if current.right is None:
                current.right = data
                break
            current = current.right

        else:
            if current.left is None:
                current.left = data
                break
            current = current.left
    return root

def preOrder(node):
    if node:
        print(node.data,end='-')
        preOrder(node.left)
        preOrder(node.right)
def postOrder(node):
    if node:
        postOrder(node.left)
        postOrder(node.right)
        print(node.data,end='-')
def inOrder(node):
    if node:
        inOrder(node.left)
        print(node.data,end='-')
        inOrder(node.right)

tree = tree_node()
nums = [5,51,6,8,48,100]
for num in nums:
    tree = insert(tree,num)

preOrder(tree)
print()
inOrder(tree)
print()
postOrder(tree)