preco = float(input("Qual opreço do produto? R$: "))
novo = preco - (preco * 5 / 100)

print(F"O produto que custava {preco:.2f}, na promoção com 5% de desconto vai custa {novo:.2f}")