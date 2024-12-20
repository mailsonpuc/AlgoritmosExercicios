velocidade = float(input("Qual a velocidade atual do carro? "))

if velocidade > 80:
    print(f"Multado voce excedeu o limite permitido que é de 80Km/h")
    multa = (velocidade-80) * 7
    print(f"Voce deve pgar uma multa de {multa:.2f} R$")
print("Tenham um bom dia, dirijar com segurança")