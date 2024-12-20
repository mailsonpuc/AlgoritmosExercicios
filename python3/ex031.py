d = float(input("Qual é a distancia da sua viagem? "))
print(f"Voce esta prestes a começar um VVIGem de {d}KM")
preco = d * 0.50 if d <=200 else d * 0.45
print(f"E o preço da sua passagem sera de {preco:.2f}R$")