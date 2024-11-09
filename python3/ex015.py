dias = int(input("quantos dias alugado?: "))
km = float(input("quantos km rodado? "))
pago = (dias * 60) + (km * 0.15)

print(F"O total a pagar é de {pago:.2f} R$")