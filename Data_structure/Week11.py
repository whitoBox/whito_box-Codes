graph = [
    [0, 1, 1, 0, 0, 0, 0, 0],
    [1, 0, 0, 1, 0, 0, 0, 0],
    [1, 0, 0, 1, 0, 0, 0, 0],
    [0, 1, 1, 0, 1, 1, 1, 0],
    [0, 0, 0, 1, 0, 1, 0, 0],
    [0, 0, 0, 1, 1, 0, 0, 0],
    [0, 0, 0, 1, 0, 0, 0, 1],
    [0, 0, 0, 0, 0, 0, 1, 0]
]
graph2 = [
    [0, 0, 1, 1, 0, 0, 0, 0],  # A–C, A–D
    [0, 0, 1, 0, 0, 0, 0, 0],  # B–C
    [1, 1, 0, 0, 0, 0, 0, 0],  # C–A, C–B
    [1, 0, 0, 0, 1, 0, 0, 0],  # D–A, D–E
    [0, 0, 0, 1, 0, 1, 0, 0],  # E–D, E–F
    [0, 0, 0, 0, 1, 0, 1, 0],  # F–E, F–G
    [0, 0, 0, 0, 0, 1, 0, 1],  # G–F, G–H
    [0, 0, 0, 0, 0, 0, 1, 0],  # H–G
]
def dfs (g,i,visited):
    visited[i] = 1
    print(chr(ord('A')+i), end='')
    for j in range(len(g)):
        if g[i][j] == 1 and not visited[j]:
            dfs(g, j, visited)

def bfs(g,i, visited):
    pass

visited_dfs = [0 for _ in range(len(graph2))]
visited_bfs = [0 for _ in range(len(graph2))]
dfs(graph, 2, visited_dfs)
print()
bfs(graph, 0, visited_dfs)
