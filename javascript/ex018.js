console.clear();

const angulo =  45;
const seno = Math.sin(angulo * (Math.PI / 180));
const cosseno = Math.cos(angulo * (Math.PI / 180));
const tangente = Math.tan(angulo * (Math.PI / 180));

console.log(`
o Angulo de ${angulo} tem o seno de: ${seno.toFixed(2)},
Cosseno: ${cosseno.toFixed(2)},
Tangente: ${tangente.toFixed(2)}
`);

