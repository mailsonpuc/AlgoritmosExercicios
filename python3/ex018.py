import math

angulo = float(input("Digite o angulo que voce quer: "))
seno = math.sin(math.radians(angulo))
cosseno = math.cos(math.radians(angulo))
tangente = math.tan(math.radians(angulo))

print(f"""
o Angulo de {angulo} tem o seno de: {seno:.2f},
Cosseno: {cosseno:.2f},
Tangente: {tangente:.2f}
""")

