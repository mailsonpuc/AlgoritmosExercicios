console.clear();


const { randomInt } = require('crypto');

const computador = randomInt(0, 6);
const jogador = 3;

console.log("PROCESSANDO...");

setTimeout(() => {}, 400);

if (jogador === computador) {
    console.log("Parabens, voce conseguiu me vencer");
} else {
    console.log(`Ganhei, eu pensei no numero ${computador} e não no ${jogador}`);
}

