
try:
    numero = int(input("Me diga um número qualquer: "))
    
    if(numero %2==0):
        print("o número é par")

    else:
       print("impar")
except:
    print("Ocorreu um erro, digite apenas numeros")