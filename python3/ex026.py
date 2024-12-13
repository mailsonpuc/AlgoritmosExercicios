frase = "Arara Azul".lower().strip()

print(F"A letra A aparece {frase.count('a')} vezes na frase")
print(F"A letra A aparece  na posição {frase.find('a')+1}")
print(F"A ultima letra A aparece na posição {frase.rfind('a')+1}")
