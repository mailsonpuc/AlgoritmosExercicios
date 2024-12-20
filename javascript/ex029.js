console.clear();

const velocidade = 100;

if (velocidade >80) {
    console.log("Multado voce excedeu o limite permitido que é de 80Km")
    multa = (velocidade-80) * 7;
    console.log(`Voce dever pagar uma multa de ${multa}`);
}
else
   console.log("Tenham um bom dia");
