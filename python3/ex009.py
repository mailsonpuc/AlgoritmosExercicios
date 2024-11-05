numero = int(input("Diigite um numero para ver sua tabuada: "))

print("-" * 10)
for num in range(10):
    print(F"{numero} X {num} = {numero * num}")
print("-" * 10)