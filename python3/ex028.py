from random import randint
from time import sleep


computador = randint(0, 5)
jogador = int(input("Em que nome eu persei? "))

print("PROCESSANDO")
sleep(0.4)


if jogador == computador:
    print("Parabens, voce conseguiu me vencer")

else:
    print(F"Ganhei, eu pensei  no numero {computador} e náo no {jogador}")