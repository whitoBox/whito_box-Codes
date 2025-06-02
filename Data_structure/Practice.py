def is_connected (te, v) -> bool:
    pass

v,e = map(int, input().split()) #정점 ,간선 입력
edges = list()

for _ in range(e):
    a,b,cost = map(int, input().split())
    edges.append((cost,a,b))

print(edges)
edges.sort(reverse=True)
print(edges)

selected_edges = edges[:]

total_cost = sum(cost for cost,a,b in edges)


for cost,a,b in edges:
    temp_edges = [(c,x,y) for c,x,y in selected_edges]
    if is_connected(temp_edges, v):
        selected_edges = temp_edges
        total_cost = total_cost - cost
        print(f"간선 ({a}----{b}, 가중치 : {cost}) 제거, 현 시점 촘 가중치: ({total_cost})")
    else:
        print(f"간선 ({a}----{b}, 가중치 : {cost}) 유지: (제거하면 연결 끊어짐)")

print(f"\n 최소 신장 트리의 총 가중치: {total_cost}")

for cost,a,b in sorted(selected_edges):
    print(f"{a}----{b}, {cost}")

'''
6 9
0 1 10
0 2 15
1 2 40
1 3 11
1 4 50
2 3 12
3 4 20
3 5 30
4 5 25
'''