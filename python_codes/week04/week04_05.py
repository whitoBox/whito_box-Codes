#04_05

cars = ['audi','tesla','benz','kia','lincoln','hyundai']
print(cars)

#오름차순 (정방향,asc) 으로 정렬
cars.sort()
print(cars)

#내림차순 (역방향,dec) 으로 정렬
cars.sort(reverse=True)
print(cars)

#sorted() 함수
cars = ['audi','tesla','benz','kia','lincoln','hyundai']
cars_copy = sorted(cars)
print(cars)
print(cars_copy)

cars_copy = sorted(cars,reverse=True)
print(cars)
print(cars_copy)

#index를 역배치
cars_copy = cars[:]
print(id(cars))
print(id(cars_copy))
cars_copy.reverse()
print(cars)
print(cars_copy)
